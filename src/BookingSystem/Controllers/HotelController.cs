using BookingSystem.Core.Contracts;
using BookingSystem.Core.Models.Hotel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Security.Claims;
using static BookingSystem.Infrastructure.Data.Constants.DataConstants.HotelReservation;
using BookingSystem.Core.Models.QueryModels.Hotel;

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
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllHotelsQueryModel query)
        {
            var model = await hotelService.AllAsync(
                query.City,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.HotelsPerPage);

            query.TotalHotelsCount = model.TotalHotelsCount;
            query.Hotels = model.Hotels;
            query.Cities = await hotelService.AllCitiesNamesAsync();

            return View(query);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var model = await hotelService.DetailsAsync(id);
                return View(model);
            }
            catch(ArgumentException)
            {
                return View("400", "Home");
            }            
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Reserve(int id)
        {
            var model = await hotelService.GetForReserveAsync(id);

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Reserve(HotelReservationInputModel model)
        {
            if (await hotelService.RoomExistsAsync(model.Room_Id) == false)
            {
                ModelState.AddModelError(nameof(model.Room_Id), "Room does not exist!");
            }

            DateTime startDate = DateTime.ParseExact(model.StartDate, DateTimeFormat, CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(model.EndDate, DateTimeFormat, CultureInfo.InvariantCulture);

            if(endDate <= startDate)
            {
                ModelState.AddModelError(nameof(model.EndDate), "End date must be at least one day after start date!");
            }

            if (!ModelState.IsValid)
            {
                var room = await hotelService.GetRoomAsync(model.Room_Id);
                model.Rooms = await hotelService.GetRoomsAsync(room.Hotel_Id); 
                return View(model);
            }

            string userId = User.GetUserId();

            await hotelService.ReserveAsync(model, userId);

            return RedirectToAction(nameof(Verify));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Verify()
        {
            string userId = User.GetUserId();
            var model = await hotelService.GetForVerifyReservationAsync(userId);

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Verify(string id)
        {
            string userId = User.GetUserId();
            await hotelService.VerifyReservationAsync(id, userId);

            return RedirectToAction(nameof(AllReservations));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CancellVerification(string id)
        {
            string userId = User.GetUserId();
            await hotelService.CancellVerificationAsync(id, userId);

            return RedirectToAction(nameof(Verify));
        }
       
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CancellReservation(string id)
        {
            string userId = User.GetUserId();
            await hotelService.CancellVerificationAsync(id, userId);

            return RedirectToAction(nameof(AllReservations));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AllReservations()
        {
            string userId = User.GetUserId();
            var model = await hotelService.AllReservationsAsync(userId);

            return View(model);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EditReservation(string id)
        {
            string userId = User.GetUserId();
            var model = await hotelService.GetForEditAsync(id, userId);

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditReservation(HotelReservationEditInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            string userId = User.GetUserId();
            await hotelService.EditAsync(model, userId);

            return RedirectToAction(nameof(AllReservations));
        }

        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}
