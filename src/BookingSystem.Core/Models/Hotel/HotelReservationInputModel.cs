namespace BookingSystem.Core.Models.Hotel
{
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.HotelReservation;
    using Room = Infrastructure.Data.Models.Hotels.Room;

    public class HotelReservationInputModel
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

        [Required]
        [Display(Name = "Room")]
        public int Room_Id { get; set; }

        [Required]
        public int Hotel_Id { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public string StartDate { get; set; } = null!;

        [Required]
        [Display(Name = "End Date")]
        public string EndDate { get; set; } = null!;
        
        public IEnumerable<Room>? Rooms { get; set; }
    }
}
