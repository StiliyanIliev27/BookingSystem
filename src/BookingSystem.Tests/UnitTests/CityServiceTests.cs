using BookingSystem.Core.Contracts;
using BookingSystem.Core.Models.User;
using BookingSystem.Core.Services;
using BookingSystem.Infrastructure.Common;
using BookingSystem.Infrastructure.Data;
using BookingSystem.Infrastructure.Data.Models.Location;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Tests.UnitTests
{
    [TestFixture]
    public class CityServiceTests
    {
        private BookingSystemDbContext dbContext;

        private IEnumerable<Country> countries;
        private IEnumerable<City> cities;

        private IRepository repository;
        private ICityService service;

        #region Countries
        private Country France { get; set; }
        private Country Spain { get; set; }

        #endregion

        #region Cities
        private City Paris { get; set; }
        private City Madrid { get; set; }

        #endregion

        [SetUp]
        public void Setup()
        {
            #region Countries

            France = new Country()
            {
                Id = 1,
                Name = "France",
                Capital = "Paris",
                Population = 64_841_258,
                Continent_Id = 6,
                Details = "France's details",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/800px-Flag_of_France.svg.png",
                Language_Id = 1,
            };

            Spain = new Country()
            {
                Id = 2,
                Name = "Spain",
                Capital = "Madrid",
                Population = 47_473_373,
                Continent_Id = 6,
                Details = "Spain's details",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://cdn.britannica.com/36/4336-050-056AC114/Flag-Spain.jpg",
                Language_Id = 2
            };

            #endregion

            #region Cities

            Paris = new City()
            {
                Id = 1,
                Name = "Paris",
                Population = 11_277_000,
                Area = "105,4 km²",
                Details = "Paris's details",
                Country_Id = 1,
                ImageUrl = "https://images.adsttc.com/media/images/5d44/14fa/284d/d1fd/3a00/003d/large_jpg/eiffel-tower-in-paris-151-medium.jpg?1564742900"
            };

            Madrid = new City()
            {
                Id = 2,
                Name = "Madrid",
                Population = 6_783_000,
                Area = "8,028 km²",
                Details = "Madrid's details",
                Country_Id = 2,
                ImageUrl = "https://media.istockphoto.com/id/514769480/photo/madrid-spain-on-gran-via.webp?b=1&s=170667a&w=0&k=20&c=Jrb6V9FM8FkAMjbYHX9p3fArXcAetyn0BfdDeUje8ug="
            };

            #endregion


            countries = new List<Country>()
            {
                France, Spain
            };

            cities = new List<City>()
            {
                Paris, Madrid
            };
            


            var dbContextOptions = new DbContextOptionsBuilder<BookingSystemDbContext>()
                        .UseInMemoryDatabase("BookingSystemInMemoryDb"
                            + Guid.NewGuid().ToString())
                        .Options;

            dbContext = new BookingSystemDbContext(dbContextOptions);

            dbContext.AddRangeAsync(countries);
            dbContext.AddRangeAsync(cities);
            dbContext.SaveChangesAsync();

            repository = new Repository(dbContext);
            service = new CityService(repository);
        }

        [TearDown]
        public async Task Teardown()
        {
            await dbContext.Database.EnsureDeletedAsync();
            await dbContext.DisposeAsync();
        }

        [Test]
        public async Task Test_DetailsAsync_ShouldReturnCorrectResult()
        {
            var firstResult = await service.DetailsAsync(1);

            Assert.That(firstResult, Is.Not.Null);
            
            Assert.Multiple(() =>
            {
                Assert.That(firstResult.Id, Is.EqualTo(1));
                Assert.That(firstResult.Name, Is.EqualTo("Paris"));
                Assert.That(firstResult.Details, Is.EqualTo("Paris's details"));
                Assert.That(firstResult.Area, Is.EqualTo("105,4 km²"));
                Assert.That(firstResult.Population, Is.EqualTo("11,27 milions"));
                Assert.That(firstResult.CountryName, Is.EqualTo("France"));
                Assert.That(firstResult.CountryId, Is.EqualTo(1));
                Assert.That(firstResult.ImageUrl, Is.EqualTo("https://images.adsttc.com/media/images/5d44/14fa/284d/d1fd/3a00/003d/large_jpg/eiffel-tower-in-paris-151-medium.jpg?1564742900"));
            });

            var secondResult = await service.DetailsAsync(2);

            Assert.That(secondResult, Is.Not.Null);

            Assert.Multiple(() =>
            {
                Assert.That(secondResult.Id, Is.EqualTo(2));
                Assert.That(secondResult.Name, Is.EqualTo("Madrid"));
                Assert.That(secondResult.Details, Is.EqualTo("Madrid's details"));
                Assert.That(secondResult.Area, Is.EqualTo("8,028 km²"));
                Assert.That(secondResult.Population, Is.EqualTo("6,78 milions"));
                Assert.That(secondResult.CountryName, Is.EqualTo("Spain"));
                Assert.That(secondResult.CountryId, Is.EqualTo(2));
                Assert.That(secondResult.ImageUrl, Is.EqualTo("https://media.istockphoto.com/id/514769480/photo/madrid-spain-on-gran-via.webp?b=1&s=170667a&w=0&k=20&c=Jrb6V9FM8FkAMjbYHX9p3fArXcAetyn0BfdDeUje8ug="));
            });

            try
            {
                _ = await service.DetailsAsync(999);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("City was not found!"));
            }
        }
    }
}
