namespace BookingSystem.Core.Models.QueryModels.Admin.Landmark
{
    using BookingSystem.Core.Models.Landmark;
    public class LandmarkQueryViewModel
    {
        public IEnumerable<LandmarkViewModel> Landmarks { get; set; } = new List<LandmarkViewModel>();
    }
}
