namespace BookingSystem.Areas.Admin.Controllers
{
    using BookingSystem.Core.Contracts;
    using Microsoft.AspNetCore.Mvc;
    public class ReservationController : AdminBaseController
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet]
        public async Task<IActionResult> HotelReservations()
        {
            var model = await reservationService.AllHotelReservationsAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> FlightReservations()
        {
            var model = await reservationService.AllFlightReservationsAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> LandmarkReservations()
        {
            var model = await reservationService.AllLandmarkReservationsAsync();

            return View(model);
        }
    }
}
