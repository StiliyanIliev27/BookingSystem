namespace BookingSystem.Infrastructure.Data.Models.Landmarks
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using BookingSystem.Core.Models.User;

    /// <summary>
    /// Landmark Reservation
    /// </summary>
    [Comment("Landmark Reservation")]
    public class LandmarkReservation
    {
        public LandmarkReservation()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Landmark Reservation Identifier
        /// </summary>
        [Key]
        [Comment("Landmark Reservation Identifier")]
        public string Id { get; set; }

        /// <summary>
        /// Landmark Reservation's Reserver's First name
        /// </summary>
        [Required]
        [Comment("Landmark Reservation's Reserver's First name")]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Landmark Reservation's Reserver's Last name
        /// </summary>
        [Required]
        [Comment("Landmark Reservation's Reserver's Last name")]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Landmark's Identifier
        /// </summary>
        [Required]
        [Comment("Landmark's Identifier")]
        public int Landmark_Id { get; set; }

        /// <summary>
        /// Landmark
        /// </summary>
        [ForeignKey(nameof(Landmark_Id))]
        [Comment("Landmark")]
        public Landmark Landmark { get; set; } = null!;

        /// <summary>
        /// LandmarkReservation's User's Identifier
        /// </summary>
        [Required]
        [Comment("LandmarkReservation's User's Identifier")]
        public string User_Id { get; set; } = null!;

        /// <summary>
        /// LandmarkReservation's User
        /// </summary>
        [ForeignKey(nameof(User_Id))]
        [Comment("LandmarkReservation's User")]
        public ApplicationUser User { get; set; } = null!;

        /// <summary>
        /// LandmarkReservation's Date
        /// </summary>
        [Required]
        [Comment("LandmarkReservation's Date")]
        public DateTime ReservationDate { get; set; }
       
        /// <summary>
        /// LandmarkReservation's Time
        /// </summary>
        [Required]
        [Comment("LandmarkReservation's Time")]
        public DateTime ReservationTime { get; set; }

        /// <summary>
        /// LandmarkReservation's Group count
        /// </summary>
        [Required]
        [Comment("LandmarkReservation's Group Count")]
        public int GroupCount { get; set; }

        /// <summary>
        /// LandmarkReservation's Total Price
        /// </summary>
        [Required]
        [Comment("LandmarkReservation's Total Price")]
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// LandmarkReservation's CreatedOn time
        /// </summary>
        [Required]
        [Comment("LandmarkReservation's CreatedOn Time")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// LandmarkReservation's Active Status
        /// </summary>
        [Required]
        [Comment("LandmarkReservation's Active Status")]
        public bool IsActive { get; set; }
    }
}
