namespace BookingSystem.Core.Models.Flight
{
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.FlightReservation;
    public class FlightReservationInputModel
    {
        [StringLength(FirstNameMaxLength,
            MinimumLength = FirstNameMinLength,
            ErrorMessage = LengthErrorMessage)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = RequiredMessage)]
        public string FirstName { get; set; } = null!;

        [StringLength(LastNameMaxLength, 
            MinimumLength = LastNameMinLength,
            ErrorMessage = LengthErrorMessage)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = RequiredMessage)]
        public string LastName { get; set; } = null!;

        [Display(Name = "Reservation Date")]
        [Required]
        public string ReservationDate { get; set; } = null!;

        [Required]
        public int Flight_Id { get; set; } 
        
        public FlightDetailsViewModel? DetailsViewModel { get; set; }
    }
}
