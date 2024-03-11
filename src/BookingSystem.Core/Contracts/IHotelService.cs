namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Models.Hotel;
    public interface IHotelService
    {
        Task<IEnumerable<HotelAllViewModel>> AllAsync();
        Task<HotelDetailsViewModel> DetailsAsync(int hotelId);
        Task<HotelReservationInputModel> GetForReserveAsync(int hotelId);
    }
}
