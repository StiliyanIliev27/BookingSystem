using BookingSystem.Core.Contracts;

namespace BookingSystem.Core.Models.Hotel
{
    public class HotelReservationViewModel : IHotelModel
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string RoomType { get; set; } = null!;
        public int Hotel_Id { get; set; }  
        public string Name { get; set; } = null!;
        public string HotelImageUrl { get; set; } = null!; 
        public decimal Price { get; set; }
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public string CreatedOn { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}
