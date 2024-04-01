namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Models.Flight;
    using BookingSystem.Core.Models.QueryModels.Flight;
    public interface IFlightService
    {
        Task<FlightQueryServiceModel> AllAsync(
            string? departureCity = null,
            string? arrivalCity = null,
            FlightSorting sorting = FlightSorting.PriceAscending,
            int currentPage = 1,
            int flightsPerPage = 4);

        Task<FlightDetailsViewModel> DetailsAsync(int flightId);
       
        Task<FlightReservationInputModel> GetForReserveAsync(int flightId);

        Task ReserveAsync(FlightReservationInputModel model, string userId, int flightId);

        Task<IEnumerable<FlightReservationVerifyViewModel>> GetReservationsForVerifyAsync(string userId);

        Task VerifyAsync(string reservationId);

        Task CancellVerificationAsync(string reservationId);

        Task<IEnumerable<FlightReservationViewModel>> MyReservations(string userId);

        Task<FlightReservationEditInputModel> GetForEditAsync(string reservationId, string userId);

        Task EditAsync(FlightReservationEditInputModel model, string userId);
        
        Task<bool> VerificationExistsByIdAsync(string verificationId);

        Task<bool> ReservationExistsByIdAsync(string reservationId);

        Task<bool> ExistsByIdAsync(int flightId);
    }
}
