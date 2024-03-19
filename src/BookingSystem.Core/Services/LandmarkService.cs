namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Landmark;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Landmarks;
    using Microsoft.EntityFrameworkCore;

    public class LandmarkService : ILandmarkService
    {
        private readonly IRepository repository;
       
        public LandmarkService(IRepository repository)
        {
             this.repository = repository; 
        }
       
        public async Task<IEnumerable<LandmarkViewModel>> AllAsync(int cityId)
        {
            return await repository.AllReadOnly<Landmark>()
                .Where(l => l.City_Id == cityId)
                .Include(l => l.City)
                .Select(l => new LandmarkViewModel()
                {
                    Id = l.Id,
                    Name = l.Name,
                    CityName = l.City.Name,
                    ImageUrl = l.ImageUrl,
                    TicketPrice = l.TicketPrice,
                })
                .ToListAsync();
        }
      
        public async Task<bool> LandmarkExistsAsync(int landmarkId)
        {
            return await repository.AllReadOnly<Landmark>()
                .AnyAsync(l => l.Id == landmarkId);
        }
    }
}
