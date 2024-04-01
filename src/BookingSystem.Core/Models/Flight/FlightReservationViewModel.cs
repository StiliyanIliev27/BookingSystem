namespace BookingSystem.Core.Models.Flight
{
    public class FlightReservationViewModel : FlightReservationVerifyViewModel
    {
        public int CityId { get; set; }
        public string CreatedOn { get; set; } = null!;
    }
}
