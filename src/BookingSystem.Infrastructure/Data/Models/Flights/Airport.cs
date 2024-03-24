namespace BookingSystem.Infrastructure.Data.Models.Flights
{
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Airport;

    /// <summary>
    /// Airport
    /// </summary>
    [Comment("Airport")]
    public class Airport
    {
        /// <summary>
        /// Airport's Identifier
        /// </summary>
        [Key]
        [Comment("Airport's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Airport's Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Airport's Name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Airport's ShorterName
        /// </summary>
        [Required]
        [MaxLength(ShorterNameMaxLength)]
        [Comment("Airport's ShorterName")]
        public string ShorterName { get; set; } = null!;
        /// <summary>
        /// Airport's City's Identifier
        /// </summary>
        [Required]
        [Comment("Airport's City's Identifier")]
        public int City_Id { get; set; }

        /// <summary>
        /// Airport's City
        /// </summary>
        [ForeignKey(nameof(City_Id))]
        [Comment("Airport's City")]
        public City City { get; set; } = null!;
    }
}
