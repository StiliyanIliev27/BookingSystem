namespace BookingSystem.Core.Models.Landmark
{
    using BookingSystem.Core.Models.Location;
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Landmark;
    public class LandmarkAddInputModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Landmark's name")]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = NameErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [Display(Name = "Landmark's ticket price")]
        [Range(TicketMinPriceValue,
            TicketMaxPriceValue,
            ErrorMessage = TicketErrorMessage)]
        public decimal TicketPrice { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Display(Name = "Landmark's address")]
        [StringLength(AddressMaxLength,
            MinimumLength = AddressMinLength,
            ErrorMessage = AddressErrorMessage)]
        public string Address { get; set; } = null!;

        [Display(Name = "Landmark's details")]
        [MaxLength(DetailsMaxLength,
            ErrorMessage = DetailsErrorMessage)]
        public string? Details { get; set; }

        [Required]
        public int CityId { get; set; }

        public IEnumerable<CityFormModel> Cities { get; set; } = new HashSet<CityFormModel>();
    }
}
