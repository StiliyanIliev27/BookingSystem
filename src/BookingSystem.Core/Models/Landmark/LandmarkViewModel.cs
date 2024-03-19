namespace BookingSystem.Core.Models.Landmark
{
    public class LandmarkViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CityName { get; set; } = null!;
        public decimal TicketPrice { get; set; } = 0.0m;
        public string ImageUrl { get; set; } = null!;
    }
}
