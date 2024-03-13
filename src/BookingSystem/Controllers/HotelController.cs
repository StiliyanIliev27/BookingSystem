using BookingSystem.Core.Contracts;
using BookingSystem.Core.Models.Hotel;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookingSystem.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelService hotelService;

        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await hotelService.AllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await hotelService.DetailsAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Reserve(int id)
        {
            var model = await hotelService.GetForReserveAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Reserve(HotelReservationInputModel model)
        {
            if (await hotelService.RoomExistsAsync(model.Room_Id) == false)
            {
                ModelState.AddModelError(nameof(model.Room_Id), "Room does not exist!");
            }

            if (!ModelState.IsValid)
            {
                model.Rooms = await hotelService.GetRoomsAsync(model.Hotel_Id); 
                return View(model);
            }

            string userId = User.GetUserId();

            await hotelService.ReserveAsync(model, userId);

            return RedirectToAction(nameof(Verify));
        }

        [HttpGet]
        public async Task<IActionResult> Verify()
        {
            var model = await hotelService.GetForVerifyReservationAsync(User.GetUserId());

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Verify(string id)
        {
            await hotelService.VerifyReservationAsync(id);

            return RedirectToAction(nameof(All));
        }
    }
}
