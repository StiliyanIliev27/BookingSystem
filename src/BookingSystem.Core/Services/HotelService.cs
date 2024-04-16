namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Exceptions;
    using BookingSystem.Core.Models.Hotel;
    using BookingSystem.Core.Models.Location;
    using BookingSystem.Core.Models.QueryModels.Hotel;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Enums;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using System.Globalization;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Hotel;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.HotelReservation;
    public class HotelService : IHotelService
    {
        private readonly IRepository repository;
        public HotelService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Room>> GetRoomsAsync(int hotelId)
        {
            return await repository.AllReadOnly<Room>()
                .Where(r => r.Hotel_Id == hotelId)
                .ToListAsync();
        }

        public async Task<Room> GetRoomAsync(int roomId)
        {
            return await repository.AllReadOnly<Room>()
                .FirstAsync(r => r.Id == roomId);
        }
        public async Task<int> GetHotelsCountAsync()
        {
            return await repository.AllReadOnly<Hotel>()
                .CountAsync();
        }       

        public async Task<bool> HotelExistsAsync(int hotelId)
        {
            return await repository.AllReadOnly<Hotel>()
                .AnyAsync(h => h.Id == hotelId);
        }

        public async Task<bool> HotelReservationExistsAsync(string reservationId)
        {
            return await repository.AllReadOnly<HotelReservation>()
                .AnyAsync(hr => hr.Id == reservationId);
        }
        
        public async Task<bool> HotelVerificationExistsAsync(string verificationId)
        {
            return await repository.AllReadOnly<HotelReservation>()
                .AnyAsync(hr => hr.Id == verificationId && hr.IsActive == false
                    && hr.StartDate.Date >= DateTime.Now.Date);
        }

        public async Task<bool> RoomExistsAsync(int roomId)
        {
            return await repository.AllReadOnly<Room>()
                .AnyAsync(r => r.Id == roomId);
        }

        public async Task<IEnumerable<string>> AllCitiesNamesAsync()
        {
            return await repository.AllReadOnly<City>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<int> GetPreviousActiveHotelIdAsync(int currentHotelId)
        {
            int? lastHotelId = await repository.AllReadOnly<Hotel>()
                .Where(h => h.Id < currentHotelId && h.IsActive)
                .OrderByDescending(h => h.Id)
                .Select(h => h.Id)
                .FirstOrDefaultAsync();

            if (lastHotelId == 0)
            {
                return await GetLastActiveHotelIdAsync();
            }

            return (int)lastHotelId;
        }

        public async Task<int> GetNextActiveHotelIdAsync(int currentHotelId)
        {
            int nextHotelId = await repository.AllReadOnly<Hotel>()
                .Where(h => h.Id > currentHotelId && h.IsActive)
                .OrderBy(h => h.Id)
                .Select(h => h.Id)
                .FirstOrDefaultAsync();

            if (nextHotelId == 0)
            {
                return await GetFirstActiveHotelIdAsync();
            }

            return (int)nextHotelId;
        }

        public async Task<int> GetFirstActiveHotelIdAsync()
        {
            return await repository.AllReadOnly<Hotel>()
                .Where(h => h.IsActive)
                .OrderBy(h => h.Id)
                .Select(h => h.Id)
                .FirstAsync();
        }

        public async Task<int> GetLastActiveHotelIdAsync()
        {
            return await repository.AllReadOnly<Hotel>()
                .Where(h => h.IsActive)
                .OrderByDescending(h => h.Id)
                .Select(h => h.Id)
                .FirstAsync();
        }

        //public async Task<IEnumerable<HotelAllViewModel>> AllAsync()
        //{
        //    return await repository.AllReadOnly<Hotel>()
        //        .Where(h => h.IsActive == true)
        //        .Select(h => new HotelAllViewModel()
        //        {
        //            Id = h.Id,
        //            Name = h.Name,
        //            CityName = h.City.Name,
        //            CityId = h.City.Id,
        //            StarRate = h.StarRate,
        //            ImageUrl = h.ImageUrl,
        //            Rooms = repository.AllReadOnly<Room>()
        //                        .Where(r => r.Hotel_Id == h.Id).ToList()
        //        }).ToListAsync();
        //}       

        public async Task<IEnumerable<HotelIndexPageModel>> LastThreeHotelsAsync()
        {
            return await repository
                .AllReadOnly<Hotel>()
                .Where(h => h.IsActive)
                .OrderByDescending(h => h.Id)
                .Take(3)
                .Select(h => new HotelIndexPageModel()
                {
                    Id = h.Id,
                    Name = h.Name,
                    Address = h.Address,
                    ImageUrl = h.ImageUrl,
                })
                .ToListAsync();
        }
        public async Task<HotelQueryServiceModel> AllAsync(
            string? city = null,
            string? searchTerm = null,
            HotelSorting sorting = HotelSorting.Newest,
            int currentPage = 1,
            int hotelsPerPage = 4)
        {
            var hotelsToShow = repository.AllReadOnly<Hotel>().Where(h => h.IsActive == true);

            if (city != null)
            {
                hotelsToShow = hotelsToShow
                    .Where(h => h.City.Name == city);
            }

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();
                hotelsToShow = hotelsToShow
                    .Where(h => h.Name.ToLower().Contains(normalizedSearchTerm) ||
                                         h.Address.ToLower().Contains(normalizedSearchTerm));
            }

            hotelsToShow = sorting switch
            {
                HotelSorting.Oldest => hotelsToShow.OrderBy(h => h.Id),
                HotelSorting.PriceAscending => hotelsToShow.OrderBy(h =>
                    repository.AllReadOnly<Room>().Where(r => r.Hotel_Id == h.Id).Average(r => r.PricePerNight)),
                HotelSorting.PriceDescending => hotelsToShow.OrderByDescending(h =>
                    repository.AllReadOnly<Room>().Where(r => r.Hotel_Id == h.Id).Average(r => r.PricePerNight)),
                _ => hotelsToShow.OrderByDescending(h => h.Id)
            };

            var hotels = await hotelsToShow
                .Skip((currentPage - 1) * hotelsPerPage)
                .Take(hotelsPerPage)
                .Include(h => h.City)
                .Select(h => new HotelServiceModel()
                {
                    Id = h.Id,
                    Name = h.Name,
                    Address = h.Address,
                    CityName = h.City.Name,
                    CityId = h.City.Id,
                    StarRate = h.StarRate,
                    ImageUrl = h.ImageUrl,
                    RoomsTypes = repository.AllReadOnly<Room>()
                                .Where(r => r.Hotel_Id == h.Id)
                                .Select(r => new RoomTypeViewModel()
                                {
                                    Type = r.Type.ToString(),
                                }).ToList()
                }).ToListAsync();

            int totalHotels = await hotelsToShow.CountAsync();

            return new HotelQueryServiceModel()
            {
                TotalHotelsCount = totalHotels,
                Hotels = hotels
            };
        }
        
        public async Task<HotelDetailsViewModel> DetailsAsync(int hotelId)
        {
            var hotel = await repository.AllReadOnly<Hotel>()
                .Include(h => h.City)
                .Include(h => h.City.Country)
                .Where(h => h.Id == hotelId && h.IsActive == true)
                .FirstOrDefaultAsync();

            if(hotel == null)
            {
                throw new ArgumentException("The hotel was not found!");
            }

            return new HotelDetailsViewModel()
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Address = hotel.Address,
                City = new Models.Location.CityViewModel
                    {
                        Id = hotel.City.Id,
                        Name = hotel.City.Name
                    },
                CountryName = hotel.City.Country.Name,
                StarRate = hotel.StarRate,
                Details = hotel.Details,
                ImageUrl = hotel.ImageUrl,
                CheckIn = hotel.CheckIn.ToString(TimeFormat),
                CheckOut = hotel.CheckOut.ToString(TimeFormat),
                Parking = hotel.Parking,
                Pets = hotel.Pets,
                Rooms = await GetRoomsAsync(hotelId),
                HotelsCount = await GetHotelsCountAsync()
            };
        }
        public async Task<string> ReserveAsync(HotelReservationInputModel model, string userId)
        {
            var room = await repository.GetByIdAsync<Room>(model.Room_Id);

            if(room == null)
            {
                throw new ArgumentException("The room was not found!");
            }

            var hrf = new HotelReservation()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Room_Id = room.Id,
                Hotel_Id = room.Hotel_Id,
                Price = 0.0m,
                StartDate = DateTime.ParseExact(model.StartDate, DateTimeFormat,
                                CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact(model.EndDate, DateTimeFormat,
                                CultureInfo.InvariantCulture, DateTimeStyles.None),
                User_Id = userId,
                CreatedOn = DateTime.Now
            };

            await repository.AddAsync(hrf);
            await repository.SaveChangesAsync();

            return hrf.Id;
        }

        public async Task<HotelReservationInputModel> GetForReserveAsync(int hotelId)
        {
            var hotel = await repository.GetByIdAsync<Hotel>(hotelId);

            if(hotel == null)
            {
                throw new ArgumentException("The hotel does not exist!");
            }

            return new HotelReservationInputModel()
            {
                Hotel_Id = hotelId,
                Rooms = await GetRoomsAsync(hotelId),
                Name = hotel.Name,
                Address = hotel.Address
            };
        }

        public async Task<IEnumerable<HotelReservationVerifyViewModel>> GetForVerifyReservationAsync(string userId)
        {
            var verificationsToRemove = await repository.All<HotelReservation>()
                .Where(hr => hr.User_Id == userId && hr.IsActive == false
                    && hr.EndDate.Date < DateTime.Now.Date)
                .ToListAsync();

            if(verificationsToRemove.Any())
            {
                foreach(var ver in verificationsToRemove)
                {
                    repository.Delete(ver);
                }

                await repository.SaveChangesAsync();
            }

            return await repository.AllReadOnly<HotelReservation>()
                .Where(hr => hr.User_Id == userId && hr.IsActive == false && hr.StartDate.Date >= DateTime.Now.Date)
                .Select(hr => new HotelReservationVerifyViewModel()
                {
                    Id = hr.Id,
                    FirstName = hr.FirstName,
                    LastName = hr.LastName,
                    RoomType = repository.AllReadOnly<Room>()
                         .Where(r => r.Id == hr.Room_Id).First().Type.ToString(),
                    HotelName = repository.AllReadOnly<Hotel>()
                         .Where(h => h.Id == hr.Hotel_Id).First().Name,
                    HotelStarRate = repository.AllReadOnly<Hotel>()
                         .Where(h => h.Id == hr.Hotel_Id).First().StarRate,
                    HotelImageUrl = repository.AllReadOnly<Hotel>()
                         .Where(h => h.Id == hr.Hotel_Id).First().ImageUrl,
                    Price = (repository.AllReadOnly<Room>()
                         .Where(r => r.Id == hr.Room_Id).First().PricePerNight) * ((int)(hr.EndDate - hr.StartDate).TotalDays),
                    Nights = ((int)(hr.EndDate - hr.StartDate).TotalDays),
                    StartDate = hr.StartDate.ToString(DateTimeFormat),
                    EndDate = hr.EndDate.ToString(DateTimeFormat),
                })
                .ToListAsync();            
        }

        public async Task VerifyReservationAsync(string reservationId, string userId)
        {
            var res = await repository.GetByIdAsync<HotelReservation>(reservationId);        

            if(res == null)
            {
                throw new ArgumentException("The current hotel reservation does not exist!");
            }

            if (res.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            var room = await repository.All<Room>()
                .FirstOrDefaultAsync(r => r.Id == res.Room_Id);

            if(room == null)
            {
                throw new ArgumentException("The current room does not exist!");
            }            

            if(room.Count > 0)
            {
                room.Count -= 1;
            }
            else
            {
                throw new ArgumentException("No more rooms are available for the current time!");
            }

            res.Price = room.PricePerNight * (int)(res.EndDate - res.StartDate).TotalDays;
            res.IsActive = true;

            await repository.SaveChangesAsync();
        }

        public async Task CancellVerificationAsync(string reservationId, string userId)
        {
            var hr = await repository.GetByIdAsync<HotelReservation>(reservationId);

            if(hr == null)
            {
                throw new ArgumentException("The hotel reservation does not exist!");
            }

            if (hr.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            var room = await repository.All<Room>()
                .Where(r => r.Id == hr.Room_Id).FirstOrDefaultAsync();

            if(room == null)
            {
                throw new ArgumentException("The room does not exist!");
            }

            if(room.IsActive == true)
            {
                if(room.Count < 5)
                {
                    room.Count += 1;
                }
            }

            repository.Delete(hr);
           
            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<HotelReservationViewModel>> AllReservationsAsync(string userId)
        {
            var invalidRes = await repository.All<HotelReservation>()
                .Where(hr => hr.EndDate.Date < DateTime.Now.Date 
                    && hr.IsActive == true && hr.User_Id == userId)
                .Include(hr => hr.Room)
                .ToListAsync();

            if(invalidRes.Any())
            {
                foreach (var res in invalidRes)
                {
                    res.IsActive = false;

                    if (res.Room.Count < 5)
                    {
                        res.Room.Count += 1;
                    }
                }

                await repository.SaveChangesAsync();
            }

            return await repository.AllReadOnly<HotelReservation>()
                .Where(hr => hr.User_Id == userId && hr.IsActive == true)
                .Include(hr => hr.Hotel)
                .Include(hr => hr.Room)
                .Select(hr => new HotelReservationViewModel()
                {
                    Id = hr.Id,
                    FirstName = hr.FirstName,
                    LastName = hr.LastName,
                    Hotel_Id = hr.Hotel_Id,
                    Name = hr.Hotel.Name,
                    HotelImageUrl = hr.Hotel.ImageUrl,
                    Price = hr.Price,
                    RoomType = hr.Room.Type.ToString(),
                    StartDate = hr.StartDate.ToString(DateTimeFormat),
                    EndDate = hr.EndDate.ToString(DateTimeFormat),
                    CreatedOn = hr.CreatedOn.ToString(CreatedOnFormat),
                    Address = hr.Hotel.Address
                })
                .ToListAsync();
        }

        public async Task<HotelReservationEditInputModel> GetForEditReservationAsync(string reservationId, string userId)
        {
            var hr = await repository.GetByIdAsync<HotelReservation>(reservationId);

            if(hr == null)
            {
                throw new ArgumentException("The hotel reservation does not exist!");
            }

            if(hr.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            if (hr.IsActive == false)
            {
                throw new NoLongerActiveReservationException();
            }

            return new HotelReservationEditInputModel()
            {
                Id = hr.Id,
                FirstName = hr.FirstName,
                LastName = hr.LastName
            };
        }

        public async Task EditReservationAsync(HotelReservationEditInputModel model, string userId)
        {
            var hr = await repository.GetByIdAsync<HotelReservation>(model.Id);

            if (hr == null)
            {
                throw new ArgumentException("The hotel reservation does not exist!");
            }

            if (hr.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            if(hr.IsActive == false)
            {
                throw new NoLongerActiveReservationException();
            }

            hr.FirstName = model.FirstName;
            hr.LastName = model.LastName;

            await repository.SaveChangesAsync();
        }

        public async Task CancellReservationAsync(string reservationId, string userId)
        {
            var hr = await repository.GetByIdAsync<HotelReservation>(reservationId);

            if (hr == null)
            {
                throw new ArgumentException("The hotel reservation does not exist!");
            }

            if(hr.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            if(hr.IsActive == false)
            {
                throw new NoLongerActiveReservationException();
            }

            var room = await repository.All<Room>()
                .Where(r => r.Id == hr.Room_Id).FirstOrDefaultAsync();

            if (room == null)
            {
                throw new ArgumentException("The room does not exist!");
            }

            if (room.IsActive == true)
            {
                if(room.Count < 5)
                {
                    room.Count += 1;
                }
            }

            repository.Delete(hr);

            await repository.SaveChangesAsync();
        }

        public async Task<HotelEditAddInputModel> GetForEditAsync(int hotelId)
        {
            var hotel = await repository.GetByIdAsync<Hotel>(hotelId);

            if(hotel == null)
            {
                throw new ArgumentException("The hotel was not found!");
            }

            return new HotelEditAddInputModel()
            {
                Id = hotel.Id,
                Name = hotel.Name,
                StarRate = hotel.StarRate,
                Address = hotel.Address,
                Details = hotel.Details,
                CheckIn = hotel.CheckIn.ToString(TimeFormat),
                CheckOut = hotel.CheckOut.ToString(TimeFormat),
                ImageUrl = hotel.ImageUrl,
                Parking = (bool)hotel.Parking! ? "Available" : "Not Available",
                Pets = (bool)hotel.Pets! ? "Allowed" : "Not Allowed"
            };
        }

        public async Task EditAsync(HotelEditAddInputModel model)
        {
            var hotel = await repository.GetByIdAsync<Hotel>(model.Id);
            
            if(hotel == null) 
            {
                throw new ArgumentException("The hotel was not found!");
            }

            bool parkingStatus = false;
            bool petStatus = false;

            if(model.Parking == "Available")
            {
                parkingStatus = true;
            }

            if (model.Pets == "Allowed")
            {
                petStatus = true;
            }

            hotel.Name = model.Name;
            hotel.StarRate = model.StarRate;
            hotel.Address = model.Address;
            hotel.Details = model.Details;
            hotel.CheckIn = DateTime.ParseExact(model.CheckIn, TimeFormat, CultureInfo.InvariantCulture);
            hotel.CheckOut = DateTime.ParseExact(model.CheckOut, TimeFormat, CultureInfo.InvariantCulture);
            hotel.Parking = parkingStatus;
            hotel.Pets = petStatus;
            hotel.ImageUrl = model.ImageUrl;

            await repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int hotelId)
        {
            var hotel = await repository.GetByIdAsync<Hotel>(hotelId);

            if(hotel == null)
            {
                throw new ArgumentException("The hotel was not found!");
            }

            var hotelReservations = await repository.All<HotelReservation>()
                .Where(hr => hr.Hotel_Id == hotelId).ToListAsync();

            if(hotelReservations.Any())
            {
                foreach(var reservation in hotelReservations)
                {
                    repository.Delete(reservation);
                }
            }

            var roomsToDelete = await repository.All<Room>()
                .Where(r => r.Hotel_Id == hotel.Id).ToListAsync();

            if(roomsToDelete.Any())
            {
                foreach (var room in roomsToDelete)
                {
                    repository.Delete(room);
                }
            }

            hotel.IsActive = false;

            await repository.SaveChangesAsync();
        }

        public async Task AddAsync(HotelEditAddInputModel model)
        {
            bool parkingStatus = false;
            bool petStatus = false;

            if (model.Parking == "Available")
            {
                parkingStatus = true;
            }

            if (model.Pets == "Allowed")
            {
                petStatus = true;
            }

            var hotel = new Hotel()
            {
                Name = model.Name,
                Address = model.Address,
                Details = model.Details,
                StarRate = model.StarRate,
                City_Id = model.City_Id,
                CheckIn = DateTime.ParseExact(model.CheckIn, TimeFormat, CultureInfo.InvariantCulture),
                CheckOut = DateTime.ParseExact(model.CheckOut, TimeFormat, CultureInfo.InvariantCulture),
                ImageUrl = model.ImageUrl,
                Parking = parkingStatus,
                Pets = petStatus,
                IsActive = true
            };

            await repository.AddAsync(hotel);
            await repository.SaveChangesAsync();
        }

        public async Task<HotelEditAddInputModel> GetForAddAsync()
        {
            return new HotelEditAddInputModel()
            {
                Cities = await GetAllCitiesAsync(),
            };
        }

        public async Task<IEnumerable<CityFormModel>> GetAllCitiesAsync()
        {
            return await repository.AllReadOnly<City>()
                .Select(c => new CityFormModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();
        }

        public async Task<RoomInputModel> GetForAddRoomAsync(int hotelId)
        {
            var hotel = await repository.GetByIdAsync<Hotel>(hotelId);

            if(hotel == null)
            {
                throw new ArgumentException("The hotel does not exists!");
            }

            return new RoomInputModel()
            {
                Hotel_Id = hotelId,
                Types = await GetAllValidRoomTypesAsync(hotelId),
                Name = hotel.Name,
                Address = hotel.Address
            };
        }

        public async Task AddRoomAsync(RoomInputModel model)
        {
            var hotel = await repository.GetByIdAsync<Hotel>(model.Id);

            if (hotel == null)
            {
                throw new ArgumentException("Hotel does not exist!");
            }

            model.Name = hotel.Name;
            model.Address = hotel.Address;

            bool wifi = false;

            if(model.Wifi == "Available")
            {
                wifi = true;
            }
            else if(model.Wifi == "Not Available")
            {
                wifi = false;
            }

            RoomType type;        
            _ = Enum.TryParse(model.Type, out type);

            var room = new Room()
            {
                Hotel_Id = model.Id,
                Count = 5,
                PricePerNight = model.PricePerNight,
                Type = type,
                WiFi = wifi,
                IsActive = true
            };

            await repository.AddAsync(room);
            await repository.SaveChangesAsync();
        }

        public IEnumerable<string> GetAllRoomTypes()
        {
            return new List<string>
            {
                "Single",
                "Double",
                "Triple",
                "Apartment"
            };
        }

        public async Task<IEnumerable<string>> GetAllValidRoomTypesAsync(int hotelId)
        {
            var roomTypes = await repository.AllReadOnly<Room>()
                .Where(r => r.Hotel_Id == hotelId)
                .Select(r => r.Type.ToString())
                .ToListAsync();

            ICollection<string> validRoomTypes = new HashSet<string>();

            foreach (var roomType in GetAllRoomTypes())
            {
                if (!roomTypes.Contains(roomType))
                {
                    validRoomTypes.Add(roomType);
                }
            }

            return validRoomTypes;
        }

        public async Task<RoomEditInputModel> GetForEditRoomAsync(int roomId)
        {
            var room = await repository.AllReadOnly<Room>()
                .Where(r => r.Id == roomId).FirstOrDefaultAsync();

            if (room == null)
            {
                throw new ArgumentException("The room does not exist!");
            }

            var hotel = await repository.AllReadOnly<Hotel>()
                .Where(h => h.Id == room.Hotel_Id).FirstOrDefaultAsync();

            if(hotel == null)
            {
                throw new ArgumentException("The hotel does not exist!");
            }

            return new RoomEditInputModel()
            {
                Id = roomId,
                Hotel_Id = room.Hotel_Id,
                PricePerNight = room.PricePerNight,
                Name = hotel.Name,
                Address = hotel.Address
            };
        }

        public async Task EditRoomAsync(RoomEditInputModel model)
        {
            var room = await repository.GetByIdAsync<Room>(model.Id);

            if(room == null)
            {
                throw new ArgumentException("The room does not exist!");
            }

            var hotel = await repository.GetByIdAsync<Hotel>(room.Hotel_Id);

            if(hotel == null)
            {
                throw new ArgumentException("The hotel does not exist!");
            }

            model.Name = hotel.Name;
            model.Address = hotel.Address;
            model.Hotel_Id = hotel.Id;

            room.PricePerNight = model.PricePerNight;

            await repository.SaveChangesAsync();
        }

        public async Task DeleteRoomAsync(int roomId)
        {
            var room = await repository.GetByIdAsync<Room>(roomId);

            if(room == null)
            {
                throw new ArgumentException("The room does not exist!");
            }

            repository.Delete(room);
            await repository.SaveChangesAsync();
        }     
    }
}
