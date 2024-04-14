namespace BookingSystem.Areas.Admin.Controllers
{
    using BookingSystem.Core.Contracts;
    using Microsoft.AspNetCore.Mvc;
    public class UserController : AdminBaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;  
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await userService.AllAsync();

            return View(model);
        }
    }
}
