namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Hotel;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
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
        public async Task<int> GetHotelsCountAsync()
        {
            return await repository.AllReadOnly<Hotel>()
                .CountAsync();
        }

        public int GetDurationDays(string reservationId)
        {
            var hr = repository.AllReadOnly<HotelReservation>()
                .Where(hr => hr.Id == reservationId).First();

            return (int)(hr.EndDate - hr.StartDate).TotalDays;
        }

        public decimal GetTotalPrice(int roomId)
        {
            var hr = repository.AllReadOnly<HotelReservation>()
                .Where(hr => hr.Room_Id == roomId).First();

            var room = repository.AllReadOnly<Room>()
                .Where(r => r.Id == roomId).First();

            return room.PricePerNight * (int)(hr.EndDate - hr.StartDate).TotalDays;
        }

        public string GetHotelImageUrl(int hotelId)
        {
            var hr = repository.AllReadOnly<HotelReservation>()
                .Where(hr => hr.Hotel_Id == hotelId).First();

            var hotel = repository.AllReadOnly<Hotel>()
                .Where(h => h.Id == hotelId).First();

            return hotel.ImageUrl;
        }

        public async Task<bool> RoomExistsAsync(int roomId)
        {
            return await repository.AllReadOnly<Room>()
                .AnyAsync(r => r.Id == roomId);
        }


        public async Task<IEnumerable<HotelAllViewModel>> AllAsync()
        {
            return await repository.AllReadOnly<Hotel>()
                .Where(h => h.IsActive == true)
                .Select(h => new HotelAllViewModel()
                {
                    Id = h.Id,
                    Name = h.Name,
                    CityName = h.City.Name,
                    CityId = h.City.Id,
                    StarRate = h.StarRate,
                    ImageUrl = h.ImageUrl,
                    Rooms = repository.AllReadOnly<Room>()
                                .Where(r => r.Hotel_Id == h.Id).ToList()
                }).ToListAsync();
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
                CityName = hotel.City.Name,
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
        public async Task ReserveAsync(HotelReservationInputModel model, string userId)
        {
            var room = await repository.AllReadOnly<Room>()
                .Where(r => r.Id == model.Room_Id)
                .FirstOrDefaultAsync();

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

            await repository.AddAsync<HotelReservation>(hrf);
            await repository.SaveChangesAsync();
        }



        public async Task<HotelReservationInputModel> GetForReserveAsync(int hotelId)
        {
            var hotel = await repository.AllReadOnly<Hotel>()
                .Where(h => h.Id == hotelId).FirstOrDefaultAsync();

            if(hotel ==null)
            {
                throw new ArgumentException("The hotel does not exist!");
            }

            return new HotelReservationInputModel()
            {
                Hotel_Id = hotelId,
                Rooms = await GetRoomsAsync(hotelId)
            };
        }

        public async Task<IEnumerable<HotelReservationVerifyViewModel>> GetForVerifyReservationAsync(string userId)
        {
            return await repository.AllReadOnly<HotelReservation>()
                .Where(hr => hr.User_Id == userId && hr.IsActive == false)
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

        public async Task VerifyReservationAsync(string reservationId)
        {
            var res = await repository.All<HotelReservation>()
                .FirstOrDefaultAsync(hr => hr.Id == reservationId);         

            if(res == null)
            {
                throw new ArgumentException("The current hotel reservation does not exist!");
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

        public async Task CancellVerificationAsync(string reservationId)
        {
            var hr = await repository.All<HotelReservation>()
                .Where(hr => hr.Id == reservationId).FirstOrDefaultAsync();

            if(hr == null)
            {
                throw new ArgumentException("The hotel reservation does not exist!");
            }

            var room = await repository.All<Room>()
                .Where(r => r.Id == hr.Room_Id).FirstOrDefaultAsync();

            if(room == null)
            {
                throw new ArgumentException("The room does not exist!");
            }

            if(room.IsActive == true)
            {
                room.Count += 1;
            }

            repository.Delete(hr);
           
            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<HotelReservationViewModel>> AllReservationsAsync(string userId)
        {
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
                    HotelName = hr.Hotel.Name,
                    HotelImageUrl = hr.Hotel.ImageUrl,
                    Price = hr.Price,
                    RoomType = hr.Room.Type.ToString(),
                    StartDate = hr.StartDate.ToString(DateTimeFormat),
                    EndDate = hr.EndDate.ToString(DateTimeFormat),
                    CreatedOn = hr.CreatedOn.ToString(CreatedOnFormat),
                })
                .ToListAsync();
        }
    }
}
