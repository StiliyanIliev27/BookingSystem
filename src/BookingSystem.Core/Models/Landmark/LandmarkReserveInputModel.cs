namespace BookingSystem.Core.Models.Landmark
{
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.LandmarkReservation;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants;
    public class LandmarkReserveInputModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(FirstNameMaxLength,
            MinimumLength = FirstNameMinLength,
            ErrorMessage = RequiredMessage)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(LastNameMaxLength,
            MinimumLength = LastNameMinLength,
            ErrorMessage = RequiredMessage)]
        public string LastName { get; set; } = string.Empty;

        public int Landmark_Id { get; set; }

        [Required]
        [Display(Name = "Reservation Date")]
        public string ReservationDate { get; set; } = null!;

        [Required]
        [Display(Name = "Reservation Time")]
        public string ReservationTime { get; set; } = null!;

        [Required]
        [Range(MinimumPeoplePerReservation, MaximumPeoplePerReservation)]
        [Display(Name = "Group Count")]
        
        public int GroupCount { get; set; }

        public IEnumerable<string> AvailableHours { get; set; } = new HashSet<string>();
    }
}
