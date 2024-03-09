using BookingSystem.Core.Models.Location;

namespace BookingSystem.Core.Contracts
{
    public interface ICityService
    {
        Task<CityDetailsViewlModel> DetailsAsync(int cityId);
    }
}
