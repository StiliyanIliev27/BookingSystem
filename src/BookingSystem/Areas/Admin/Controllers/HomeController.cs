﻿namespace BookingSystem.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    public class HomeController : AdminBaseController
    {
        public IActionResult Management()
        {
            return View();
        }
    }
}
