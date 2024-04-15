﻿namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Models.Hotel;
    using BookingSystem.Core.Models.Location;
    using BookingSystem.Core.Models.QueryModels.Hotel;
    using BookingSystem.Infrastructure.Data.Models.Hotels;

    public interface IHotelService
    {
        Task<IEnumerable<HotelIndexPageModel>> LastThreeHotelsAsync();

        Task<HotelQueryServiceModel> AllAsync(
            string? city = null,
            string? searchTerm = null,
            HotelSorting sorting = HotelSorting.Newest,
            int currentPage = 1,
            int hotelsPerPage = 4);

        Task<IEnumerable<string>> AllCitiesNamesAsync();

        //Task<IEnumerable<HotelAllViewModel>> AllAsync();
       
        Task<HotelDetailsViewModel> DetailsAsync(int hotelId);
       
        Task<HotelReservationInputModel> GetForReserveAsync(int hotelId);
       
        Task<string> ReserveAsync(HotelReservationInputModel model, string userId);
      
        Task<IEnumerable<HotelReservationVerifyViewModel>> GetForVerifyReservationAsync(string userId);
        
        Task VerifyReservationAsync(string reservationId, string userId);
      
        Task CancellVerificationAsync(string reservationId, string userId);
      
        Task<IEnumerable<HotelReservationViewModel>> AllReservationsAsync(string userId);
      
        Task<HotelReservationEditInputModel> GetForEditReservationAsync(string reservationId, string userId);
        
        Task EditReservationAsync(HotelReservationEditInputModel model, string userId);

        Task CancellReservationAsync(string reservationId, string userId);

        Task<HotelEditAddInputModel> GetForEditAsync(int hotelId);

        Task EditAsync(HotelEditAddInputModel model);
        
        Task<HotelEditAddInputModel> GetForAddAsync();
        
        Task AddAsync(HotelEditAddInputModel model);

        Task DeleteAsync(int hotelId);

        Task<RoomInputModel> GetForAddRoomAsync(int hotelId);

        Task AddRoomAsync(RoomInputModel model);

        Task<RoomEditInputModel> GetForEditRoomAsync(int roomId);

        Task EditRoomAsync(RoomEditInputModel model);

        Task DeleteRoomAsync(int roomId);
       
        Task<bool> HotelExistsAsync(int hotelId);  

        Task<bool> HotelReservationExistsAsync(string reservationId);
       
        Task<bool> RoomExistsAsync(int roomId);
        
        Task<Room> GetRoomAsync(int roomId);
       
        Task<IEnumerable<Room>> GetRoomsAsync(int hotelId);
        
        Task<int> GetHotelsCountAsync();

        Task<int> GetNextActiveHotelIdAsync(int currentHotelId);
       
        Task<int> GetPreviousActiveHotelIdAsync(int currentHotelId);
       
        Task<int> GetFirstActiveHotelIdAsync();
       
        Task<int> GetLastActiveHotelIdAsync();

        Task<bool> HotelVerificationExistsAsync(string verificationId);
        
        Task<IEnumerable<CityFormModel>> GetAllCitiesAsync();

        IEnumerable<string> GetAllRoomTypes();

        Task<IEnumerable<string>> GetAllValidRoomTypesAsync(int hotelId);
    }
}
