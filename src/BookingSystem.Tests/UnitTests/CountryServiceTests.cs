using BookingSystem.Core.Contracts;
using BookingSystem.Core.Services;
using BookingSystem.Infrastructure.Common;
using BookingSystem.Infrastructure.Data;
using BookingSystem.Infrastructure.Data.Models.Location;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Tests.UnitTests
{
    [TestFixture]
    public class CountryServiceTests
    {
        private BookingSystemDbContext dbContext;

        private IEnumerable<Language> languages;
        private IEnumerable<Continent> continents;
        private IEnumerable<Country> countries;

        private IRepository repository;
        private ICountryService service;

        #region Languages
        private Language French { get; set; }
        private Language Spanish { get; set; }
        private Language Bulgarian { get; set; }
        private Language Serbian { get; set; }

        #endregion

        #region Continents
        private Continent Europe { get; set; }

        #endregion

        #region Countries
        private Country France { get; set; }
        private Country Spain { get; set; }
        private Country Bulgaria { get; set; }
        private Country Serbia { get; set; }

        #endregion

        [SetUp]
        public void Setup()
        {
            #region Languages

            French = new Language()
            {
                Id = 1,
                Name = "French"
            };

            Spanish = new Language()
            {
                Id = 2,
                Name = "Spanish"
            };

            Bulgarian = new Language()
            {
                Id = 3,
                Name = "Bulgarian"
            };

            Serbian = new Language()
            {
                Id = 4,
                Name = "Serbain"
            };

            #endregion

            #region Continents

            Europe = new Continent()
            {
                Id = 1,
                Name = "Europe",
            };


            #endregion

            #region Countries

            France = new Country()
            {
                Id = 1,
                Name = "France",
                Capital = "Paris",
                Population = 5_841_258,
                Continent_Id = 1,
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
                Continent_Id = 1,
                Details = "Spain's details",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://cdn.britannica.com/36/4336-050-056AC114/Flag-Spain.jpg",
                Language_Id = 2
            };
            
            Bulgaria = new Country()
            {
                Id = 3,
                Name = "Bulgaria",
                Capital = "Paris",
                Population = 555_841_258,
                Continent_Id = 1,
                Details = "Bulgaria's details",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/800px-Flag_of_France.svg.png",
                Language_Id = 3,
            };

            Serbia = new Country()
            {
                Id = 4,
                Name = "Serbia",
                Capital = "Madrid",
                Population = 4_557_473_373,
                Continent_Id = 1,
                Details = "Serbia's details",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://cdn.britannica.com/36/4336-050-056AC114/Flag-Spain.jpg",
                Language_Id = 4
            };

            #endregion


            languages = new List<Language>()
            {
                French, Spanish, Bulgarian, Serbian
            };

            continents = new List<Continent>()
            {
                Europe
            };

            countries = new List<Country>()
            {
                France, Spain, Bulgaria, Serbia
            };



            var dbContextOptions = new DbContextOptionsBuilder<BookingSystemDbContext>()
                        .UseInMemoryDatabase("BookingSystemInMemoryDb"
                            + Guid.NewGuid().ToString())
                        .Options;

            dbContext = new BookingSystemDbContext(dbContextOptions);

            dbContext.AddRangeAsync(languages);
            dbContext.AddRangeAsync(continents);
            dbContext.AddRangeAsync(countries);         
            dbContext.SaveChangesAsync();

            repository = new Repository(dbContext);
            service = new CountryService(repository);
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
                Assert.That(firstResult.Name, Is.EqualTo("France"));
                Assert.That(firstResult.Details, Is.EqualTo("France's details"));
                Assert.That(firstResult.Capital, Is.EqualTo("Paris"));
                Assert.That(firstResult.Population, Is.EqualTo("5,84 milions"));
                Assert.That(firstResult.ContinentName, Is.EqualTo("Europe"));
                Assert.That(firstResult.CurrencyCode, Is.EqualTo("EUR"));
                Assert.That(firstResult.FlagImageUrl, Is.EqualTo("https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/800px-Flag_of_France.svg.png"));
                Assert.That(firstResult.Language, Is.EqualTo("French"));
            });

            var secondResult = await service.DetailsAsync(2);

            Assert.That(secondResult, Is.Not.Null);
            Assert.That(secondResult.Population, Is.EqualTo("47,47 milions"));

            var thirdResult = await service.DetailsAsync(3);

            Assert.That(thirdResult, Is.Not.Null);
            Assert.That(thirdResult.Population, Is.EqualTo("555,84 milions"));


            var fourthResult = await service.DetailsAsync(4);

            Assert.That(fourthResult, Is.Not.Null);
            Assert.That(fourthResult.Population, Is.EqualTo("4,557 bilions"));
            

            try
            {
                _ = await service.DetailsAsync(999);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Country was not found!"));
            }
        }
    }
}