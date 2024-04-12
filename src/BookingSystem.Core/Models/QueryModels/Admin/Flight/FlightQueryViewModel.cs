namespace BookingSystem.Core.Models.QueryModels.Admin.Flight
{
    public class FlightQueryViewModel
    {
        public IEnumerable<FlightViewModel> Flights { get; set; } = new List<FlightViewModel>();
    }
}
