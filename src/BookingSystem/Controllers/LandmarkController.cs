namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using Microsoft.AspNetCore.Mvc;
    public class LandmarkController : BaseController
    {
        private readonly ILandmarkService landmarkService;

        public LandmarkController(ILandmarkService landmarkService)
        {
            this.landmarkService = landmarkService;    
        }

        public async Task<IActionResult> All(int id)
        {
            var model = await landmarkService.AllAsync(id);

            return View(model);
        }
    }
}
