using BookingSystem.Core.Contracts;

namespace BookingSystem.Core.Models.Flight
{
    public class FlightReservationVerifyViewModel : IFlightModel
    {
        public string Id { get; set; } = null!;
       
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int FlightId { get; set; }
        
        public decimal TotalPrice { get; set; } 
      
        public string Flight { get; set; } = null!;

        public int SeatNumber { get; set; }

        public string ReservationDate { get; set; } = null!;

        public string DepartureTime { get; set; } = null!;

        public string ArrivalTime {  get; set; } = null!;

        public string ArrivalCityImageUrl { get; set; } = null!;
       
        public string? AirlineLogoUrl { get; set; } = null!;
       
        public string DepartureAirport { get; set; } = null!;
     
        public string ArrivalAirport { get; set; } = null!;
    }
}
