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
    public class HotelController : BaseController
    {
        private readonly IHotelService hotelService;
        
        private readonly ILandmarkService landmarkService;

        private readonly ILogger logger;
        public HotelController(IHotelService hotelService,
            ILandmarkService landmarkService,
            ILogger logger)
        {
            this.hotelService = hotelService;
            this.landmarkService = landmarkService;
            this.logger = logger;
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
            if(await hotelService.HotelExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await hotelService.DetailsAsync(id);
            model.City.Landmarks = await landmarkService.AllAsync(model.City.Id);
          
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
        public async Task<IActionResult> Verify()
        {
            string userId = User.GetUserId();
            var model = await hotelService.GetForVerifyReservationAsync(userId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Verify(string id)
        {
            if(await hotelService.HotelReservationExistsAsync(id) == false)
            {
                return BadRequest();
            }

            string userId = User.GetUserId();

            try
            {
                await hotelService.VerifyReservationAsync(id, userId);
            }
            catch(UnauthorizedAccessException uae)
            {
                logger.LogError(uae, "Hotel/Verify[POST]");

                return Unauthorized();
            }

            return RedirectToAction(nameof(AllReservations));
        }

        [HttpPost]
        public async Task<IActionResult> CancellVerification(string id)
        {
            if(await hotelService.HotelReservationExistsAsync(id) == false)
            {
                return BadRequest();
            }

            string userId = User.GetUserId();
          
            try
            {
                await hotelService.CancellVerificationAsync(id, userId);
            }
            catch(UnauthorizedAccessException uae)
            {
                logger.LogError(uae, "Hotel/CancellVerification[POST]");

                return Unauthorized();
            }

            return RedirectToAction(nameof(Verify));
        }
       
        [HttpPost]
        public async Task<IActionResult> CancellReservation(string id)
        {
            if (await hotelService.HotelReservationExistsAsync(id) == false)
            {
                return BadRequest();
            }

            string userId = User.GetUserId();

            try
            {
                await hotelService.CancellReservationAsync(id, userId);
            }
            catch(UnauthorizedAccessException uae)
            {
                logger.LogError(uae, "Hotel/CancellReservation[POST]");

                return Unauthorized();
            }

            return RedirectToAction(nameof(AllReservations));
        }

        [HttpGet]
        public async Task<IActionResult> AllReservations()
        {
            string userId = User.GetUserId();
            var model = await hotelService.AllReservationsAsync(userId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditReservation(string id)
        {
            if (await hotelService.HotelReservationExistsAsync(id) == false)
            {
                return BadRequest();
            }

            string userId = User.GetUserId();
          
            try
            {
                var model = await hotelService.GetForEditAsync(id, userId);

                return View(model);
            }
            catch(UnauthorizedAccessException uae)
            {
                logger.LogError(uae, "Hotel/EditReservation[GET]");

                return Unauthorized();
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditReservation(HotelReservationEditInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            string userId = User.GetUserId();

            try
            {
                await hotelService.EditAsync(model, userId);
            }
            catch(UnauthorizedAccessException uae)
            {
                logger.LogError(uae, "Hotel/EditReservation[POST]");

                return Unauthorized();
            }

            return RedirectToAction(nameof(AllReservations));
        }       
    }
}
