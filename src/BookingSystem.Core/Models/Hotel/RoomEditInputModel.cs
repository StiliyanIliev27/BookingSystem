namespace BookingSystem.Core.Models.Hotel
{
    using BookingSystem.Core.Contracts;
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Room;
    public class RoomEditInputModel : IHotelModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Price per Night")]
        [Range(MinPricePerNight, MaxPricePerNight, ErrorMessage = PriceErrorMessage)]
        public decimal PricePerNight { get; set; }

        [Required]
        public int Hotel_Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
