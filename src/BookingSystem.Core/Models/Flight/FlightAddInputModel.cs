using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Core.Models.Flight
{
    public class FlightAddInputModel : FlightEditInputModel
    {
        [Required]
        public int DepartureAirport_Id { get; set; }

        [Required]
        public int ArrivalAirport_Id { get; set; }

        public IEnumerable<AirportViewModel> Airports { get; set; } = new HashSet<AirportViewModel>();
    }
}
