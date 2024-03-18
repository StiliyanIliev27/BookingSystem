namespace BookingSystem.Core.Models.Hotel
{
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.HotelReservation;
    using static Infrastructure.Data.Constants.DataConstants;
    public class HotelReservationEditInputModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [Display(Name = "First Name")]
        [StringLength(FirstNameMaxLength,
            MinimumLength = FirstNameMinLength,
            ErrorMessage = RequiredMessage)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(LastNameMaxLength,
            MinimumLength = LastNameMinLength,
            ErrorMessage = RequiredMessage)]
        public string LastName { get; set; } = null!;
    }
}
