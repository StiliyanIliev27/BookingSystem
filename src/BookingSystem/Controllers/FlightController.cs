namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Flight;
    using BookingSystem.Core.Models.QueryModels.Flight;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Globalization;
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
        public async Task<IActionResult> Reserve(FlightReservationInputModel model, int id)
        {
            DateTime reservationDate;

            if (!DateTime.TryParse(model.ReservationDate, CultureInfo.CurrentCulture,
                DateTimeStyles.None, out reservationDate))
            {
                ModelState.AddModelError(nameof(model.ReservationDate), "Incorrect data provided!");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = User.GetUserId();
            await flightService.ReserveAsync(model, userId, id);

            return RedirectToAction(nameof(Verify));
        }

        [HttpGet]
        public async Task<IActionResult> Verify()
        {
            string userId = User.GetUserId();
            var model = await flightService.GetReservationsForVerifyAsync(userId);

            return View(model); 
        }

        [HttpPost]
        public async Task<IActionResult> Verify(string id)
        {
            if(!await flightService.VerificationExistsByIdAsync(id))
            {
                return BadRequest();
            }
            
            string userId = User.GetUserId();
            await flightService.VerifyAsync(id, userId);

            return RedirectToAction(nameof(Verify));
        }

        [HttpPost]
        public async Task<IActionResult> CancellVerification(string id)
        {
            if(!await flightService.VerificationExistsByIdAsync(id))
            {
                return BadRequest();
            }

            string userId = User.GetUserId();
            await flightService.CancellVerificationAsync(id, userId);

            return RedirectToAction(nameof(Verify));
        }

        [HttpGet]
        public async Task<IActionResult> MyReservations()
        {
            string userId = User.GetUserId();
            var model = await flightService.MyReservations(userId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CancellReservation(string id)
        {
            if (!await flightService.ReservationExistsByIdAsync(id))
            {
                return BadRequest();
            }

            string userId = User.GetUserId();
            await flightService.CancellReservationAsync(id, userId);

            return RedirectToAction(nameof(MyReservations));
        }

        [HttpGet]
        public async Task<IActionResult> EditReservation(string id)
        {
            if(!await flightService.ReservationExistsByIdAsync(id))
            {
                return BadRequest();    
            }

            string userId = User.GetUserId();
            var model = await flightService.GetForEditAsync(id, userId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditReservation(FlightReservationEditInputModel model)
        {
            if (!await flightService.ReservationExistsByIdAsync(model.Id))
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(model); 
            }

            string userId = User.GetUserId();
            await flightService.EditAsync(model, userId);

            return RedirectToAction(nameof(MyReservations));
        }
    }
}
