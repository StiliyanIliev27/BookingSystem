namespace BookingSystem.Infrastructure.Data.Models.Location
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Language;

    /// <summary>
    /// Language
    /// </summary>
    [Comment("Language")]
    public class Language
    {
        [Key]
        [Comment(comment: "Language's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Continent's Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Language's Name")]
        public string Name { get; set; } = null!;
    }
}
