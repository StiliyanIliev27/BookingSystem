using BookingSystem.Core.Enumerations;
using BookingSystem.Core.Models.Landmark;
using BookingSystem.Core.Models.Location;
using BookingSystem.Core.Models.QueryModels.Admin.Landmark;
using BookingSystem.Core.Models.QueryModels.Flight;

namespace BookingSystem.Core.Contracts
{
    public interface ILandmarkService
    {
        Task<IEnumerable<LandmarkViewModel>> AllAsync(int cityId);      
       
        Task<LandmarkDetailsViewModel> DetailsAsync(int landmarkId);

        Task<LandmarkReserveInputModel> GetForReserveAsync(int landmarkId);

        Task ReserveAsync(string userId, int landmarkId, LandmarkReserveInputModel model);

        Task<IEnumerable<LandmarkReservationsViewModel>> AllReservationsAsync(string userId);

        Task CancellReservationAsync(string userId, string reservationId);

        Task<LandmarkReservationEditInputModel> GetReservationForEditAsync(string userId, string reservationId);

        Task EditReservationAsync(LandmarkReservationEditInputModel model, string userId);

        Task<LandmarkQueryViewModel> AllLandmarksForAdminAsync(
           string? city = null,
           string? searchTerm = null,
           LandmarkSorting sorting = LandmarkSorting.IdentifierAscending);

        Task<LandmarkEditInputModel> GetForEditAsync(int landmarkId);

        Task EditAsync(LandmarkEditInputModel model);

        Task DeleteAsync(int landmarkId);

        Task<LandmarkAddInputModel> GetForAddAsync();

        Task AddAsync(LandmarkAddInputModel model);

        Task<bool> ReservationExistsAsync(int landmarkId, string userId, DateTime reservationDate, DateTime reservationTime);

        Task<bool> LandmarkReservationExistsAsync(string reservationId);

        Task<bool> LandmarkExistsAsync(int landmarkId);

        IEnumerable<string> GetAvailableHours();

        Task<IEnumerable<CityFormModel>> GetAllCitiesAsync();
    }
}
