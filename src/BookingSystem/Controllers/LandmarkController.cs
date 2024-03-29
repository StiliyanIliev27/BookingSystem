﻿namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Landmark;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Globalization;
    using System.Security.Claims;

    public class LandmarkController : BaseController
    {
        private readonly ILandmarkService landmarkService;

        public LandmarkController(ILandmarkService landmarkService)
        {
            this.landmarkService = landmarkService;    
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All(int id)
        {
            var model = await landmarkService.AllAsync(id);

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if(await landmarkService.LandmarkExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await landmarkService.DetailsAsync(id);

            return View(model); 
        }

        [HttpGet]
        public async Task<IActionResult> Reserve(int id)
        {
            if (await landmarkService.LandmarkExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await landmarkService.GetForReserveAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Reserve(int id, LandmarkReserveInputModel model)
        {
            DateTime reservationDate = DateTime.Now;
            DateTime reservationHour = DateTime.Now;

            if (await landmarkService.LandmarkExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if(!DateTime.TryParse(model.ReservationDate, CultureInfo.CurrentCulture,
                DateTimeStyles.None, out reservationDate))
            {
                ModelState.AddModelError(nameof(model.ReservationDate), "Incorrect data provided!");
            }

            if (!DateTime.TryParse(model.ReservationTime, CultureInfo.CurrentCulture,
                DateTimeStyles.None, out reservationHour))
            {
                ModelState.AddModelError(nameof(model.ReservationTime), "Incorrect data provided!");
            }

            if(!ModelState.IsValid)
            {
                model.AvailableHours = landmarkService.GetAvailableHours();
                return View(model);
            }

            string userId = User.GetUserId();

            await landmarkService.ReserveAsync(userId, id, model);

            return RedirectToAction(nameof(MyReservations));
        }

        [HttpGet]
        public async Task<IActionResult> MyReservations()
        {
            string userId = User.GetUserId();   
            var model = await landmarkService.AllReservationsAsync(userId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CancellReservation(string id)
        {
            string userId = User.GetUserId();
            await landmarkService.CancellReservationAsync(userId, id);

            return RedirectToAction(nameof(MyReservations));
        }

        [HttpGet]
        public async Task<IActionResult> EditReservation(string id)
        {
            if(await landmarkService.LandmarkReservationExistsAsync(id) == false)
            {
                return BadRequest();
            }

            string userId = User.GetUserId();
            var model = await landmarkService.GetReservationForEditAsync(userId, id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditReservation(LandmarkEditInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = User.GetUserId();
            await landmarkService.EditReservationAsync(model, userId);

            return RedirectToAction(nameof(MyReservations));
        }
    }
}
