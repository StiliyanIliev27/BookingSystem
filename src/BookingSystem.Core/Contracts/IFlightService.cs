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
    }
}
