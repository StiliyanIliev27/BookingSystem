namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Location;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;

    public class CityService : ICityService
    {
        private readonly IRepository repository;
        public CityService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<CityDetailsViewlModel> DetailsAsync(int cityId)
        {
            var city = await repository.AllReadOnly<City>()
                .Include(c => c.Country)
                .Where(c => c.Id == cityId)
                .FirstOrDefaultAsync();

            if(city == null)
            {
                throw new ArgumentException("City was not found!");
            }

            string populationString = GetPopulationString(city);

            return new CityDetailsViewlModel()
            {
                Id = city.Id,
                Name = city.Name,
                Population = populationString,
                Area = city.Area,
                Details = city.Details,
                CountryName = city.Country.Name,
                CountryId = city.Country.Id,
                ImageUrl = city.ImageUrl
            };
        }
        private string GetPopulationString(City city)
        {
            string populationStr = city.Population.ToString();
            string temp = string.Empty;

            if (populationStr.Count() == 7)//Milions 1 to 9
            {
                temp = populationStr.Substring(0, 3);

                populationStr = $"{temp[0]},{temp[1]}{temp[2]} milions";
            }
            else if (populationStr.Count() > 7)//Milions 10 to 100 
            {
                temp = populationStr.Substring(0, 4);

                populationStr = $"{temp[0]}{temp[1]},{temp[2]}{temp[3]} milions";
            }

            return populationStr;
        }
    }
}
