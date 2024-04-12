namespace BookingSystem.Areas.Admin.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.QueryModels.Admin.Flight;
    using Microsoft.AspNetCore.Mvc;

    public class FlightController : AdminBaseController
    {
        private readonly IFlightService flightService;
        private readonly IHotelService hotelService;

        public FlightController(IFlightService flightService, IHotelService hotelService)
        {
            this.flightService = flightService;
            this.hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllFlightsAdminQueryModel query)
        {
            var model = await flightService.AllFlightsForAdminAsync(
            query.DepartureCity,
            query.ArrivalCity,
            query.Sorting);

            query.Flights = model.Flights;
            query.Cities = await hotelService.AllCitiesNamesAsync();

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await flightService.GetForEditAsync(id);

            return View(model);
        }
    }
}
