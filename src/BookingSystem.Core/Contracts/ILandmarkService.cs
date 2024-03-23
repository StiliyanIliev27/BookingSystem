using BookingSystem.Core.Models.Landmark;

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

        Task<LandmarkEditInputModel> GetReservationForEditAsync(string userId, string reservationId);

        Task EditReservationAsync(LandmarkEditInputModel model, string userId);

        Task<bool> ReservationExistsAsync(int landmarkId, string userId, DateTime reservationDate, DateTime reservationTime);

        Task<bool> LandmarkReservationExistsAsync(string reservationId);

        Task<bool> LandmarkExistsAsync(int landmarkId);

        IEnumerable<string> GetAvailableHours();
    }
}
