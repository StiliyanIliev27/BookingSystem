namespace BookingSystem.Infrastructure.Data.Models.Location
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Continent;

    /// <summary>
    /// Continent
    /// </summary>
    [Comment("Continent")]
    public class Continent
    {
        /// <summary>
        /// Continent's Identifier
        /// </summary>
        [Key]
        [Comment("Continent's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Continent's Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Continent's Name")]
        public string Name { get; set; } = null!;
    }
}
