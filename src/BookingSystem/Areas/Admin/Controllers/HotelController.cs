namespace BookingSystem.Areas.Admin.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Hotel;
    using Microsoft.AspNetCore.Mvc;
    using System.Globalization;

    public class HotelController : AdminBaseController
    {
        private readonly IHotelService hotelService;

        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await hotelService.GetForEditAsync(id);
            
            return View(model);
        }

        public async Task<IActionResult> Edit(HotelEditInputModel model)
        {
            DateTime checkIn;
            DateTime checkOut;

            if(!DateTime.TryParse(model.CheckIn, CultureInfo.InvariantCulture, DateTimeStyles.None, out checkIn))
            {
                ModelState.AddModelError(nameof(model.CheckIn), "Invalid data provided! Please, enter Check In in format \"HH:mm\"");
            }

            if (!DateTime.TryParse(model.CheckOut, CultureInfo.InvariantCulture, DateTimeStyles.None, out checkOut))
            {
                ModelState.AddModelError(nameof(model.CheckOut), "Invalid data provided! Please, enter Check In in format \"HH:mm\"");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            await hotelService.EditAsync(model);

            return RedirectToAction("All", "Hotel", new { area = "" });
        }
    }
}
