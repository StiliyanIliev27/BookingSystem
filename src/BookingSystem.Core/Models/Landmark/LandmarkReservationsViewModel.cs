using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Core.Models.Landmark
{
    public class LandmarkReservationsViewModel
    {
        public string ReservationDate { get; set; } = null!;

        public string ReservationTime { get; set; } = null!;

        public int GroupCount { get; set; }

        public decimal TotalPrice { get; set; }
    
        public string LandmarkImageUrl { get; set; } = null!;
     
        public string CreatedOn { get; set; } = null!;
    }
}
