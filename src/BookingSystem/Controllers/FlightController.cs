namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.QueryModels.Flight;
    using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Details(int id)
        {
            var model = await flightService.DetailsAsync(id);

            return View(model);
        }
    }
}
