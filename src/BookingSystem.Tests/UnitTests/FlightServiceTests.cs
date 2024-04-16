using BookingSystem.Core.Contracts;
using BookingSystem.Core.Models.User;
using BookingSystem.Core.Services;
using BookingSystem.Infrastructure.Common;
using BookingSystem.Infrastructure.Data;
using BookingSystem.Infrastructure.Data.Models.Flights;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using BookingSystem.Infrastructure.Data.Enums;
using BookingSystem.Infrastructure.Data.Models.Location;
using BookingSystem.Core.Enumerations;
using BookingSystem.Core.Models.Flight;
using BookingSystem.Core.Exceptions;


namespace BookingSystem.Tests.UnitTests
{
    [TestFixture]
    public class FlightServiceTests
    {
        private BookingSystemDbContext dbContext;

        private IEnumerable<City> cities;
        private IEnumerable<Airline> airlines;
        private IEnumerable<Airport> airports;
        private IEnumerable<FlightReservation> reservations;
        private IEnumerable<Flight> flights;
        private IEnumerable<ApplicationUser> users;

        private IRepository repository;
        private IFlightService service;

        #region Cities
        private City Paris { get; set; } = null!;
        private City Madrid { get; set; } = null!;

        #endregion

        #region Airlines
        private Airline Lufthansa { get; set; } = null!;
        private Airline BulgariaAir { get; set; } = null!;

        #endregion

        #region Airports
        private Airport ParisAirport { get; set; } = null!;
        private Airport MadridAirport {  get; set; } = null!;

        #endregion

        #region Users

        private ApplicationUser FirstUser { get; set; } = null!;
        private ApplicationUser SecondUser { get; set; } = null!;

        #endregion

        #region Flights

        private Flight FirstFlight { get; set; }
        private Flight SecondFlight { get; set; }
        private Flight ThirdFlight { get; set; }

        #endregion

        #region Reservations

        private FlightReservation FirstFlightReservation { get; set; }     
        private FlightReservation FirstFlightReservationToRemove { get; set; }
        private FlightReservation FirstFlightReservationNotActive { get; set; }
        private FlightReservation SecondFlightReservation { get; set; }

        private FlightReservation FirstFlightVerification { get; set; }
        private FlightReservation FirstFlightVerificationToRemove { get; set; }
        private FlightReservation SecondFlightVerification { get; set; }

        #endregion

