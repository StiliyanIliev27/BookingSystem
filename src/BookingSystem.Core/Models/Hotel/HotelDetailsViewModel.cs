using BookingSystem.Core.Contracts;
using BookingSystem.Core.Models.Location;
using BookingSystem.Infrastructure.Data.Models.Hotels;

namespace BookingSystem.Core.Models.Hotel
{
    public class HotelDetailsViewModel : IHotelModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string CountryName { get; set; } = null!;
        public CityViewModel City { get; set; } = null!;
        public int StarRate { get; set; }
        public string? Details { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string CheckIn { get; set; } = null!;
        public string CheckOut { get; set; } = null!;
        public bool? Parking { get; set; }
        public bool? Pets { get; set; }
        public IEnumerable<Room> Rooms { get; set; } = null!;
        public int HotelsCount { get; set; }
    }
}
