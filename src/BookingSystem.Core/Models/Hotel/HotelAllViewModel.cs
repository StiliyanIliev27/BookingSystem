using BookingSystem.Infrastructure.Data.Models.Hotels;

namespace BookingSystem.Core.Models.Hotel
{
    public class HotelAllViewModel
    { 
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CityName { get; set; } = null!;
        public int CityId { get; set; }
        public int StarRate { get; set; }
        public string ImageUrl { get; set; } = null!;
        public IEnumerable<Room> Rooms { get; set; } = null!;
    }
}
