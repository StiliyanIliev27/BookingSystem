using BookingSystem.Core.Contracts;

namespace BookingSystem.Core.Models.Hotel
{
    public class HotelIndexPageModel : IHotelModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Address { get; set; } = null!;
    }
}
