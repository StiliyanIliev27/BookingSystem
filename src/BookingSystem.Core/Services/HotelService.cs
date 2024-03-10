namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Hotel;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using Microsoft.EntityFrameworkCore;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Hotel;

    public class HotelService : IHotelService
    {
        private readonly IRepository repository;
        public HotelService(IRepository repository)
        {
            this.repository = repository;
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
        private async Task<IEnumerable<Room>> GetRoomsAsync(int hotelId)
        {
            return await repository.AllReadOnly<Room>()
                .Where(r => r.Hotel_Id == hotelId)
                .ToListAsync();
        }
        private async Task<int> GetHotelsCountAsync()
        {
            return await repository.AllReadOnly<Hotel>()
                .CountAsync();
        }
    }
}
