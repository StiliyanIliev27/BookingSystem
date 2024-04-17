namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Location;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;

    public class CountryService : ICountryService
    {
        private readonly IRepository repository;
        public CountryService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<CountryDetailsViewModel> DetailsAsync(int countryId)
        {
            var country = await repository.AllReadOnly<Country>()
                .Include(c => c.Continent)
                .Include(c => c.Language)
                .Where(c => c.Id == countryId)
                .FirstOrDefaultAsync();

            if(country == null)
            {
                throw new ArgumentException("Country was not found!");
            }

            string populationStr = GetPopulationString(country);
            
            return new CountryDetailsViewModel()
            {
                Id = country.Id,
                Name = country.Name,
                Capital = country.Capital,
                Population = populationStr,
                ContinentName = country.Continent.Name,
                Details = country.Details,
                CurrencyCode = country.CurrencyCode,
                FlagImageUrl = country.FlagImageUrl,
                Language = country.Language.Name
            };
        }

        private string GetPopulationString(Country country)
        {
            string populationStr = country.Population.ToString();
            string temp = string.Empty;

            if (populationStr.Count() == 7)//Milions 1 to 9
            {
                temp = populationStr.Substring(0, 3);

                populationStr = $"{temp[0]},{temp[1]}{temp[2]} milions";
            }
            else if (populationStr.Count() == 8)//Milions 10 to 100 
            {
                temp = populationStr.Substring(0, 4);

                populationStr = $"{temp[0]}{temp[1]},{temp[2]}{temp[3]} milions";
            }
            else if(populationStr.Count() == 9)//Milions 100 to 999
            {
                temp = populationStr.Substring(0, 5);

                populationStr = $"{temp[0]}{temp[1]}{temp[2]},{temp[3]}{temp[4]} milions";
            }
            else if(populationStr.Count() > 9)
            {
                temp = populationStr.Substring(0, 4);

                populationStr = $"{temp[0]},{temp[1]}{temp[2]}{temp[3]} bilions";
            }

            return populationStr;
        }
    }
}
