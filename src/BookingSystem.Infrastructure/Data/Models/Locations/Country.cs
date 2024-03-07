namespace BookingSystem.Infrastructure.Data.Models.Location
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Country;

    /// <summary>
    /// Country
    /// </summary>
    [Comment("Country")]
    public class Country
    {
        /// <summary>
        /// Country's Identifier
        /// </summary>
        [Key]
        [Comment("Country's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Country's Name
        /// </summary>      
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Country's Name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Country's Capital
        /// </summary>
        [Required]
        [MaxLength(CapitalMaxLength)]
        [Comment("Country's Capital")]
        public string Capital { get; set; } = null!;

        /// <summary>
        /// Country's Population
        /// </summary>
        [Required]
        [Comment("Country's Population")]
        public long Population { get; set; }

        /// <summary>
        /// Country's Continent's Identifier
        /// </summary>
        [Required]
        [Comment("Country's Continent's Identifier")]          
        public int Continent_Id { get; set; }

        /// <summary>
        /// Contry's Continent
        /// </summary>
        [ForeignKey(nameof(Continent_Id))]
        [Comment("Contry's Continent")]
        public Continent Continent { get; set; } = null!;

        /// <summary>
        /// Contry's Details
        /// </summary>
        [Required]
        [MaxLength(DetailsMaxLength)]
        [Comment("Contry's Details")]
        public string Details { get; set; } = null!;

        /// <summary>
        /// Country's Currency Code
        /// </summary>
        [Required]
        [Comment("Country's Currency Code")]
        public string CurrencyCode { get; set; } = null!;

        /// <summary>
        /// Country's Image Url
        /// </summary>
        [Required]
        [Comment("Country's Image Url")]
        public string FlagImageUrl { get; set; } = null!;

        /// <summary>
        /// Country's Official Language Identifier
        /// </summary>
        [Required]
        [Comment("Country's Official Language Identifier")]
        public int Language_Id { get; set; }

        /// <summary>
        /// Country's Official Language
        /// </summary>
        [ForeignKey(nameof(Language_Id))]
        [Comment("Country's Official Language")]
        public Language Language { get; set; } = null!;
    }
}
