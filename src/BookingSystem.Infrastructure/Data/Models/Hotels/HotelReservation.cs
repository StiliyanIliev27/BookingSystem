namespace BookingSystem.Infrastructure.Data.Models.Hotels
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Hotel Reservation
    /// </summary>
    [Comment("Hotel Reservation")]
    public class HotelReservation
    {
        /// <summary>
        /// HotelReservation's Hotel's Identifier
        /// </summary>
        [Required]
        [Comment("Room's Hotel's Identifier")]
        public int Hotel_Id { get; set; }

        /// <summary>
        /// HotelReservation's Hotel
        /// </summary>
        [ForeignKey(nameof(Hotel_Id))]
        [Comment("Room's Hotel")]
        public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// HotelReservation's User's Identifier
        /// </summary>
        [Required]
        [Comment("HotelReservation's User's Identifier")]
        public string User_Id { get; set; } = null!;
       
        /// <summary>
        /// HotelReservation's User
        /// </summary>
        [ForeignKey(nameof(User_Id))]
        [Comment("HotelReservation's User")]
        public IdentityUser User { get; set; } = null!;
       
        /// <summary>
        /// HotelReservation's Total Price
        /// </summary>
        [Required]
        [Comment("HotelReservation's Total Price")]
        public decimal Price { get; set; }

        /// <summary>
        /// HotelReservation's Start Date
        /// </summary>
        [Required]
        [Comment("HotelReservation's Start Date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// HotelReservation's Start Date
        /// </summary>
        [Required]
        [Comment("HotelReservation's End Date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// HotelReservation's CreatedOn time
        /// </summary>
        [Required]
        [Comment("HotelReservation's CreatedOn Time")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// HotelReservation's Active Status
        /// </summary>
        [Required]
        [Comment("HotelReservation's Active Status")]
        public bool IsActive { get; set; }
    }
}
