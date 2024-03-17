namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [AllowAnonymous]
    public class CountryController : Controller
    {
        private readonly ICountryService countryService;
        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        public async Task<IActionResult> Details(int id)
        {
            var model = await countryService.DetailsAsync(id);
            
            return View(model);
        }
    }
}
