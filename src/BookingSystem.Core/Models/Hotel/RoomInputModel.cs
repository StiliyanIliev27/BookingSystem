namespace BookingSystem.Core.Models.Hotel
{
    using BookingSystem.Core.Contracts;
    using System.ComponentModel.DataAnnotations;
    public class RoomInputModel : IHotelModel
    {
        public int Id { get; set; }
        
        [Required]
        public string Type { get; set; } = null!;

        [Required]
        public decimal PricePerNight { get; set; }

        [Required]
        public int Hotel_Id { get; set; }

        [Required]
        public string Wifi { get; set; } = null!;

        public IEnumerable<string> Types { get; set; } = new HashSet<string>();
        public IEnumerable<string> WifiAvailability { get; set; } = new List<string>() { "Available", "Not Available" };

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
