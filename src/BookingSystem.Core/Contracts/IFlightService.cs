namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Models.Flight;
    using BookingSystem.Core.Models.Landmark;
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
        
        Task<bool> ExistsByIdAsync(int flightId);
    }
}
