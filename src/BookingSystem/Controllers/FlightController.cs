namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Flight;
    using BookingSystem.Core.Models.QueryModels.Flight;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    public class FlightController : BaseController
    {
        private readonly IFlightService flightService;
        private readonly IHotelService hotelService;

        public FlightController(IFlightService flightService, IHotelService hotelService)
        {
            this.flightService = flightService;
            this.hotelService = hotelService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllFlightsQueryModel query)
        {
            var model = await flightService.AllAsync(
            query.DepartureCity,
            query.ArrivalCity,
            query.Sorting,
                query.CurrentPage,
            query.FlightsPerPage);

            query.TotalFlightsCount = model.TotalFlightsCount;
            query.Flights = model.Flights;
            query.Cities = await hotelService.AllCitiesNamesAsync();

            return View(query);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if(await flightService.ExistsByIdAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await flightService.DetailsAsync(id);
            ViewData["Action"] = "Details";

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Reserve(int id)
        {
            if(await flightService.ExistsByIdAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await flightService.GetForReserveAsync(id);
            
            ViewData["Action"] = "Reserve";

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Reserve(FlightReserveInputModel model, int id)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = User.GetUserId();
            await flightService.ReserveAsync(model, userId, id);

            return RedirectToAction(nameof(All));
        }
    }
}
