namespace BookingSystem.Infrastructure.Data.Models.Landmarks
{
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static BookingSystem.Infrastructure.Constants.DataConstants.Landmark;

    /// <summary>
    /// Landmark
    /// </summary>
    [Comment("Landmark")]
    public class Landmark
    {
        /// <summary>
        /// Landmark's Identifier
        /// </summary>
        [Key]
        [Comment("Landmark's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Landmark's Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Landmark's Name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Landmark's Address
        /// </summary>
        [Required]
        [MaxLength(AddressMaxLength)]
        [Comment("Landmark's Address")]
        public string Address { get; set; } = null!;

        /// <summary>
        /// Landmark's Details
        /// </summary>
        [MaxLength(DetailsMaxLength)]
        [Comment("Landmark's Details")]
        public string? Details { get; set; }

        /// <summary>
        /// Landmark's City's Identifier
        /// </summary>
        [Required]
        [Comment("Landmark's City's Identifier")]
        public int City_Id { get; set; }

        /// <summary>
        /// Landmark's City
        /// </summary>
        [ForeignKey(nameof(City_Id))]
        [Comment("Landmark's City")]
        public City City { get; set; } = null!;

        /// <summary>
        /// Landmark's Ticket Price
        /// </summary>
        [Required]
        [Comment("Landmark's Ticket Price")]
        public decimal TicketPrice { get; set; } = 0.0m;

        /// <summary>
        /// Landmark's active status
        /// </summary>
        [Required]
        [Comment("Landmark's active status")]
        public bool IsActive { get; set; } = false;
    }
}
