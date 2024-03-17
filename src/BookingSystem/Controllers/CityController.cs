using BookingSystem.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.Controllers
{
    [AllowAnonymous]
    public class CityController : Controller
    {
        private readonly ICityService cityService;

        public CityController(ICityService cityService)
        {
            this.cityService = cityService;
        }
        public async Task<IActionResult> Details(int id)
        {
            var model = await cityService.DetailsAsync(id);

            return View(model);
        }
    }
}
