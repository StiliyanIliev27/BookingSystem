namespace BookingSystem.Core.Models.Landmark
{
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.LandmarkReservation;
    public class LandmarkReserveInputModel
    {
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
        
        public IEnumerable<string> AvailableHours { get; set; } = null!;
    }
}
