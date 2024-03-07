namespace BookingSystem.Infrastructure.Data.Models.Landmarks
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
  
    /// <summary>
    /// Landmark Reservation
    /// </summary>
    [Comment("Landmark Reservation")]
    public class LandmarkReservation
    {
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
        public IdentityUser User { get; set; } = null!;

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
