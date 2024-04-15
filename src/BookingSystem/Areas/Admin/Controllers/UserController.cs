namespace BookingSystem.Areas.Admin.Controllers
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.User;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;
    using System.Collections.Generic;
    using static BookingSystem.Core.Constants.GeneralApplicationConstants;

    public class UserController : AdminBaseController
    {
        private readonly IUserService userService;
        private readonly IMemoryCache memoryCache;

        public UserController(IUserService userService, IMemoryCache memoryCache)
        {
            this.userService = userService;  
            this.memoryCache = memoryCache;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<UserViewModel> users = memoryCache.Get<IEnumerable<UserViewModel>>(UsersCacheKey);

            if(users == null || !users.Any())
            {
                users = await userService.AllAsync();

                MemoryCacheEntryOptions cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(UsersCacheDurationMinutes));

                memoryCache.Set(UsersCacheKey, users, cacheOptions);
            }

            return View(users);
        }
    }
}
