namespace BookingSystem.Core.Models.Flight
{
    public class FlightReservationVerifyViewModel
    {
        public string Id { get; set; } = null!;
       
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int FlightId { get; set; }
        
        public decimal TotalPrice { get; set; } 
      
        public string Flight { get; set; } = null!;

        public int SeatNumber { get; set; }

        public string ReservationDate { get; set; } = null!;

        public string ArrivalCityImageUrl { get; set; } = null!;
       
        public string? AirlineLogoUrl { get; set; } = null!;
    }
}
