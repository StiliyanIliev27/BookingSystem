namespace BookingSystem.Core.Models.QueryModels.Admin.Flight
{
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Models.QueryModels.Flight;
    using System.ComponentModel.DataAnnotations;
    public class AllFlightsAdminQueryModel
    {
        [Display(Name = "Departure destination")]
        public string DepartureCity { get; set; } = null!;

        [Display(Name = "Arrival destination")]
        public string ArrivalCity { get; set; } = null!;
        public FlightSorting Sorting { get; set; }
        public IEnumerable<string> Cities { get; set; } = null!;
        public IEnumerable<FlightViewModel> Flights { get; set; } = new List<FlightViewModel>();
    }
}

