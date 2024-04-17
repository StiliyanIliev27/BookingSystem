using BookingSystem.Core.Contracts;
using BookingSystem.Core.Models.User;
using BookingSystem.Core.Services;
using BookingSystem.Infrastructure.Common;
using BookingSystem.Infrastructure.Data;
using BookingSystem.Infrastructure.Data.Enums;
using BookingSystem.Infrastructure.Data.Models.Flights;
using BookingSystem.Infrastructure.Data.Models.Hotels;
using BookingSystem.Infrastructure.Data.Models.Landmarks;
using BookingSystem.Infrastructure.Data.Models.Location;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace BookingSystem.Tests.UnitTests
{
    [TestFixture]
    public class ReservationServiceTests
    {
        private BookingSystemDbContext dbContext;

        private IEnumerable<City> cities;
        private IEnumerable<Airport> airports;

        private IRepository repository;
        private IReservationService service;

        #region Reservations
        private FlightReservation FlightReservation { get; set; }
        private HotelReservation HotelReservation { get; set; }
        private LandmarkReservation LandmarkReservation { get; set; }

        #endregion

        private ApplicationUser User { get; set; }
        private Flight Flight { get; set; }
        private Airline Airline { get; set; }
        private Hotel Hotel { get; set; }
        private Room Room { get; set; }   
        private Landmark Landmark { get; set; }

        #region Airports
        private Airport DepartureAirport { get; set; }
        private Airport ArrivalAirport { get; set; }

        #endregion

        #region Cities

        private City Paris { get; set; }    
        private City Madrid { get; set; }   

        #endregion

        [SetUp]
        public void Setup()
        {
            User = new ApplicationUser()
            {
                Id = "firstUserId",
                UserName = "firstUser@mail.com",
                NormalizedUserName = "FIRSTUSER@MAIL.COM",
                Email = "firstUser@mail.com",
                NormalizedEmail = "FIRSTUSER@MAIL.COM",
                FirstName = "First",
                LastName = "User"
            };

            Flight = new Flight()
            {
                Id = 1,
                Airline_Id = 1,
                DepartureAirport_Id = 1,
                ArrivalAirport_Id = 2,
                DepartureTime = DateTime.ParseExact("18:15", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("20:25", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 190,
                CabinClass = CabinClass.Economy,
                TicketPrice = 50m,
                IsActive = true
            };

            Airline = new Airline()
            {
                Id = 1,
                Name = "Bulgaria Air",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Bulgaria_Air_logo.svg/1280px-Bulgaria_Air_logo.svg.png",
                WebSiteUrl = "https://www.air.bg/bg"
            };

            Hotel = new Hotel()
            {
                Id = 1,
                Name = "Hotel name",
                Address = "Hotel address",
                City_Id = 1,
                StarRate = 3,
                Details = "Hotel details",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1",
                CheckIn = DateTime.ParseExact("16:00", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = true,
                IsActive = true
            };

            Room = new Room()
            {
                Id = 1,
                Type = RoomType.Single,
                Hotel_Id = 1,
                PricePerNight = 150m,
                WiFi = true,
                IsActive = true,
                Count = 5
            }; 
            
            Landmark = new Landmark()
            {
                Id = 1,
                Name = "Landmark name",
                Address = "Landmark address",
                Details = "Landmark details",
                City_Id = 1,
                TicketPrice = 40m,
                ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1",
                IsActive = true
            };

            #region Cities

            Paris = new City()
            {
                Id = 1,
                Name = "Paris",
                Population = 11_277_000,
                Area = "105,4 km²",
                Details = "Paris, the capital of France, is renowned for its romantic ambiance, iconic landmarks, and vibrant culture. Visitors flock to marvel at the Eiffel Tower, explore the world-class museums like the Louvre and Musée d'Orsay, and stroll along the charming streets of Montmartre or the picturesque banks of the Seine River. With its rich history, exquisite cuisine, and fashionable boutiques, Paris captivates travelers from around the world.",
                Country_Id = 1,
                ImageUrl = "https://images.adsttc.com/media/images/5d44/14fa/284d/d1fd/3a00/003d/large_jpg/eiffel-tower-in-paris-151-medium.jpg?1564742900"
            };

            Madrid = new City()
            {
                Id = 2,
                Name = "Madrid",
                Population = 6_783_000,
                Area = "8,028 km²",
                Details = "Madrid, the capital of Spain, is a vibrant metropolis known for its lively atmosphere, rich history, and cultural treasures. Visitors can explore world-class art museums such as the Prado and Reina Sofía, wander through historic neighborhoods like the Barrio de las Letras, and indulge in delicious tapas at bustling markets like Mercado de San Miguel. With its beautiful parks, grand boulevards, and dynamic nightlife, Madrid offers a captivating blend of tradition and modernity for travelers to enjoy.",
                Country_Id = 2,
                ImageUrl = "https://media.istockphoto.com/id/514769480/photo/madrid-spain-on-gran-via.webp?b=1&s=170667a&w=0&k=20&c=Jrb6V9FM8FkAMjbYHX9p3fArXcAetyn0BfdDeUje8ug="
            };

            #endregion

            #region Reservations         

            FlightReservation = new FlightReservation()
            {
                Id = "flightRes",
                SeatNumber = 1,
                CreatedOn = DateTime.ParseExact("17/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FirstName = "First",
                LastName = "User",
                Flight_Id = 1,
                IsActive = true,
                ReservationDate = DateTime.ParseExact("22/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                TotalChangedNameCount = 0,
                TotalPrice = 50m,
                User_Id = "firstUserId"
            };

            HotelReservation = new HotelReservation()
            {
                User_Id = "firstUserId",
                StartDate = DateTime.ParseExact("05/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("06/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 1,
                CreatedOn = DateTime.ParseExact("17/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FirstName = "First",
                LastName = "User",
                Id = "hotelReservation",
                Price = 150m,
                IsActive = true,
                Room_Id = 1
            };

            LandmarkReservation = new LandmarkReservation()
            {
                Id = "landmarkRes",
                CreatedOn = DateTime.ParseExact("17/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                User_Id = "firstUserId",
                FirstName = "First",
                LastName = "User",
                GroupCount = 1,
                Landmark_Id = 1,
                ReservationDate = DateTime.ParseExact("23/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ReservationTime = DateTime.ParseExact("13:00", "HH:mm", CultureInfo.InvariantCulture),
                TotalPrice = 40m,
                IsActive = true
            };

            #endregion

            #region Airports
            
            DepartureAirport = new Airport()
            {
                Id = 1,
                Name = "Paris Charles de Gaulle Airport",
                ShorterName = "CDG",
                City_Id = 1
            };

            ArrivalAirport = new Airport()
            {
                Id = 2,
                Name = "Madrid–Barajas Airport",
                ShorterName = "MAD",
                City_Id = 2
            };
            #endregion

            airports = new List<Airport>()
            {
                DepartureAirport, ArrivalAirport
            };

            cities = new List<City>()
            {
                Paris, Madrid
            };

            var dbContextOptions = new DbContextOptionsBuilder<BookingSystemDbContext>()
                            .UseInMemoryDatabase("BookingSystemInMemoryDb" + Guid.NewGuid().ToString())
                            .Options;

            dbContext = new BookingSystemDbContext(dbContextOptions);

            dbContext.AddRangeAsync(cities);
            dbContext.AddRangeAsync(airports);
            dbContext.AddAsync(FlightReservation);
            dbContext.AddAsync(HotelReservation);
            dbContext.AddAsync(LandmarkReservation);
            dbContext.Add(User);
            dbContext.Add(Airline);
            dbContext.Add(Flight);
            dbContext.Add(Hotel);
            dbContext.Add(Room);
            dbContext.Add(Landmark);
            dbContext.SaveChangesAsync();

            repository = new Repository(dbContext);
            service = new ReservationService(repository);
        }

        [TearDown]
        public async Task Teardown()
        {
            await dbContext.Database.EnsureDeletedAsync();
            await dbContext.DisposeAsync();
        }

        [Test]
        public async Task Test_AllHotelReservationsAsync_ShouldWorkProperly()
        {
            var result = await service.AllHotelReservationsAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(1));

            Assert.Multiple(() =>
            {
                Assert.That(result.First().ReserverFullName, Is.EqualTo("First User"));
                Assert.That(result.First().UserEmail, Is.EqualTo("firstUser@mail.com"));
                Assert.That(result.First().UserFullName, Is.EqualTo("First User"));
                Assert.That(result.First().RoomType, Is.EqualTo("Single"));
                Assert.That(result.First().Name, Is.EqualTo("Hotel name"));
                Assert.That(result.First().Address, Is.EqualTo("Hotel address"));
                Assert.That(result.First().Hotel_Id, Is.EqualTo(1));
                Assert.That(result.First().HotelImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1"));
                Assert.That(result.First().Price, Is.EqualTo(150m));
                Assert.That(result.First().StartDate, Is.EqualTo("05/05/2024"));
                Assert.That(result.First().EndDate, Is.EqualTo("06/05/2024"));
                Assert.That(result.First().CreatedOn, Is.EqualTo("17/04/2024 00:00"));
                Assert.That(result.First().IsActive, Is.EqualTo("Active"));
            });
        }

        [Test]
        public async Task Test_AllFlightReservationsAsync_ShouldWorkProperly()
        {
            var result = await service.AllFlightReservationsAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(1));

            Assert.That(result.First().ReserverFullName, Is.EqualTo("First User"));
            Assert.That(result.First().UserEmail, Is.EqualTo("firstUser@mail.com"));
            Assert.That(result.First().UserFullName, Is.EqualTo("First User"));
            Assert.That(result.First().Flight_Id, Is.EqualTo(1));
            Assert.That(result.First().Flight, Is.EqualTo("Paris - Madrid"));
            Assert.That(result.First().Airline, Is.EqualTo("Bulgaria Air"));
            Assert.That(result.First().AirlineImageUrl, Is.EqualTo("https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Bulgaria_Air_logo.svg/1280px-Bulgaria_Air_logo.svg.png"));
            Assert.That(result.First().DepartureAirport, Is.EqualTo("Paris Charles de Gaulle Airport"));
            Assert.That(result.First().ArrivalAirport, Is.EqualTo("Madrid–Barajas Airport"));
            Assert.That(result.First().SeatNumber, Is.EqualTo(1));
            Assert.That(result.First().TotalPrice, Is.EqualTo(50m));
            Assert.That(result.First().ReservationDate, Is.EqualTo("22/04/2024"));
            Assert.That(result.First().CreatedOn, Is.EqualTo("17/04/2024 00:00"));
            Assert.That(result.First().IsActive, Is.EqualTo("Active"));
        }

        [Test]
        public async Task Test_AllLandmarkReservationsAsync_ShouldWorkProperly()
        {
            var result = await service.AllLandmarkReservationsAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(1));

            Assert.That(result.First().ReserverFullName, Is.EqualTo("First User"));
            Assert.That(result.First().UserEmail, Is.EqualTo("firstUser@mail.com"));
            Assert.That(result.First().UserFullName, Is.EqualTo("First User"));
            Assert.That(result.First().Landmark_Id, Is.EqualTo(1));
            Assert.That(result.First().Name, Is.EqualTo("Landmark name"));
            Assert.That(result.First().City, Is.EqualTo("Paris"));
            Assert.That(result.First().LandmarkImageUrl, Is.EqualTo("https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1"));
            Assert.That(result.First().GroupCount, Is.EqualTo(1));
            Assert.That(result.First().TotalPrice, Is.EqualTo(40m));
            Assert.That(result.First().ReservationDateTime, Is.EqualTo("23/04/2024 13:00"));
            Assert.That(result.First().CreatedOn, Is.EqualTo("17/04/2024 00:00"));
            Assert.That(result.First().IsActive, Is.EqualTo("Active"));
        }
    }
}
