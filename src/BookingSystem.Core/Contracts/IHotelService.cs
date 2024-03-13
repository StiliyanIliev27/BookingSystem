namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Models.Hotel;
    using BookingSystem.Infrastructure.Data.Models.Hotels;

    public interface IHotelService
    {
        Task<IEnumerable<HotelAllViewModel>> AllAsync();
        Task<HotelDetailsViewModel> DetailsAsync(int hotelId);
        Task<HotelReservationInputModel> GetForReserveAsync(int hotelId);
        Task ReserveAsync(HotelReservationInputModel model, string userId);
        Task<IEnumerable<HotelReservationVerifyViewModel>> GetForVerifyReservationAsync(string userId);
        Task VerifyReservationAsync(string reservationId);
        Task<bool> RoomExistsAsync(int roomId);
        Task<IEnumerable<Room>> GetRoomsAsync(int hotelId);
        Task<int> GetHotelsCountAsync();
    }
}
