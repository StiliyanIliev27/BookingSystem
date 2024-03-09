namespace BookingSystem.Controllers
{
    using BookingSystem.Core.Contracts;
    using Microsoft.AspNetCore.Mvc;
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
