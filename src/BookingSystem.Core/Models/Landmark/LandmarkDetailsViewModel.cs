namespace BookingSystem.Core.Models.Landmark
{
    public class LandmarkDetailsViewModel : LandmarkViewModel
    {
        public string Address { get; set; } = null!;
        public string? Details { get; set; }
    }
}
