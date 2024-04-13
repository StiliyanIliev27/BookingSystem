namespace BookingSystem.Areas.Admin.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Landmark;
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await landmarkService.GetForEditAsync(id);

            return View(model); 
        }

        [HttpPost]
        public async Task<IActionResult> Edit(LandmarkEditInputModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            await landmarkService.EditAsync(model);

            return RedirectToAction(nameof(All), new { area = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await landmarkService.DeleteAsync(id);

            return RedirectToAction(nameof(All), new { area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = await landmarkService.GetForAddAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(LandmarkAddInputModel model)
        {
            if(!ModelState.IsValid)
            {
                model.Cities = await landmarkService.GetAllCitiesAsync();
                return View(model);
            }

            await landmarkService.AddAsync(model);
            
            return RedirectToAction(nameof(All), new { area = "Admin" });
        }
    }
}
