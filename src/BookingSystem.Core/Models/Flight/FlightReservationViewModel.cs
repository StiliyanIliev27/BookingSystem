using BookingSystem.Core.Contracts;

namespace BookingSystem.Core.Models.Flight
{
    public class FlightReservationViewModel : FlightReservationVerifyViewModel, IFlightModel
    {
        public int CityId { get; set; }
        public string CreatedOn { get; set; } = null!;
    }
}
