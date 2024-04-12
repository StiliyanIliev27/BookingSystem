﻿namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Models.Flight;
    using BookingSystem.Core.Models.QueryModels.Admin.Flight;
    using BookingSystem.Core.Models.QueryModels.Flight;
    using BookingSystem.Infrastructure.Data.Enums;

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

        Task VerifyAsync(string reservationId, string userId);

        Task CancellVerificationAsync(string reservationId, string userId);

        Task<IEnumerable<FlightReservationViewModel>> MyReservations(string userId);

        Task<FlightReservationEditInputModel> GetForEditReservationAsync(string reservationId, string userId);

        Task EditReservationAsync(FlightReservationEditInputModel model, string userId);

        Task CancellReservationAsync(string reservationId, string userId);

        Task<FlightQueryViewModel> AllFlightsForAdminAsync(
            string? departureCity = null,
            string? arrivalCity = null,
            FlightSorting sorting = FlightSorting.PriceAscending);

        Task<FlightEditInputModel> GetForEditAsync(int flightId);

        Task EditAsync(FlightEditInputModel model);
        
        Task<bool> VerificationExistsByIdAsync(string verificationId);

        Task<bool> ReservationExistsByIdAsync(string reservationId);

        Task<bool> ExistsByIdAsync(int flightId);

        IEnumerable<string> GetAllCabinClasses();

        Task<IEnumerable<AirlineViewModel>> GetAllAirlinesAsync();
    }
}
