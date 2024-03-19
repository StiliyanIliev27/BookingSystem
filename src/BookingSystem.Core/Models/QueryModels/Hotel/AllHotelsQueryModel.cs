using BookingSystem.Core.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Core.Models.QueryModels.Hotel
{
    public class AllHotelsQueryModel
    {
        public int HotelsPerPage { get; } = 6;
        public string City { get; set; } = null!;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = null!;
        public HotelSorting Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalHotelsCount { get; set; }
        public IEnumerable<string> Cities { get; set; } = null!;
        public IEnumerable<HotelServiceModel> Hotels { get; set; } = new List<HotelServiceModel>();
    }
}
