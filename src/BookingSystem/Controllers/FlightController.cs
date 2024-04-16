namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Exceptions;
    using BookingSystem.Core.Extensions;
    using BookingSystem.Core.Models.Flight;
    using BookingSystem.Core.Models.QueryModels.Flight;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Globalization;
    using System.Security.Claims;
    using static BookingSystem.Core.Constants.GeneralApplicationConstants;
    public class FlightController : BaseController
    {
        private readonly IFlightService flightService;     
        private readonly IHotelService hotelService;   
        private readonly ILogger<FlightController> logger;

        public FlightController(IFlightService flightService, 
            IHotelService hotelService,
            ILogger<FlightController> logger)
        {
            this.flightService = flightService;
            this.hotelService = hotelService;
            this.logger = logger;
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
        public async Task<IActionResult> Details(int id, string information)
        {
            if(await flightService.ExistsByIdAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await flightService.DetailsAsync(id);
            ViewData["Action"] = "Details";

            if(information != model.GetInformation())
            {
                return NotFound();
            }

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

            if(!ModelState.IsValid)
            {
                model.DetailsViewModel = await flightService.DetailsAsync(id);
                model.Flight_Id = id;
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

            try
            {
                await flightService.VerifyAsync(id, userId);
            }
            catch(UnauthorizedActionException uae)
            {
                logger.LogError(uae, "Flight/Verify[POST]");

                return Unauthorized();
            }

            TempData[UserMessageSuccess] = "You have verified your reservation successfully!";

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

            try
            {
                await flightService.CancellVerificationAsync(id, userId);
            }
            catch(UnauthorizedActionException uae)
            {
                logger.LogError(uae, "Flight/CancellVerification[POST]");

                return Unauthorized();
            }

            return RedirectToAction(nameof(Verify));
        }

        [HttpGet]
        public async Task<IActionResult> MyReservations()
        {
            string userId = User.GetUserId();
            var model = await flightService.MyReservationsAsync(userId);

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
            
            try
            {
                await flightService.CancellReservationAsync(id, userId);
            }
            catch(UnauthorizedActionException uae)
            {
                logger.LogError(uae, "Flight/CancellReservation[POST]");

                return Unauthorized();
            }

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

            try
            {
                var model = await flightService.GetForEditReservationAsync(id, userId);
               
                return View(model);
            }
            catch(UnauthorizedActionException uae)
            {
                logger.LogError(uae, "Flight/EditReservatio[GET]");

                return Unauthorized();
            }
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

            try
            {
                await flightService.EditReservationAsync(model, userId);
            }
            catch(UnauthorizedActionException uae)
            {
                logger.LogError(uae, "Flight/EditReservatio[POST]");

                return Unauthorized();
            }

            return RedirectToAction(nameof(MyReservations));
        }
    }
}
