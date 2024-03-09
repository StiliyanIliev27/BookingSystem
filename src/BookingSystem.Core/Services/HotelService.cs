namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Hotel;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using Microsoft.EntityFrameworkCore;

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
                .Select(h => new HotelAllViewModel()
                {
                    Id = h.Id,
                    Name = h.Name,
                    CityName = h.City.Name,
                    CityId = h.City.Id,
                    StarRate = h.StarRate,
                    ImageUrl = h.ImageUrl,
                    Rooms = repository.AllReadOnly<Room>().Where(r => r.Hotel_Id == h.Id).ToList()
                })
                .ToListAsync();
        }
    }
}
