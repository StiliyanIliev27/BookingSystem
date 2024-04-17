using BookingSystem.Core.Contracts;
using BookingSystem.Core.Enumerations;
using BookingSystem.Core.Exceptions;
using BookingSystem.Core.Models.Landmark;
using BookingSystem.Core.Models.User;
using BookingSystem.Core.Services;
using BookingSystem.Infrastructure.Common;
using BookingSystem.Infrastructure.Data;
using BookingSystem.Infrastructure.Data.Models.Landmarks;
using BookingSystem.Infrastructure.Data.Models.Location;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace BookingSystem.Tests.UnitTests
{
    [TestFixture]
    public class LandmarkServiceTests
    {
        private BookingSystemDbContext dbContext;

        private IEnumerable<ApplicationUser> users;
        private IEnumerable<Country> countries;
        private IEnumerable<City> cities;
        private IEnumerable<Landmark> landmarks;
        private IEnumerable<LandmarkReservation> reservations;

        private IRepository repository;
        private ILandmarkService service;

        #region Users
        private ApplicationUser FirstUser { get; set; } = null!;
        private ApplicationUser SecondUser { get; set; } = null!;

        #endregion

        #region Countries

        private Country France { get; set; } = null!;
        private Country Spain { get; set; } = null!;

        #endregion  

        #region Cities
        private City Paris { get; set; } = null!;
        private City Madrid { get; set; } = null!;

        #endregion

        #region Landmarks
        private Landmark EiffelTower { get; set; } = null!;
        private Landmark PlazaMayor { get; set; } = null!;

        #endregion

        #region Reservations
        private LandmarkReservation FirstReservation { get; set; } = null!;
        private LandmarkReservation FirstReservationNotActive { get; set; } = null!;
        private LandmarkReservation FirstReservationNotActiveProp { get; set; } = null!;

        private LandmarkReservation SecondReservation { get; set; } = null!;

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

            #region Landmarks

            EiffelTower = new Landmark()
            {
                Id = 1,
                Name = "Eiffel Tower",
                Address = "Champ de Mars, 5 Av. Anatole France, 75007 Paris",
                Details = "Eiffel Tower's details",
                City_Id = 1,
                TicketPrice = 40m,
                ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1",
                IsActive = true
            };

            PlazaMayor = new Landmark()
            {
                Id = 2,
                Name = "Plaza Mayor",
                Address = "Calle Gerona 4, 28012 Madrid Spain",
                Details = "Plaza Mayor's details",
                City_Id = 2,
                ImageUrl = "data:image/jpeg;base64,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",
                IsActive = true
            };

            #endregion

            #region Reservations

            FirstReservation = new LandmarkReservation()
            {
                Id = "firstRes",
                CreatedOn = DateTime.Today,
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

            FirstReservationNotActive = new LandmarkReservation()
            {
                Id = "firstResNotActive",
                CreatedOn = DateTime.Today,
                User_Id = "firstUserId",
                FirstName = "First",
                LastName = "User",
                GroupCount = 1,
                Landmark_Id = 1,
                ReservationDate = DateTime.ParseExact("15/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ReservationTime = DateTime.ParseExact("14:00", "HH:mm", CultureInfo.InvariantCulture),
                TotalPrice = 40m,
                IsActive = true
            };

            FirstReservationNotActive = new LandmarkReservation()
            {
                Id = "firstResNotActiveProp",
                CreatedOn = DateTime.Today,
                User_Id = "firstUserId",
                FirstName = "First",
                LastName = "User",
                GroupCount = 1,
                Landmark_Id = 1,
                ReservationDate = DateTime.ParseExact("12/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ReservationTime = DateTime.ParseExact("14:00", "HH:mm", CultureInfo.InvariantCulture),
                TotalPrice = 40m,
                IsActive = false
            };

            SecondReservation = new LandmarkReservation()
            {
                Id = "secondRes",
                CreatedOn = DateTime.Today,
                User_Id = "secondUserId",
                FirstName = "Second",
                LastName = "User",
                GroupCount = 2,
                Landmark_Id = 1,
                ReservationDate = DateTime.ParseExact("25/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ReservationTime = DateTime.ParseExact("16:00", "HH:mm", CultureInfo.InvariantCulture),
                TotalPrice = 80m,
                IsActive = true
            };

            #endregion


            users = new List<ApplicationUser>()
            {
                FirstUser, SecondUser
            };

            countries = new List<Country>()
            {
                France, Spain
            };

            cities = new List<City>()
            {
                Paris, Madrid
            };

            landmarks = new List<Landmark>()
            {
                EiffelTower, PlazaMayor
            };

            reservations = new List<LandmarkReservation>()
            {
                FirstReservation, SecondReservation, FirstReservationNotActive,
                FirstReservationNotActiveProp
            };



            var dbContextOptions = new DbContextOptionsBuilder<BookingSystemDbContext>()
                    .UseInMemoryDatabase("BookingSystemInMemoryDb"
                        + Guid.NewGuid().ToString())
                    .Options;

            dbContext = new BookingSystemDbContext(dbContextOptions);

            dbContext.AddRangeAsync(users);
            dbContext.AddRangeAsync(countries);
            dbContext.AddRangeAsync(cities);
            dbContext.AddRangeAsync(landmarks);
            dbContext.AddRangeAsync(reservations);

            dbContext.SaveChangesAsync();

            repository = new Repository(dbContext);
            service = new LandmarkService(repository);
        }

        [TearDown]
        public async Task Teardown()
        {
            await dbContext.Database.EnsureDeletedAsync();
            await dbContext.DisposeAsync();
        }

        [Test]
        public async Task Test_AllAsync_ShouldReturnCorrectResult()
        {
            var result = await service.AllAsync(1);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            
            Assert.Multiple(() =>
            {
                Assert.That(result.First().Id, Is.EqualTo(1));
                Assert.That(result.First().Name, Is.EqualTo("Eiffel Tower"));
                Assert.That(result.First().City, Is.EqualTo("Paris"));
                Assert.That(result.First().ImageUrl, Is.EqualTo("https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1"));
                Assert.That(result.First().TicketPrice, Is.EqualTo(40m));
            });
        }
       
        [Test]
        public async Task Test_DetailsAsync_ShouldReturnCorrectResult()
        {
            var result = await service.DetailsAsync(1);

            Assert.That(result, Is.Not.Null);

            Assert.Multiple(() =>
            {
                Assert.That(result.Id, Is.EqualTo(1));
                Assert.That(result.Name, Is.EqualTo("Eiffel Tower"));
                Assert.That(result.City, Is.EqualTo("Paris"));
                Assert.That(result.ImageUrl, Is.EqualTo("https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1"));
                Assert.That(result.TicketPrice, Is.EqualTo(40m));
                Assert.That(result.Address, Is.EqualTo("Champ de Mars, 5 Av. Anatole France, 75007 Paris"));
                Assert.That(result.Details, Is.EqualTo("Eiffel Tower's details"));
            });

            try
            {
                _ = await service.DetailsAsync(999);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Landmark does not exist!"));
            }
        }

        [Test]
        public async Task Test_LandmarkExistsAsync_ShouldReturnCorrectResult()
        {
            var resultTrue = await service.LandmarkExistsAsync(1);
            var resultFalse = await service.LandmarkExistsAsync(999);

            Assert.That(resultTrue, Is.True);
            Assert.That(resultFalse, Is.False);
        }

        [Test]
        public async Task Test_LandmarkReservationExistsAsync_ShouldReturnCorrectResult()
        {
            var resultTrue = await service.LandmarkReservationExistsAsync("firstRes");
            var resultFalse = await service.LandmarkReservationExistsAsync("InvalidRes");

            Assert.That(resultTrue, Is.True);
            Assert.That(resultFalse, Is.False);
        }

        [Test]
        public async Task Test_ReservationExistsAsync_ShouldReturnCorrectResult()
        {
            var reservationDate = DateTime.ParseExact("23/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var reservationTime = DateTime.ParseExact("13:00", "HH:mm", CultureInfo.InvariantCulture);

            var resultTrue = await service.ReservationExistsAsync(1, "firstUserId", reservationDate, reservationTime);
            var resultFalse = await service.ReservationExistsAsync(2, "invalidUserId", reservationDate, reservationTime);

            Assert.That(resultTrue, Is.True);
            Assert.That(resultFalse, Is.False);
        }

        [Test]
        public async Task Test_GetForReserveAsync_ShouldReturnCorrectResult()
        {
            var result = await service.GetForReserveAsync(1);

            IEnumerable<string> expectedTimesResult = new HashSet<string>()
            {
                "10:00",
                "11:00",
                "12:00",
                "13:00",
                "14:00",
                "15:00",
                "16:00",
                "17:00"
            };

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Landmark_Id, Is.EqualTo(1)); 
            Assert.That(result.AvailableHours, Is.EqualTo(expectedTimesResult));

            try
            {
                _ = await service.GetForReserveAsync(2);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The landmark does not exist or you are not able to reserve it!"));
            }
        }

        [Test]
        public async Task Test_ReserveAsync_ShouldWorkCorrectly()
        {
            var model = new LandmarkReserveInputModel()
            {               
                FirstName = "Test",
                LastName = "Testov",
                ReservationDate = "24/04/2024",
                ReservationTime = "12:00",
                GroupCount = 1
            };

            var resCntBefore = await repository
                .AllReadOnly<LandmarkReservation>()
                .CountAsync();//2

            await service.ReserveAsync("firstUserId", 1, model);

            var resCntAfter= await repository
                .AllReadOnly<LandmarkReservation>()
                .CountAsync();//3

            Assert.That(resCntBefore, Is.EqualTo(3));
            Assert.That(resCntAfter, Is.EqualTo(4));

            try
            {
                var secondModel = new LandmarkReserveInputModel()
                {
                    FirstName = "Test",
                    LastName = "Testov",
                    ReservationDate = "24/04/2024",
                    ReservationTime = "12:00",
                    GroupCount = 1          
                };

                await service.ReserveAsync("firstUserId", 2, secondModel);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The landmark does not exist or you are not able to reserve it!"));
            }

            try
            {
                await service.ReserveAsync("firstUserId", 1, model);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("You have already a reservation on this landmark!"));
            }
        }

        [Test]
        public void Test_GetAvailableHours_ShouldReturnCorrectResult()
        {
            var result = service.GetAvailableHours();

            IEnumerable<string> expectedResult = new HashSet<string>()
            {
                "10:00",
                "11:00",
                "12:00",
                "13:00",
                "14:00",
                "15:00",
                "16:00",
                "17:00"
            };

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public async Task Test_AllReservationsAsync_ShouldReturnCorrectResult()
        {
            var resCntBefore = await repository.AllReadOnly<LandmarkReservation>()
                .Where(r => r.IsActive == true)
                .CountAsync();//3

            var result = await service.AllReservationsAsync("firstUserId");

            var resCntAfter = await repository.AllReadOnly<LandmarkReservation>()
                .Where(r => r.IsActive == true)
                .CountAsync();//2

            Assert.That(resCntBefore, Is.EqualTo(2));
            Assert.That(resCntAfter, Is.EqualTo(2));
            
            Assert.Multiple(() =>
            {
                Assert.That(result.First().Id, Is.EqualTo("firstRes"));
                Assert.That(result.First().Landmark_Id, Is.EqualTo(1));
                Assert.That(result.First().Name, Is.EqualTo("Eiffel Tower"));
                Assert.That(result.First().FirstName, Is.EqualTo("First"));
                Assert.That(result.First().LastName, Is.EqualTo("User"));
                Assert.That(result.First().GroupCount, Is.EqualTo(1));
                Assert.That(result.First().LandmarkImageUrl, Is.EqualTo("https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1"));
                Assert.That(result.First().ReservationDate, Is.EqualTo("23/04/2024"));
                Assert.That(result.First().ReservationTime, Is.EqualTo("13:00"));
                Assert.That(result.First().TotalPrice, Is.EqualTo(40m));
                Assert.That(result.First().City, Is.EqualTo("Paris"));
            });
        }

        [Test]
        public async Task Test_CancellReservationAsync_ShouldWorkCorrectly()
        {
            var resCntBefore = await repository.AllReadOnly<LandmarkReservation>().CountAsync();//3

            await service.CancellReservationAsync("firstUserId", "firstRes");

            var resCntAfter = await repository.AllReadOnly<LandmarkReservation>().CountAsync();//2

            Assert.That(resCntBefore, Is.EqualTo(3));
            Assert.That(resCntAfter, Is.EqualTo(2));

            try
            {
                await service.CancellReservationAsync("firstUserId", "invalidRes");
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current reservation does not exist"));
            }

            try
            {
                await service.CancellReservationAsync("firstUserId", "secondRes");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }

            try
            {
                await service.CancellReservationAsync("firstUserId", "firstResNotActiveProp");
            }
            catch (NoLongerActiveReservationException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The reservation is no longer available!"));
            }
        }

        [Test]
        public async Task Test_GetReservationForEditAsync_ShouldWorkCorrectly()
        {
            var result = await service.GetReservationForEditAsync("firstUserId", "firstRes");

            Assert.That(result, Is.Not.Null);
            
            Assert.Multiple(() =>
            {
                Assert.That(result.Id, Is.EqualTo("firstRes"));
                Assert.That(result.FirstName, Is.EqualTo("First"));
                Assert.That(result.LastName, Is.EqualTo("User"));
            });

            try
            {
                _ = await service.GetReservationForEditAsync("firstUserId", "invalidRes");
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current reservation does not exist!"));
            }
            
            try
            {
                _ = await service.GetReservationForEditAsync("invalidUserId", "firstRes");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }

            try
            {
                await service.GetReservationForEditAsync("firstUserId", "firstResNotActiveProp");
            }
            catch (NoLongerActiveReservationException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The reservation is no longer available!"));
            }
        }

        [Test]
        public async Task Test_EditReservationAsync_ShouldWorkCorrectly()
        {
            var model = new LandmarkReservationEditInputModel()
            {
                Id = "firstRes",
                FirstName = "First",
                LastName = "User"
            };

            await service.EditReservationAsync(model, "firstUserId");

            var res = await repository.GetByIdAsync<LandmarkReservation>("firstRes");

            Assert.That(res, Is.Not.Null);

            Assert.Multiple(() =>
            {
                Assert.That(res.FirstName, Is.EqualTo("First"));
                Assert.That(res.LastName, Is.EqualTo("User"));
            });

            try
            {
                var tryModel = new LandmarkReservationEditInputModel()
                {
                    Id = "invalidRes",
                    FirstName = "First",
                    LastName = "User"
                };

                await service.EditReservationAsync(tryModel, "firstUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current reservation does not exist!"));
            }

            try
            {
                var tryModel = new LandmarkReservationEditInputModel()
                {
                    Id = "firstRes",
                    FirstName = "First",
                    LastName = "User"
                };

                await service.EditReservationAsync(tryModel, "secondUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }

            try
            {
                var tryModel = new LandmarkReservationEditInputModel()
                {
                    Id = "firstResNotActiveProp",
                    FirstName = "First",
                    LastName = "User"
                };

                await service.EditReservationAsync(tryModel, "firstUserId");
            }
            catch (NoLongerActiveReservationException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The reservation is no longer available!"));
            }
        }

        [Test]
        public async Task Test_AllLandmarksForAdminAsync_FiltersCity()
        {
            var firstResult = await service.AllLandmarksForAdminAsync("Paris");
            var secondResult = await service.AllLandmarksForAdminAsync("NotAnExistingCity");

            Assert.That(firstResult.Landmarks.First().Id == 1, Is.True);
            Assert.That(secondResult.Landmarks, Is.Empty);
        }

        [Test]
        public async Task Test_AllLandmarksForAdminAsync_FiltersBySearchTerm()
        {
            var firstResult = await service.AllLandmarksForAdminAsync(null, "Eiffel Tower");
            var secondResult = await service.AllLandmarksForAdminAsync(null, "NotAnExistingLandmarkName");

            Assert.IsTrue(firstResult.Landmarks.First().Id == 1);
            Assert.IsEmpty(secondResult.Landmarks);
        }

        [Test]
        public async Task Test_AllLandmarksForAdminAsync_SortsByPriceAscending()
        {
            var landmarksPriceAscSorting = await service.AllLandmarksForAdminAsync(null, null, LandmarkSorting.PriceAscending);

            var landmarkIds = new List<int>()
            {
                landmarksPriceAscSorting.Landmarks.First().Id,
                landmarksPriceAscSorting.Landmarks.Last().Id
            };

            Assert.IsNotNull(landmarksPriceAscSorting.Landmarks);
            Assert.That(landmarksPriceAscSorting.Landmarks.Count(), Is.EqualTo(2));
            Assert.That(landmarkIds, Is.EqualTo(new List<int>() { 2, 1 }));
        }

        [Test]
        public async Task Test_AllLandmarksForAdminAsync_SortsByPriceDescending()
        {
            var landmarksPriceDescSorting = await service.AllLandmarksForAdminAsync(null, null, LandmarkSorting.PriceDescending);
            var landmarkIds = new List<int>()
            {
                landmarksPriceDescSorting.Landmarks.First().Id,
                landmarksPriceDescSorting.Landmarks.Last().Id
            };

            Assert.IsNotNull(landmarksPriceDescSorting.Landmarks);
            Assert.That(landmarksPriceDescSorting.Landmarks.Count(), Is.EqualTo(2));
            Assert.That(landmarkIds, Is.EqualTo(new List<int>() { 1, 2 }));
        }

        [Test]
        public async Task Test_AllLandmarksForAdminAsync_SortsByIdentifierAscending()
        {
            var landmarksPriceDescSorting = await service.AllLandmarksForAdminAsync(null, null, LandmarkSorting.IdentifierAscending);
            var landmarkIds = new List<int>()
            {
                landmarksPriceDescSorting.Landmarks.First().Id,
                landmarksPriceDescSorting.Landmarks.Last().Id
            };

            Assert.IsNotNull(landmarksPriceDescSorting.Landmarks);
            Assert.That(landmarksPriceDescSorting.Landmarks.Count(), Is.EqualTo(2));
            Assert.That(landmarkIds, Is.EqualTo(new List<int>() { 1, 2 }));
        }

        [Test]
        public async Task Test_GetForEditAsync_ShouldWorkCorrectly()
        {
            var result = await service.GetForEditAsync(1);

            Assert.That(result, Is.Not.Null);
            
            Assert.Multiple(() =>
            {
                Assert.That(result.Name, Is.EqualTo("Eiffel Tower"));
                Assert.That(result.Address, Is.EqualTo("Champ de Mars, 5 Av. Anatole France, 75007 Paris"));
                Assert.That(result.Details, Is.EqualTo("Eiffel Tower's details"));
                Assert.That(result.TicketPrice, Is.EqualTo(40m));
                Assert.That(result.ImageUrl, Is.EqualTo("https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1"));
            });

            try
            {
                _ = await service.GetForEditAsync(999);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The landmark was not found!"));
            }
        }

        [Test]
        public async Task Test_EditAsync_ShouldWorkCorrectly()
        {
            var model = new LandmarkEditInputModel()
            {
                Id = 1,
                Name = "Eiffel Tower",
                Details = "Eiffel Tower's details",
                TicketPrice = 40m,
                ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1"
            };

            await service.EditAsync(model);

            var landmark = await repository.GetByIdAsync<Landmark>(model.Id);

            Assert.That(landmark, Is.Not.Null);
            
            Assert.Multiple(() =>
            {
                Assert.That(landmark.Id, Is.EqualTo(model.Id));
                Assert.That(landmark.Name, Is.EqualTo(model.Name));
                Assert.That(landmark.Details, Is.EqualTo(model.Details));
                Assert.That(landmark.TicketPrice, Is.EqualTo(model.TicketPrice));
                Assert.That(landmark.ImageUrl, Is.EqualTo(model.ImageUrl));
            });

            try
            {
                var tryModel = new LandmarkEditInputModel()
                {
                    Id = 999,
                    Name = "Eiffel Tower",
                    Details = "Eiffel Tower's details",
                    TicketPrice = 40m,
                    ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1"
                };

                await service.EditAsync(tryModel);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The landmark was not found!"));
            }
        }

        [Test]
        public async Task Test_DeleteAsync_ShouldWorkCorrectly()
        {
            var landmarkCntBefore = await repository.AllReadOnly<Landmark>().CountAsync();//2
            
            var landmarkResCntBefore = await repository.AllReadOnly<LandmarkReservation>()
                .Where(lr => lr.Landmark_Id == 1)
                .CountAsync();//4

            await service.DeleteAsync(1);

            var landmarkCntAfter = await repository.AllReadOnly<Landmark>().CountAsync();//1
            
            var landmarkResCntAfter = await repository.AllReadOnly<LandmarkReservation>()
                .Where(lr => lr.Landmark_Id == 1)
                .CountAsync();//0
            
            Assert.Multiple(() =>
            {
                Assert.That(landmarkCntBefore, Is.EqualTo(2));
                Assert.That(landmarkCntAfter, Is.EqualTo(1));
                Assert.That(landmarkResCntBefore, Is.EqualTo(3));
                Assert.That(landmarkResCntAfter, Is.EqualTo(0));
            });

            try
            {
                await service.DeleteAsync(999);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The landmark was not found!"));
            }
        }

        [Test]
        public async Task Test_GetForAddAsync_ShouldWorkCorrectly()
        {
            var result = await service.GetForAddAsync();

            Assert.That(result.Cities.Count(), Is.EqualTo(2));
            
            Assert.That(result.Cities.First().Id, Is.EqualTo(1));
            Assert.That(result.Cities.First().Name, Is.EqualTo("Paris"));
            Assert.That(result.Cities.Skip(1).First().Id, Is.EqualTo(2));
            Assert.That(result.Cities.Skip(1).First().Name, Is.EqualTo("Madrid"));
            
        }

        [Test]
        public async Task Test_AddAsync_ShouldWorkCorrectly()
        {
            var model = new LandmarkAddInputModel()
            {
                Id = 3,
                Name = "Test",
                Address = "somewhere",
                Details = "Test's details",
                CityId = 1,
                ImageUrl = "https://cdn.britannica.com/10/152310-050-5A09D74A/Sand-dunes-Sahara-Morocco-Merzouga.jpg",
                TicketPrice = 30m
            };

            await service.AddAsync(model);

            var landmark = await repository.GetByIdAsync<Landmark>(3);
            
            Assert.That(landmark, Is.Not.Null);
            
            Assert.Multiple(() =>
            {
                Assert.That(landmark.Id, Is.EqualTo(3));
                Assert.That(landmark.Name, Is.EqualTo("Test"));
                Assert.That(landmark.Address, Is.EqualTo("somewhere"));
                Assert.That(landmark.Details, Is.EqualTo("Test's details"));
                Assert.That(landmark.City_Id, Is.EqualTo(1));
                Assert.That(landmark.ImageUrl, Is.EqualTo("https://cdn.britannica.com/10/152310-050-5A09D74A/Sand-dunes-Sahara-Morocco-Merzouga.jpg"));
                Assert.That(landmark.TicketPrice, Is.EqualTo(30m));
            });
        }

        [Test]
        public async Task Test_GetAllCitiesAsync_ShouldWorkCorrectly()
        {
            var result = await service.GetAllCitiesAsync();

            Assert.That(result, Is.Not.Null);
            
            Assert.Multiple(() =>
            {
                Assert.That(result.First().Id, Is.EqualTo(1));
                Assert.That(result.First().Name, Is.EqualTo("Paris"));
                Assert.That(result.Skip(1).First().Id, Is.EqualTo(2));
                Assert.That(result.Skip(1).First().Name, Is.EqualTo("Madrid"));
            });
        }
    } 
}
