namespace BookingSystem.Core.Models.Flight
{
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Flight;
    public class FlightEditInputModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Departure time")]
        public string DepartureTime { get; set; } = null!;

        
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Arrival time")]
        public string ArrivalTime { get; set; } = null!;

        
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Cabin class")]
        public string CabinClass { get; set; } = null!;

        
        [Required(ErrorMessage = RequiredMessage)]
        public int Airline_Id { get; set; }


        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Ticket price")]
        [Range(TicketPriceMinValue, TicketPriceMaxValue, ErrorMessage = TicketPriceErrorMessage)]
        public decimal TicketPrice { get; set; }

       
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Flight duration")]
        public int FlightDuration { get; set; }

        public IEnumerable<string> CabinClasses { get; set; } = new List<string>();
        public IEnumerable<AirlineViewModel> Airlines { get; set; } = new List<AirlineViewModel>();
    }
}
