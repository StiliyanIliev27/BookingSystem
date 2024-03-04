namespace BookingSystem.Infrastructure.Data.Models.Flights
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   
    /// <summary>
    /// FlightReservations
    /// </summary>
    [Comment("FlightReservations")]
    public class FlightReservation
    {
        /// <summary>
        /// User's Identifier
        /// </summary>
        [Required]
        [Comment("User's Identifier")]
        public string User_Id { get; set; } = null!;

        /// <summary>
        /// User
        /// </summary>
        [ForeignKey(nameof(User_Id))]
        [Comment("User")]
        public IdentityUser User { get; set; } = null!;

        /// <summary>
        /// Flight's Identifier
        /// </summary>
        [Required]
        [Comment("Flight's Identifier")]
        public int Flight_Id { get; set; }

        /// <summary>
        /// Flight
        /// </summary>
        [ForeignKey(nameof(Flight_Id))]
        [Comment("Flight")]
        public Flight Flight { get; set; } = null!;

        /// <summary>
        /// Flight's Reseravation's Seat Number
        /// </summary>
        [Required]
        [Comment("Flight's Reseravation's Seat Number")]
        public int SeatNumber { get; set; }

        /// <summary>
        /// Flight's Reservation Creation Time
        /// </summary>
        [Required]
        [Comment("Flight's Reservation Creation Time")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Flight's Reservation Active Status
        /// </summary>
        [Required]
        [Comment("Flight's Reservation Active Status")]
        public bool IsActive { get; set; }
    }
}
