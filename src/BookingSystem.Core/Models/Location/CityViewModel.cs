namespace BookingSystem.Core.Models.Location
{
    using BookingSystem.Core.Models.Landmark;
    public class CityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public IEnumerable<LandmarkViewModel> Landmarks { get; set; } = new HashSet<LandmarkViewModel>();
    }
}
