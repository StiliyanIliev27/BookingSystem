namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class CountryController : BaseController
    {
        private readonly ICountryService countryService;
        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model = await countryService.DetailsAsync(id);
            
            return View(model);
        }
    }
}
