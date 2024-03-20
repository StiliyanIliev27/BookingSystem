namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class LandmarkController : BaseController
    {
        private readonly ILandmarkService landmarkService;

        public LandmarkController(ILandmarkService landmarkService)
        {
            this.landmarkService = landmarkService;    
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All(int id)
        {
            var model = await landmarkService.AllAsync(id);

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if(await landmarkService.LandmarkExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await landmarkService.DetailsAsync(id);

            return View(model); 
        }
    }
}
