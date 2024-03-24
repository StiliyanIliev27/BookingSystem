namespace BookingSystem.Core.Models.QueryModels.Flight
{
    using BookingSystem.Core.Enumerations;
    using System.ComponentModel.DataAnnotations;

    public class AllFlightsQueryModel
    {
        public int FlightsPerPage { get; } = 3;

        [Display(Name = "Departure destination")]
        public string DepartureCity { get; set; } = null!;

        [Display(Name = "Arrival destination")]
        public string ArrivalCity { get; set; } = null!;
        public FlightSorting Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalFlightsCount { get; set; }
        public IEnumerable<string> Cities { get; set; } = null!;
        public IEnumerable<FlightServiceModel> Flights { get; set; } = new List<FlightServiceModel>();
    }
}
