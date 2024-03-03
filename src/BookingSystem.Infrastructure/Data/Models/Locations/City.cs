namespace BookingSystem.Infrastructure.Data.Models.Location
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Constants.DataConstants.City;

    /// <summary>
    /// City
    /// </summary>
    [Comment("City")]
    public class City
    {
        /// <summary>
        /// City's Identifier
        /// </summary>
        [Key]
        [Comment("City's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// City's Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("City's Name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// City's Population
        /// </summary>
        [Required]
        [Comment("City's Population")]
        public uint Population { get; set; }

        /// <summary>
        /// City's Area
        /// </summary>
        [Required]
        [MaxLength(AreaMaxLength)]
        [Comment("City's Area")]
        public string Area { get; set; } = null!;

        /// <summary>
        /// City's Details
        /// </summary>
        [MaxLength(DetailsMaxLength)]
        [Comment("City's Details")]
        public string? Details { get; set; }

        /// <summary>
        /// City's Country's Identifier
        /// </summary>
        [Required]
        [Comment("City's Country's Identifier")]
        public int Country_Id { get; set; }

        /// <summary>
        /// City's Country
        /// </summary>
        [Comment("City's Country")]
        public Country Country { get; set; } = null!;
    }
}
