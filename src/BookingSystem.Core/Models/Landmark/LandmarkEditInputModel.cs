namespace BookingSystem.Core.Models.Landmark
{
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.LandmarkReservation;
    public class LandmarkEditInputModel
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
