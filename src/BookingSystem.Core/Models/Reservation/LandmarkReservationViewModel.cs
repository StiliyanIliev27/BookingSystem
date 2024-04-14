namespace BookingSystem.Core.Models.Reservation
{
    using BookingSystem.Core.Contracts;
    using Microsoft.EntityFrameworkCore;
    public class LandmarkReservationViewModel : ILandmarkModel
    {
        public string ReserverFullName { get; set; } = null!;

        public int Landmark_Id { get; set; }

        /// <summary>
        /// Landmark's Name
        /// </summary>
        [Comment("Landmark's Name")]
        public string Name { get; set; } = null!;
        
        /// <summary>
        /// Landmark's City
        /// </summary>
        [Comment("Landmark's City")]
        public string City { get; set; } = string.Empty!;

        public string LandmarkImageUrl { get; set; } = null!;

        public string UserEmail { get; set; } = null!;
      
        public string UserFullName { get; set; } = null!;
       
        public string ReservationDateTime { get; set; } = null!;

        public int GroupCount { get; set; }

        public decimal TotalPrice { get; set; }

        public string CreatedOn { get; set; } = null!;

        public string IsActive { get; set; } = null!;
    }
}
