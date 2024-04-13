namespace BookingSystem.Core.Models.QueryModels.Admin.Landmark
{
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Models.Landmark;
    using BookingSystem.Core.Models.Location;
    using System.ComponentModel.DataAnnotations;

    public class AllLandmarksAdminQueryModel
    {
        public string City { get; set; } = null!;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = null!;
        public LandmarkSorting Sorting { get; set; }
        public IEnumerable<string> Cities { get; set; } = null!;
        public IEnumerable<LandmarkViewModel> Landmarks { get; set; } = new List<LandmarkViewModel>();
    }
}
