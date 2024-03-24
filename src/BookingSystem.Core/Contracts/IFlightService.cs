namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Models.QueryModels.Flight;
    public interface IFlightService
    {
        Task<FlightQueryServiceModel> AllAsync(
            string? departureCity = null,
            string? arrivalCity = null,
            FlightSorting sorting = FlightSorting.Newest,
            int currentPage = 1,
            int flightsPerPage = 4);
    }
}
