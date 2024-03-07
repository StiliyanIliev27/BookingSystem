namespace BookingSystem.Infrastructure.Data.Models.Hotels
{
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Hotel;

    /// <summary>
    /// Hotel
    /// </summary>
    [Comment("Hotel")]
    public class Hotel
    {
        /// <summary>
        /// Hotel's Identifier
        /// </summary>
        [Key]
        [Comment("Hotel's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Hotel's Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Hotel's Name")]
        public string Name { get; set; } = null!;
       
        /// <summary>
        /// Hotel's Address
        /// </summary>
        [Required]
        [MaxLength(AddressMaxLength)]
        [Comment("Hotel's Address")]
        public string Address { get; set; } = null!;

        /// <summary>
        /// Hotel's City's Identifier
        /// </summary>
        [Required]
        [Comment("Hotel's City's Identifier")]
        public int City_Id { get; set; }

        /// <summary>
        /// Hotel's City
        /// </summary>
        [ForeignKey(nameof(City_Id))]
        [Comment("Hotel's City")]
        public City City { get; set; } = null!;

        /// <summary>
        /// Hotel's Star Rate
        /// </summary>
        [Required]
        [MaxLength(StarRateMaxValue)]
        [Comment("Hotel's Star Rate")]
        public int StarRate { get; set; }

        /// <summary>
        /// Hotel's Details
        /// </summary>
        [MaxLength(DetailsMaxLength)]
        [Comment("Hotel's Details")]
        public string? Details { get; set; }

        /// <summary>
        /// Hotel's Check In
        /// </summary>
        [Required]
        [Comment("Hotel's Check In")]
        public DateTime CheckIn { get; set; }

        /// <summary>
        /// Hotel's Check Out
        /// </summary>
        [Required]
        [Comment("Hotel's Check Out")]
        public DateTime CheckOut { get; set; }

        /// <summary>
        /// Hotel's Parking Availability
        /// </summary>
        [Comment("Hotel's Parking Availability")]
        public bool? Parking { get; set; }

        /// <summary>
        /// Hotel's Pets Allowable
        /// </summary>
        [Comment("Hotel's Pets Allowable")]
        public bool? Pets { get; set; }

        /// <summary>
        /// Hotel's Active Status
        /// </summary>
        [Required]
        [Comment("Hotel's Active Status")]
        public bool IsActive { get; set; } = false;
    }
}
