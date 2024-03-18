

namespace BookingSystem.Core.Models.QueryModels.Hotel
{
    public class HotelQueryServiceModel
    {
        public int TotalHotelsCount { get; set; }
        public IEnumerable<HotelServiceModel> Hotels { get; set; }  = new List<HotelServiceModel>();    
    }
}
