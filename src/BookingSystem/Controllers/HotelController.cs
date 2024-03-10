using BookingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelService hotelService;

        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await hotelService.AllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await hotelService.DetailsAsync(id);

            return View(model);
        }
    }
}
