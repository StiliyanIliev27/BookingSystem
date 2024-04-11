namespace BookingSystem.Areas.Admin.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Extensions;
    using BookingSystem.Core.Models.Hotel;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        [HttpPost]
        public async Task<IActionResult> Edit(HotelEditAddInputModel model)
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
                model.Cities = await hotelService.GetAllCitiesAsync();
                return View(model);
            }
            
            await hotelService.EditAsync(model);

            return RedirectToAction("All", "Hotel", new { area = "" });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await hotelService.DeleteAsync(id);

            return RedirectToAction("All", "Hotel", new { area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = await hotelService.GetForAddAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(HotelEditAddInputModel model)
        {
            DateTime checkIn;
            DateTime checkOut;

            if (!DateTime.TryParse(model.CheckIn, CultureInfo.InvariantCulture, DateTimeStyles.None, out checkIn))
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

            await hotelService.AddAsync(model);

            return RedirectToAction("All", "Hotel", new { area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> AddRoom(int id)
        {
            var model = await hotelService.GetForAddRoomAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddRoom(RoomInputModel model)
        {
            if(!ModelState.IsValid)
            {
                model.Types = await hotelService.GetAllValidRoomTypesAsync(model.Id);
                return View();
            }          

            await hotelService.AddRoomAsync(model);

            return RedirectToAction("Details", "Hotel", new { area = " ", id = model.Id, information = model.GetInformation()});
        }
    }
}
