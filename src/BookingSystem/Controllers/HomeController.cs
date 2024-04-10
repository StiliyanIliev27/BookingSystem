namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Services;
    using BookingSystem.Infrastructure.Migrations;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHotelService _hotelService;

        public HomeController(ILogger<HomeController> logger, IHotelService hotelService)
        {
            _logger = logger;
            _hotelService = hotelService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await _hotelService.LastThreeHotelsAsync();

            return View(model);
        }
        
        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if(statusCode == 400)
            {
                return View("Error400");
            }
            else if(statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}
