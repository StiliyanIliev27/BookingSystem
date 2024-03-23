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
        public HotelReservation()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Hotel Reservation Identifier
        /// </summary>
        [Key]
        [Comment("Hotel Reservation Identifier")]
        public string Id { get; set; }
        
        /// <summary>
        /// HotelReservation's Reserver's First Name
        /// </summary>
        [Required]
        [Comment("Hotel Reservation's Reserver's First Name")]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// HotelReservation's Reserver's Last Name
        /// </summary>
        [Required]
        [Comment("Hotel Reservation's Reserver's Last Name")]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// HotelReservation's Room Identifier
        /// </summary>
        [Required]
        [Comment("HotelReservation's Room Identifier")]
        public int Room_Id { get; set; }

        /// <summary>
        /// HotelReservation's Room"
        /// </summary>
        [ForeignKey(nameof(Room_Id))]
        [Comment("Hotel Reservation's Room")]
        public Room Room { get; set; } = null!;

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
