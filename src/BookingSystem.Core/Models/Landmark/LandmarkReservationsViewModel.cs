namespace BookingSystem.Core.Models.Landmark
{
    public class LandmarkReservationsViewModel
    {
        public string Id { get; set; } = null!;
        
        public int Landmark_Id { get; set; }
      
        public string Name { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string ReservationDate { get; set; } = null!;

        public string ReservationTime { get; set; } = null!;

        public int GroupCount { get; set; }

        public decimal TotalPrice { get; set; }
    
        public string LandmarkImageUrl { get; set; } = null!;
     
        public string CreatedOn { get; set; } = null!;
    }
}
