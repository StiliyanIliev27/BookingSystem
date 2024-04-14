namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Models.Reservation;
    public interface IReservationService
    {
        Task<IEnumerable<HotelReservationViewModel>> AllHotelReservationsAsync();
       
        Task<IEnumerable<FlightReservationViewModel>> AllFlightReservationsAsync();

        Task<IEnumerable<LandmarkReservationViewModel>> AllLandmarkReservationsAsync();
    }
}
