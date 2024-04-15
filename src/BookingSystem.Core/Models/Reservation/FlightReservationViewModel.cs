namespace BookingSystem.Core.Models.Reservation
{
    using BookingSystem.Core.Contracts;
    public class FlightReservationViewModel : IFlightModel
    {
        public string ReserverFullName { get; set; } = null!;

        public string UserFullName { get; set; } = null!; 
   
        public string UserEmail { get; set; } = null!;

        public int Flight_Id { get; set; }

        public string Flight { get; set; } = null!;

        public string Airline { get; set; } = null!;

        public string? AirlineImageUrl { get; set; } = null!; 
        
        public int SeatNumber { get; set; }

        public decimal TotalPrice { get; set; }

        public string ReservationDate { get; set; } = null!;

        public string CreatedOn { get; set; } = null!;

        public string IsActive { get; set; } = null!;
       
        public string DepartureAirport { get; set; } = null!;
       
        public string ArrivalAirport { get; set; } = null!;

        public DateTime CreatedOnDateFormat { get ; set; }
    }
}
