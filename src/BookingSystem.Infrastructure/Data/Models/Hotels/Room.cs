namespace BookingSystem.Infrastructure.Data.Models.Hotels
{
    using BookingSystem.Infrastructure.Data.Enums;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Room
    /// </summary>
    [Comment("Room")]
    public class Room
    {
        /// <summary>
        /// Room's Identifier
        /// </summary>
        [Key]
        [Comment("Room's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Room's Type
        /// </summary>
        [Required]
        [Comment("Room's Type")]
        public RoomType Type { get; set; }

        /// <summary>
        /// Room's Hotel's Identifier
        /// </summary>
        [Required]
        [Comment("Room's Hotel's Identifier")]
        public int Hotel_Id { get; set; }

        /// <summary>
        /// Room's Hotel
        /// </summary>
        [ForeignKey(nameof(Hotel_Id))]
        [Comment("Room's Hotel")]
        public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Room's Price Per Night
        /// </summary>
        [Required]
        [Comment("Room's Price Per Night")]
        public decimal PricePerNight { get; set; }

        /// <summary>
        /// Room's Wi-Fi availability
        /// </summary>
        [Comment("Room's Wi-Fi Availability")]
        public bool? WiFi { get; set; }

        /// <summary>
        /// Room's Reservation Status
        /// </summary>
        [Required]
        [Comment("Room's Reservation Status")]
        public bool IsReserved { get; set; } = false;

        /// <summary>
        /// Room's Active Status
        /// </summary>
        [Required]
        [Comment("Room's Active Status")]
        public bool IsActive { get; set; } = false;

    }
}