        [SetUp]
        public void Setup()
        {
            #region Users

            FirstUser = new ApplicationUser()
            {
                Id = "firstUserId",
                UserName = "firstUser@mail.com",
                NormalizedUserName = "FIRSTUSER@MAIL.COM",
                Email = "firstUser@mail.com",
                NormalizedEmail = "FIRSTUSER@MAIL.COM",
                FirstName = "Stiliyan",
                LastName = "Iliev"
            };

            SecondUser = new ApplicationUser()
            {
                Id = "secondUserId",
                UserName = "secondUser@mail.com",
                NormalizedUserName = "SECONDUSER@MAIL.COM",
                Email = "secondUser@mail.com",
                NormalizedEmail = "SECONDUSER@MAIL.COM",
                FirstName = "Bogdan",
                LastName = "Slavchev"
            };

            #endregion


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


            #region Airlines

            Lufthansa = new Airline()
            {
                Id = 1,
                Name = "Lufthansa",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Lufthansa_Logo_%28Crane%29.svg/2052px-Lufthansa_Logo_%28Crane%29.svg.png",
                WebSiteUrl = "https://www.lufthansa.com/"
            };

            BulgariaAir = new Airline()
            {
                Id = 2,
                Name = "Bulgaria Air",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Bulgaria_Air_logo.svg/1280px-Bulgaria_Air_logo.svg.png",
                WebSiteUrl = "https://www.air.bg/bg"
            };

            #endregion


            #region Airports 

            ParisAirport = new Airport()
            {
                Id = 1,
                Name = "Paris Charles de Gaulle Airport",
                ShorterName = "CDG",
                City_Id = 1
            };

            MadridAirport = new Airport()
            {
                Id = 2,
                Name = "Madrid–Barajas Airport",
                ShorterName = "MAD",
                City_Id = 2
            };

            #endregion


            #region Flights

            FirstFlight = new Flight()
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

            SecondFlight = new Flight()
            {
                Id = 2,
                Airline_Id = 2,
                DepartureAirport_Id = 2,
                ArrivalAirport_Id = 1,
                DepartureTime = DateTime.ParseExact("15:55", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("18:25", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 90,
                CabinClass = CabinClass.Economy,
                TicketPrice = 100m,
                IsActive = true
            };

            ThirdFlight = new Flight()
            {
                Id = 3,
                Airline_Id = 2,
                DepartureAirport_Id = 1,
                ArrivalAirport_Id = 2,
                DepartureTime = DateTime.ParseExact("15:55", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("18:25", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 90,
                CabinClass = CabinClass.Economy,
                TicketPrice = 150m,
                IsActive = true
            };

            #endregion


            #region Reservations

            FirstFlightReservation = new FlightReservation()
            {
                Id = "firstRes",
                SeatNumber = 1,
                CreatedOn = DateTime.Today,
                FirstName = "First",
                LastName = "User",
                Flight_Id = 1,
                IsActive = true,
                ReservationDate = DateTime.ParseExact("22/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                TotalChangedNameCount = 0,
                TotalPrice = 50m,
                User_Id = "firstUserId"
            };

            FirstFlightReservationToRemove = new FlightReservation()
            {
                Id = "firstResToRemove",
                SeatNumber = 1,
                CreatedOn = DateTime.Today,
                FirstName = "First",
                LastName = "User",
                Flight_Id = 1,
                IsActive = true,
                ReservationDate = DateTime.ParseExact("14/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                TotalChangedNameCount = 0,
                TotalPrice = 50m,
                User_Id = "firstUserId"
            };

            FirstFlightReservationNotActive = new FlightReservation()
            {
                Id = "firstResNotActive",
                SeatNumber = 1,
                CreatedOn = DateTime.Today,
                FirstName = "First",
                LastName = "User",
                Flight_Id = 1,
                IsActive = false,
                ReservationDate = DateTime.ParseExact("15/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                TotalChangedNameCount = 0,
                TotalPrice = 50m,
                User_Id = "firstUserId"
            };

            SecondFlightReservation = new FlightReservation()
            {
                Id = "secondRes",
                SeatNumber = 2,
                CreatedOn = DateTime.Today,
                FirstName = "Second",
                LastName = "User",
                Flight_Id = 2,
                IsActive = true,
                ReservationDate = DateTime.ParseExact("23/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                TotalChangedNameCount = 0,
                TotalPrice = 100m,
                User_Id = "secondUserId"
            };

            FirstFlightVerification = new FlightReservation()
            {
                Id = "firstVer",
                SeatNumber = 1,
                CreatedOn = DateTime.Today,
                FirstName = "First",
                LastName = "User",
                Flight_Id = 1,
                IsActive = false,
                ReservationDate = DateTime.ParseExact("22/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                TotalChangedNameCount = 0,
                TotalPrice = 50m,
                User_Id = "firstUserId"
            };

            FirstFlightVerificationToRemove = new FlightReservation()
            {
                Id = "firstVerToRemove",
                SeatNumber = 1,
                CreatedOn = DateTime.Today,
                FirstName = "First",
                LastName = "User",
                Flight_Id = 1,
                IsActive = false,
                ReservationDate = DateTime.ParseExact("15/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                TotalChangedNameCount = 0,
                TotalPrice = 50m,
                User_Id = "firstUserId"
            };

            SecondFlightVerification = new FlightReservation()
            {
                Id = "secondVer",
                SeatNumber = 2,
                CreatedOn = DateTime.Today,
                FirstName = "Second",
                LastName = "User",
                Flight_Id = 2,
                IsActive = false,
                ReservationDate = DateTime.ParseExact("23/04/2024", "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None),
                TotalChangedNameCount = 0,
                TotalPrice = 100m,
                User_Id = "secondUserId"
            };

            #endregion

            

            users = new List<ApplicationUser>()
            {
                FirstUser, SecondUser
            };

            cities = new List<City>()
            {
                Paris, Madrid
            };

            airlines = new List<Airline>()
            {
                Lufthansa, BulgariaAir
            };

            airports = new List<Airport>()
            {
                ParisAirport, MadridAirport
            };

            flights = new List<Flight>()
            {
                FirstFlight, SecondFlight, ThirdFlight
            };

            reservations = new List<FlightReservation>()
            {
                FirstFlightReservation, SecondFlightReservation, 
                FirstFlightVerification, SecondFlightVerification,
                FirstFlightVerificationToRemove, FirstFlightReservationToRemove,
                FirstFlightReservationNotActive
            };

            


            var dbContextOptions = new DbContextOptionsBuilder<BookingSystemDbContext>()
                    .UseInMemoryDatabase("BookingSystemInMemoryDb"
                        + Guid.NewGuid().ToString())
                    .Options;

            dbContext = new BookingSystemDbContext(dbContextOptions);

            dbContext.AddRangeAsync(users);
            dbContext.AddRangeAsync(cities);
            dbContext.AddRangeAsync(airlines);
            dbContext.AddRangeAsync(airports);
            dbContext.AddRangeAsync(reservations);
            dbContext.AddRangeAsync(flights);
            dbContext.AddRangeAsync(reservations);
            
            dbContext.SaveChangesAsync();

            repository = new Repository(dbContext);
            service = new FlightService(repository);
        }
        
        [TearDown]
        public async Task Teardown()
        {
            await dbContext.Database.EnsureDeletedAsync();
            await dbContext.DisposeAsync();
        }

        [Test]
        public async Task Test_ExistsByIdAsync_ShouldReturnCorrectResult_True()
        {
            var result = await service.ExistsByIdAsync(1);

            Assert.That(result, Is.True);
        }
        
        [Test]
        public async Task Test_ExistsByIdAsync_ShouldReturnCorrectResult_False()
        {
            var result = await service.ExistsByIdAsync(999);

            Assert.That(result, Is.False);
        }
        
        [Test]
        public async Task Test_VerificationExistsByIdAsync_ShouldReturnCorrectResult_True()
        {
            var result = await service.VerificationExistsByIdAsync("firstVer");

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task Test_VerificationExistsByIdAsync_ShouldReturnCorrectResult_False()
        {
            var result = await service.VerificationExistsByIdAsync("InvalidVer");

            Assert.That(result, Is.False);
        }


        [Test]
        public async Task Test_ReservationExistsByIdAsync_ShouldReturnCorrectResult_True()
        {
            var result = await service.ReservationExistsByIdAsync("firstRes");

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task Test_ReservationExistsByIdAsync_ShouldReturnCorrectResult_False()
        {
            var result = await service.ReservationExistsByIdAsync("InvalidRes");

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task Test_AllAsync_FiltersByDepartureCity()
        {
            var firstResult = await service.AllAsync("Paris");
            var secondResult = await service.AllAsync("NotAnExistingCity");

            Assert.That(firstResult.TotalFlightsCount, Is.EqualTo(2));
            Assert.That(firstResult.Flights.First().Id == 1, Is.True);

            Assert.That(secondResult.TotalFlightsCount, Is.EqualTo(0));
            Assert.That(secondResult.Flights, Is.Empty);
        }

        [Test]
        public async Task Test_AllAsync_FiltersByArrivalCity()
        {
            var firstResult = await service.AllAsync(null, "Madrid");
            var secondResult = await service.AllAsync(null, "NotAnExistingCity");

            Assert.That(firstResult.TotalFlightsCount, Is.EqualTo(2));
            Assert.That(firstResult.Flights.First().Id == 1, Is.True);

            Assert.That(secondResult.TotalFlightsCount, Is.EqualTo(0));
            Assert.That(secondResult.Flights, Is.Empty);
        }

        [Test]
        public async Task Test_AllAsync_SortsByPriceAscending()
        {
            var flightsPriceAscSorting = await service.AllAsync(null, null, FlightSorting.PriceAscending);

            var flightIds = new List<int>()
            {
                flightsPriceAscSorting.Flights.First().Id,
                flightsPriceAscSorting.Flights.Skip(1).First().Id,
                flightsPriceAscSorting.Flights.Last().Id
            };

            Assert.IsNotNull(flightsPriceAscSorting.Flights);
            Assert.That(flightsPriceAscSorting.Flights.Count(), Is.EqualTo(3));
            Assert.That(flightIds, Is.EqualTo(new List<int>() { 1, 2, 3 }));
        }

        [Test]
        public async Task Test_AllAsync_SortsByPriceDescending()
        {
            var flightsPriceDescSorting = await service.AllAsync(null, null, FlightSorting.PriceDescending);
            var flightIds = new List<int>()
            {
                flightsPriceDescSorting.Flights.First().Id,
                flightsPriceDescSorting.Flights.Skip(1).First().Id,
                flightsPriceDescSorting.Flights.Last().Id
            };

            Assert.IsNotNull(flightsPriceDescSorting.Flights);
            Assert.That(flightsPriceDescSorting.Flights.Count(), Is.EqualTo(3));
            Assert.That(flightIds, Is.EqualTo(new List<int>() { 3, 2, 1 }));
        }

        [Test]
        public async Task Test_DetailsAsync_ShouldWorkCorrectly()
        {
            var model = await service.DetailsAsync(1);
            
            Assert.Multiple(() =>
            {
                Assert.That(model.Id, Is.EqualTo(1));
                Assert.That(model.City, Is.EqualTo("Madrid"));
                Assert.That(model.ArrivalAirport, Is.EqualTo("Madrid–Barajas Airport"));
                Assert.That(model.ArrivalAirportShorterName, Is.EqualTo("MAD"));
                Assert.That(model.DepartureAirport, Is.EqualTo("Paris Charles de Gaulle Airport"));
                Assert.That(model.DepartureAirportShorterName, Is.EqualTo("CDG"));
                Assert.That(model.Airline, Is.EqualTo("Lufthansa"));
                Assert.That(model.AirlineLogoUrl, Is.EqualTo("https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Lufthansa_Logo_%28Crane%29.svg/2052px-Lufthansa_Logo_%28Crane%29.svg.png"));
                Assert.That(model.DepartureTime, Is.EqualTo("18:15"));
                Assert.That(model.ArrivalTime, Is.EqualTo("20:25"));
                Assert.That(model.FlightDuration, Is.EqualTo(190));
                Assert.That(model.CabinClass, Is.EqualTo("Economy"));
                Assert.That(model.TicketPrice, Is.EqualTo(50m));
            });
        }
        
        [Test]
        public async Task Test_DetailsAsync_ShouldThrowAnException_IfFlightDoesNotExist()
        {
            try
            {
                _ = await service.DetailsAsync(999);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current flight is not found!"));
            }      
        }

        [Test]
        public async Task Test_GetForReserveAsync_ShouldWorkCorrectly()
        {
            var firstResult = await service.GetForReserveAsync(1);

            Assert.That(firstResult, Is.Not.Null);  
            Assert.That(firstResult.Flight_Id, Is.EqualTo(1));

            try
            {
               _ = await service.GetForReserveAsync(999);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current flight was not found!"));
            }
        }

        [Test]
        public async Task Test_ReserveAsync_ShouldWorkCorrectly()
        {
            var model = new FlightReservationInputModel()
            {
                FirstName = "Test",
                LastName = "Testov",
                ReservationDate = "25/04/2024",
            };

            var resCntBefore = await repository.AllReadOnly<FlightReservation>().CountAsync();

            var result = await service.ReserveAsync(model, "firstUserId", 1);

            var resExists = await service.VerificationExistsByIdAsync(result);
            var resCntAfter = await repository.AllReadOnly<FlightReservation>().CountAsync();

            Assert.That(resCntBefore, Is.EqualTo(7));
            Assert.That(resCntAfter, Is.EqualTo(8));
            Assert.That(result, Is.Not.Null);
            Assert.That(resExists, Is.EqualTo(true));

            try
            {
                _ = await service.ReserveAsync(model, "firstUserId", 999);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current flight does not exist!"));
            }
        }

        [Test]
        public async Task Test_GetReservationsForVerifyAsync_ShouldWorkCorrectly()
        {
            var verBefore = await repository.All<FlightReservation>()
                .Where(fr => fr.User_Id == "firstUserId" && fr.IsActive == false
                    && fr.ReservationDate.Date < DateTime.Now.Date)
                .CountAsync();//1

            var firstResult = await service.GetReservationsForVerifyAsync("firstUserId");

            var verAfter = await repository.All<FlightReservation>()
                .Where(fr => fr.User_Id == "firstUserId" && fr.IsActive == false
                    && fr.ReservationDate.Date < DateTime.Now.Date)
                .CountAsync();//0
           
            
            Assert.Multiple(() =>
            {
                Assert.That(verBefore, Is.EqualTo(2));
                Assert.That(verAfter, Is.EqualTo(0));
                Assert.That(firstResult, Is.Not.Null);
                Assert.That(firstResult.First().Id, Is.EqualTo("firstVer"));
                Assert.That(firstResult.First().FirstName, Is.EqualTo("First"));
                Assert.That(firstResult.First().LastName, Is.EqualTo("User"));
                Assert.That(firstResult.First().FlightId, Is.EqualTo(1));
            });
        }

        [Test]
        public async Task Test_VerifyAsync_ShouldWorkCorrectly()
        {
            await service.VerifyAsync("firstVer", "firstUserId");

            var res = await repository.GetByIdAsync<FlightReservation>("firstVer");

            Assert.That(res, Is.Not.Null);
            Assert.That(res.IsActive, Is.True);

            try
            {
                await service.VerifyAsync("invalidVer", "firstUserId");
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current reservation was not found!"));
            }

            try
            {
                await service.VerifyAsync("firstVer", "secondUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }
        }

        [Test]
        public async Task Test_CancellVerificationAsync_ShouldWorkCorrectly()
        {
            var resCntBefore = await repository.AllReadOnly<FlightReservation>().CountAsync();

            await service.CancellVerificationAsync("firstVer", "firstUserId");

            var resCntAfter = await repository.AllReadOnly<FlightReservation>().CountAsync();

            Assert.That(resCntBefore, Is.EqualTo(7));
            Assert.That(resCntAfter, Is.EqualTo(6));

            try
            {
                await service.CancellVerificationAsync("invalidVer", "firstUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current reservation was not found!"));
            }

            try
            {
                await service.CancellVerificationAsync("secondVer", "firstUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }
        }

        [Test]
        public async Task Test_MyReservationsAsync_ShouldWorkCorrectly()
        {
            var resCntBefore = await repository.All<FlightReservation>()
                .Where(fr => fr.User_Id == "firstUserId" && fr.IsActive == true
                    && fr.ReservationDate.Date < DateTime.Now.Date).CountAsync();//1

            var result = await service.MyReservationsAsync("firstUserId");

            var resCntAfter = await repository.All<FlightReservation>()
                .Where(fr => fr.User_Id == "firstUserId" && fr.IsActive == true
                    && fr.ReservationDate.Date < DateTime.Now.Date).CountAsync();//0

            var res = await repository.AllReadOnly<FlightReservation>()
                .Where(fr => fr.User_Id == "firstUserId" && fr.ReservationDate >= DateTime.Now.Date && fr.IsActive == true)
                .ToListAsync();

            var resExists = await service.ReservationExistsByIdAsync(res.First().Id);

            Assert.That(resCntBefore, Is.EqualTo(1));
            Assert.That(resCntAfter, Is.EqualTo(0));
            Assert.That(res, Is.Not.Null);
            Assert.That(resExists, Is.True);       
        }

        [Test]
        public async Task Test_GetForEditReservationAsync_ShouldWorkCorrectly()
        {
            var result = await service.GetForEditReservationAsync("firstRes", "firstUserId");

            Assert.That(result.Id, Is.EqualTo("firstRes"));
            Assert.That(result.FirstName, Is.EqualTo("First"));
            Assert.That(result.LastName, Is.EqualTo("User"));
            Assert.That(result.TotalChangesNameCnt, Is.EqualTo(0));

            try
            {
                _ = await service.GetForEditReservationAsync("invalidRes", "firstUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current flight reservation was not found!"));
            }

            try
            {
                _ = await service.GetForEditReservationAsync("firstRes", "secondUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }

            try
            {
                _ = await service.GetForEditReservationAsync("firstResNotActive", "firstUserId");
            }
            catch (NoLongerActiveReservationException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The reservation is no longer available!"));
            }
        }
        
        [Test]
        public async Task Test_EditReservationAsync_ShouldWorkCorrectly()
        {
            var model = new FlightReservationEditInputModel()
            {
                Id = "firstRes",
                FirstName = "First",
                LastName = "User",    
            };

            await service.EditReservationAsync(model, "firstUserId");

            var res = await repository.GetByIdAsync<FlightReservation>(model.Id);    

            Assert.That(res, Is.Not.Null);
            Assert.That(res!.Id, Is.EqualTo("firstRes"));
            Assert.That(res!.FirstName, Is.EqualTo("First"));
            Assert.That(res!.LastName, Is.EqualTo("User"));
            Assert.That(res!.TotalChangedNameCount, Is.EqualTo(1));

            try
            {
                var secondModel = new FlightReservationEditInputModel()
                {
                    Id = "invalidRes",
                    FirstName = "First",
                    LastName = "User",
                };

                await service.EditReservationAsync(secondModel, "firstUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current flight reservation was not found!"));
            }

            try
            {
                await service.EditReservationAsync(model, "secondUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }

            try
            {
                var secondModel = new FlightReservationEditInputModel()
                {
                    Id = "firstResNotActive",
                    FirstName = "First",
                    LastName = "User",
                };

                await service.EditReservationAsync(secondModel, "firstUserId");
            }
            catch (NoLongerActiveReservationException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The reservation is no longer available!"));
            }
        }

        [Test]
        public async Task Test_CancellReservationAsync_ShouldWorkCorrectly()
        {
            var resCntBefore = await repository.AllReadOnly<FlightReservation>().CountAsync();

            await service.CancellReservationAsync("firstRes", "firstUserId");

            var resCntAfter = await repository.AllReadOnly<FlightReservation>().CountAsync();

            Assert.That(resCntBefore, Is.EqualTo(7));
            Assert.That(resCntAfter, Is.EqualTo(6));

            try
            {
                await service.CancellReservationAsync("invalidRes", "firstUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current reservation was not found!"));
            }

            try
            {
                await service.CancellReservationAsync("secondRes", "firstUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }

            try
            { 
                await service.CancellReservationAsync("firstResNotActive", "firstUserId");
            }
            catch (NoLongerActiveReservationException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The reservation is no longer available!"));
            }
        }

        [Test]
        public async Task Test_AllFlightsForAdminAsync_FiltersByDepartureCity()
        {
            var firstResult = await service.AllFlightsForAdminAsync("Paris");
            var secondResult = await service.AllFlightsForAdminAsync("NotAnExistingCity");

            Assert.That(firstResult.Flights.First().Id == 1, Is.True);
            Assert.That(secondResult.Flights, Is.Empty);
        }

        [Test]
        public async Task Test_AllFlightsForAdminAsync_FiltersByArrivalCity()
        {
            var firstResult = await service.AllFlightsForAdminAsync(null, "Madrid");
            var secondResult = await service.AllFlightsForAdminAsync(null, "NotAnExistingCity");

            Assert.That(firstResult.Flights.First().Id == 1, Is.True);
            Assert.That(secondResult.Flights, Is.Empty);
        }

        [Test]
        public async Task Test_AllFlightsForAdminAsync_SortsByIdentifier()
        {
            var flightsIdentifierSorting = await service.AllFlightsForAdminAsync(null, null, FlightSorting.IdentifierAscending);

            var flightIds = new List<int>()
            {
                flightsIdentifierSorting.Flights.First().Id,
                flightsIdentifierSorting.Flights.Skip(1).First().Id,
                flightsIdentifierSorting.Flights.Last().Id
            };

            Assert.IsNotNull(flightsIdentifierSorting.Flights);
            Assert.That(flightsIdentifierSorting.Flights.Count(), Is.EqualTo(3));
            Assert.That(flightIds, Is.EqualTo(new List<int>() { 1, 2, 3 }));
        }

        [Test]
        public async Task Test_AllFlightsForAdminAsync_SortsByPriceAscending()
        {
            var flightsPriceAscSorting = await service.AllFlightsForAdminAsync(null, null, FlightSorting.PriceAscending);

            var flightIds = new List<int>()
            {
                flightsPriceAscSorting.Flights.First().Id,
                flightsPriceAscSorting.Flights.Skip(1).First().Id,
                flightsPriceAscSorting.Flights.Last().Id
            };

            Assert.IsNotNull(flightsPriceAscSorting.Flights);
            Assert.That(flightsPriceAscSorting.Flights.Count(), Is.EqualTo(3));
            Assert.That(flightIds, Is.EqualTo(new List<int>() { 1, 2, 3 }));
        }

        [Test]
        public async Task Test_AllFlightsForAdminAsync_SortsByPriceDescending()
        {
            var flightsPriceDescSorting = await service.AllFlightsForAdminAsync(null, null, FlightSorting.PriceDescending);
            var flightIds = new List<int>()
            {
                flightsPriceDescSorting.Flights.First().Id,
                flightsPriceDescSorting.Flights.Skip(1).First().Id,
                flightsPriceDescSorting.Flights.Last().Id
            };

            Assert.IsNotNull(flightsPriceDescSorting.Flights);
            Assert.That(flightsPriceDescSorting.Flights.Count(), Is.EqualTo(3));
            Assert.That(flightIds, Is.EqualTo(new List<int>() { 3, 2, 1 }));
        }

        [Test]
        public async Task Test_GetForEditAsync_ShouldWorkCorrectly()
        {
            var result = await service.GetForEditAsync(1);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(1));
                Assert.That(result.DepartureTime, Is.EqualTo("18:15"));
                Assert.That(result.ArrivalTime, Is.EqualTo("20:25"));
                Assert.That(result.FlightDuration, Is.EqualTo(190));
                Assert.That(result.CabinClass, Is.EqualTo("Economy"));
                Assert.That(result.TicketPrice, Is.EqualTo(50m));
                Assert.That(result.Airline_Id, Is.EqualTo(1));
            });

            try
            {
                _ = await service.GetForEditAsync(999);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Flight was not found!"));
            }
        }

        [Test]
        public async Task Test_EditAsync_ShouldWorkCorrectly()
        {
            var model = new FlightEditInputModel()
            {
                Id = 1,
                DepartureTime = "18:15",
                ArrivalTime = "20:25",
                CabinClass = "Economy",
                Airline_Id = 1,
                TicketPrice = 50m,
                FlightDuration = 190
            };

            await service.EditAsync(model);

            var flight = await repository.GetByIdAsync<Flight>(1);
            
            Assert.Multiple(() =>
            {
                Assert.That(flight!.Id, Is.EqualTo(model.Id));
                Assert.That(flight!.DepartureTime, Is.EqualTo(DateTime.ParseExact(model.DepartureTime, "HH:mm", CultureInfo.InvariantCulture)));
                Assert.That(flight!.ArrivalTime, Is.EqualTo(DateTime.ParseExact(model.ArrivalTime, "HH:mm", CultureInfo.InvariantCulture)));
                Assert.That(flight!.CabinClass.ToString(), Is.EqualTo(model.CabinClass));
                Assert.That(flight!.Airline_Id, Is.EqualTo(model.Airline_Id));
                Assert.That(flight!.TicketPrice, Is.EqualTo(model.TicketPrice));
                Assert.That(flight!.FlightDuration, Is.EqualTo(model.FlightDuration));
            });

            var tryModel = new FlightEditInputModel()
            {
                Id = 1,
                DepartureTime = "18:15",
                ArrivalTime = "20:25",
                CabinClass = "Premium Economy",
                Airline_Id = 1,
                TicketPrice = 50m,
                FlightDuration = 190
            };

            await service.EditAsync(tryModel);

            var secFlight = await repository.GetByIdAsync<Flight>(1);

            Assert.Multiple(() =>
            {
                Assert.That(secFlight!.Id, Is.EqualTo(tryModel.Id));
                Assert.That(secFlight!.DepartureTime, Is.EqualTo(DateTime.ParseExact(tryModel.DepartureTime, "HH:mm", CultureInfo.InvariantCulture)));
                Assert.That(secFlight!.ArrivalTime, Is.EqualTo(DateTime.ParseExact(tryModel.ArrivalTime, "HH:mm", CultureInfo.InvariantCulture)));
                Assert.That(secFlight!.CabinClass.ToString(), Is.EqualTo("PremiumEconomy"));
                Assert.That(secFlight!.Airline_Id, Is.EqualTo(tryModel.Airline_Id));
                Assert.That(secFlight!.TicketPrice, Is.EqualTo(tryModel.TicketPrice));
                Assert.That(secFlight!.FlightDuration, Is.EqualTo(tryModel.FlightDuration));
            });

            try
            {
                var secondModel = new FlightEditInputModel()
                {
                    Id = 999,
                    DepartureTime = "18:15",
                    ArrivalTime = "20:25",
                    CabinClass = "Economy",
                    Airline_Id = 1,
                    TicketPrice = 50m,
                    FlightDuration = 190
                };

                await service.EditAsync(secondModel);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Flight was not found!"));
            }
        }

        [Test]
        public void Test_GetAllCabinClasses_ShouldReturnCorrectResult()
        {
            var result = service.GetAllCabinClasses();

            IEnumerable<string> expected = new List<string>()
            {
                "Economy",
                "PremiumEconomy",
                "Business",
                "First"
            };

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public async Task Test_GetAllAirlinesAsync_ShouldReturnCorrectResult()
        {
            IEnumerable<AirlineViewModel> result = await service.GetAllAirlinesAsync();

            IEnumerable<AirlineViewModel> expected = new List<AirlineViewModel>()
            {
                new()
                {
                    Id = 1,
                    Name = "Lufthansa",     
                },
                new()
                {
                    Id = 2,
                    Name = "Bulgaria Air",
                }
            };
           
            Assert.Multiple(() =>
            {
                Assert.That(result.Count(), Is.EqualTo(2));
                Assert.That(result.First().Id, Is.EqualTo(expected.First().Id));
                Assert.That(result.First().Name, Is.EqualTo(expected.First().Name));
                Assert.That(result.Skip(1).First().Id, Is.EqualTo(expected.Skip(1).First().Id));
                Assert.That(result.Skip(1).First().Name, Is.EqualTo(expected.Skip(1).First().Name));
            });
        }

        [Test]
        public async Task Test_DeleteAsync_ShouldReturnCorrectResult()
        {
            var flightsCntBefore = await repository.AllReadOnly<Flight>().CountAsync();//3
            
            var resCntBefore = await repository.AllReadOnly<FlightReservation>()
                .Where(fr => fr.Flight_Id == 2)
                .CountAsync();//2

            await service.DeleteAsync(2);

            var flightsCntAfter = await repository.AllReadOnly<Flight>().CountAsync();//2

            var resCntAfter = await repository.AllReadOnly<FlightReservation>()
                .Where(fr => fr.Flight_Id == 2)
                .CountAsync();//0
            
            Assert.Multiple(() =>
            {
                Assert.That(flightsCntBefore, Is.EqualTo(3));
                Assert.That(flightsCntAfter, Is.EqualTo(2));
                Assert.That(resCntBefore, Is.EqualTo(2));
                Assert.That(resCntAfter, Is.EqualTo(0));
            });

            try
            {
                await service.DeleteAsync(999);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The flight was not found!"));
            }
        }

        [Test]
        public async Task Test_GetForAddAsync_ShouldReturnCorrectResult()
        {
            var result = await service.GetForAddAsync();

            var airlines = await service.GetAllAirlinesAsync();
            var cabinClasses = service.GetAllCabinClasses();
            var airports = await service.GetAllAirportsAsync();

            Assert.That(result.CabinClasses, Is.EqualTo(cabinClasses));
            Assert.That(result.Airlines.Count(), Is.EqualTo(airlines.Count()));
            Assert.That(result.Airports.Count(), Is.EqualTo(airports.Count()));
        }

        [Test]
        public async Task Test_GetAllAirportsAsync_ShouldReturnCorrectResult()
        {
            IEnumerable<AirportViewModel> result = await service.GetAllAirportsAsync();

            IEnumerable<AirportViewModel> expected = new List<AirportViewModel>()
            {
                new()
                {
                    Id = 1,
                    Name = "Paris Charles de Gaulle Airport",
                },
                new()
                {
                    Id = 2,
                    Name = "Madrid–Barajas Airport",
                }
            };

            Assert.Multiple(() =>
            {
                Assert.That(result.Count(), Is.EqualTo(2));
                Assert.That(result.First().Id, Is.EqualTo(expected.First().Id));
                Assert.That(result.First().Name, Is.EqualTo(expected.First().Name));
                Assert.That(result.Skip(1).First().Id, Is.EqualTo(expected.Skip(1).First().Id));
                Assert.That(result.Skip(1).First().Name, Is.EqualTo(expected.Skip(1).First().Name));
            });
        }

        [Test]
        public async Task Test_AddAsync_ShouldReturnCorrectResult()
        {
            var model = new FlightAddInputModel()
            {
                DepartureTime = "18:15",
                ArrivalTime = "20:25",
                CabinClass = "Economy",
                Airline_Id = 1,
                TicketPrice = 50m,
                FlightDuration = 190
            };

            var flightCntBefore = await repository.AllReadOnly<Flight>().CountAsync();

            await service.AddAsync(model);


            var tryModel = new FlightAddInputModel()
            {
                DepartureTime = "18:15",
                ArrivalTime = "20:25",
                CabinClass = "Premium Economy",
                Airline_Id = 1,
                TicketPrice = 50m,
                FlightDuration = 190
            };

            await service.AddAsync(tryModel);

            var flightCntAfter = await repository.AllReadOnly<Flight>().CountAsync();

            Assert.That(flightCntBefore, Is.EqualTo(3));
            Assert.That(flightCntAfter, Is.EqualTo(5));  
        }
    }
}