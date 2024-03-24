namespace BookingSystem.Core.Models.QueryModels.Flight
{
    public class FlightQueryServiceModel
    {
        public int TotalFlightsCount { get; set; }
        public IEnumerable<FlightServiceModel> Flights { get; set; } = new List<FlightServiceModel>();
    }
}
