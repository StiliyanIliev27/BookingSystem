using BookingSystem.Core.Models.Landmark;

namespace BookingSystem.Core.Contracts
{
    public interface ILandmarkService
    {
        Task<IEnumerable<LandmarkViewModel>> AllAsync(int cityId);
        Task<bool> LandmarkExistsAsync(int landmarkId);
    }
}
