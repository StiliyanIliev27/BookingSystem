namespace BookingSystem.Infrastructure.Data.Models.Flights
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Airline;

    /// <summary>
    /// Airline
    /// </summary>
    [Comment("Airline")]
    public class Airline
    {
        [Key]
        [Comment("Airline's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Airline's Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Airline's Name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Airline's Image URL
        /// </summary>
        [Comment("Airline's Image URL")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Airline's WebSite URL
        /// </summary>
        [Required]
        [Comment("Airline's WebSite URL")]
        public string WebSiteUrl { get; set; } = null!;
    }
}
