namespace BookingSystem.Areas.Admin.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Flight;
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

        [HttpPost]
        public async Task<IActionResult> Edit(FlightEditInputModel model)
        {
            if(!ModelState.IsValid)
            {
                model.Airlines = await flightService.GetAllAirlinesAsync();
                model.CabinClasses = flightService.GetAllCabinClasses();
                return View();
            }

            await flightService.EditAsync(model);

            return RedirectToAction(nameof(All), new { area = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await flightService.DeleteAsync(id);

            return RedirectToAction(nameof(All), new { area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = await flightService.GetForAddAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(FlightAddInputModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Airlines = await flightService.GetAllAirlinesAsync();
                model.CabinClasses = flightService.GetAllCabinClasses();
                return View();
            }

            await flightService.AddAsync(model);

            return RedirectToAction(nameof(All), new { area = "Admin" });
        }
    }
}
