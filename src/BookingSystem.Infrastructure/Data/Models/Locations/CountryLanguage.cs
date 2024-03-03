namespace BookingSystem.Infrastructure.Data.Models.Location
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// CountryLanguage
    /// </summary>
    [Comment("CountryLanguage")]
    public class CountryLanguage
    {
        /// <summary>
        /// Country's Identifier
        /// </summary>
        [Required]
        [Comment("Country's Identifier")]
        public int Country_Id { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [ForeignKey(nameof(Country_Id))]
        [Comment("Country")]
        public Country Country { get; set; } = null!;

        /// <summary>
        /// Language's Identifier
        /// </summary>
        [Required]
        [Comment("Language's Identifier")]
        public int Language_Id { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [ForeignKey(nameof(Language_Id))]
        [Comment("Language")]
        public Language Language { get; set; } = null!;
    }
}
