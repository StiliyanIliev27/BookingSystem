using BookingSystem.Core.Models.Landmark;

namespace BookingSystem.Core.Contracts
{
    public interface ILandmarkService
    {
        Task<IEnumerable<LandmarkViewModel>> AllAsync(int cityId);      
       
        Task<LandmarkDetailsViewModel> DetailsAsync(int landmarkId);
        
        Task<bool> LandmarkExistsAsync(int landmarkId);
    }
}
