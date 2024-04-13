namespace BookingSystem.Areas.Admin.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.QueryModels.Admin.Landmark;
    using Microsoft.AspNetCore.Mvc;
    public class LandmarkController : AdminBaseController
    {
        private readonly ILandmarkService landmarkService;
        private readonly IHotelService hotelService;

        public LandmarkController(ILandmarkService landmarkService, IHotelService hotelService)
        {
            this.landmarkService = landmarkService;   
            this.hotelService = hotelService;
        }
        
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllLandmarksAdminQueryModel query)
        {
            var model = await landmarkService.AllLandmarksForAdminAsync(
            query.City,
            query.SearchTerm,
            query.Sorting);

            query.Landmarks = model.Landmarks;
            query.Cities = await hotelService.AllCitiesNamesAsync();

            return View(query);
        }
    }
}
