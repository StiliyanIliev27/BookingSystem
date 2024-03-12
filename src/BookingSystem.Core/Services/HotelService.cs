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

        public decimal GetTotalPrice(string reservationId)
        {
            var hr = repository.AllReadOnly<HotelReservation>()
                .Where(hr => hr.Id == reservationId).First();

            var room = repository.AllReadOnly<Room>()
                .Where(r => r.Id == hr.Room_Id).First();

            return room.PricePerNight * (int)(hr.EndDate - hr.StartDate).TotalDays;
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

        public async Task<IEnumerable<HotelReservationVerifyViewModel>> VerifyReservationAsync(string reservationId)
        {
            return await repository.AllReadOnly<HotelReservation>()
                .Where(hr => hr.Id == reservationId)
                .Select(hr => new HotelReservationVerifyViewModel()
                {
                    FirstName = hr.FirstName,
                    LastName = hr.LastName,
                    RoomType = repository.AllReadOnly<Room>()
                         .Where(r => r.Id == hr.Room_Id).First().Type.ToString(),
                    HotelName = repository.AllReadOnly<Hotel>()
                         .Where(h => h.Id == hr.Hotel_Id).First().Name,
                    HotelStarRate = repository.AllReadOnly<Hotel>()
                         .Where(h => h.Id == hr.Hotel_Id).First().StarRate,
                    HotelImageUrl = repository.AllReadOnly<Hotel>().First().ImageUrl,
                    Price = GetTotalPrice(reservationId),
                    Nights = GetDurationDays(reservationId),
                    StartDate = hr.StartDate.ToString(DateTimeFormat),
                    EndDate = hr.EndDate.ToString(DateTimeFormat),
                })
                .ToListAsync();            
        }
    }
}
