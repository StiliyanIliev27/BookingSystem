using BookingSystem.Core.Contracts;
using BookingSystem.Core.Exceptions;
using BookingSystem.Core.Models.Hotel;
using BookingSystem.Core.Models.User;
using BookingSystem.Core.Services;
using BookingSystem.Infrastructure.Common;
using BookingSystem.Infrastructure.Data;
using BookingSystem.Infrastructure.Data.Enums;
using BookingSystem.Infrastructure.Data.Models.Hotels;
using BookingSystem.Infrastructure.Data.Models.Location;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Hotel;

namespace BookingSystem.Tests.UnitTests
{
    [TestFixture]
    public class HotelServiceTests
    {
        private BookingSystemDbContext dbContext;

        private IEnumerable<HotelReservation> reservations;
        private IEnumerable<Hotel> hotels;
        private IEnumerable<Room> rooms;
        private IEnumerable<City> cities;
        private IEnumerable<Continent> continents;
        private IEnumerable<Country> countries;
        private IEnumerable<Language> languages;
        private IEnumerable<ApplicationUser> users;

        private IRepository repository;
        private IHotelService service;

        #region Users

        private ApplicationUser FirstUser { get; set; } = null!;
        private ApplicationUser SecondUser { get; set; } = null!;

        #endregion


        #region Reservations

        private HotelReservation FirstUserReservation { get; set; } = null!;

        private HotelReservation FirstUserReservationLate { get; set; } = null!;

        private HotelReservation FirstUserReservationFourRooms { get; set; } = null!;
        
        private HotelReservation SecondUserReservation { get; set; } = null!;

        private HotelReservation SecondUserReservationInvalidRoom { get; set; } = null!;

        private HotelReservation SecondUserReservationZeroRooms { get; set; } = null!;
       
        #endregion


        #region Languages
        private Language French { get; set; } = null!;
        private Language Spanish { get; set; } = null!;
        private Language English { get; set; } = null!;
        private Language Japanese { get; set; } = null!;

        #endregion


        #region Continents
        private Continent Europe { get; set; } = null!;
        private Continent NorthAmerica { get; set; } = null!;
        private Continent Asia { get; set; } = null!;

        #endregion


        #region Countries
        private Country France { get; set; } = null!;
        private Country Spain { get; set; } = null!;
        private Country UnitedStates { get; set; } = null!;
        private Country Japan { get; set; } = null!;

        #endregion


        #region Cities
        private City Paris { get; set; } = null!;
        private City Madrid { get; set; } = null!;
        private City NewYork { get; set; } = null!;
        private City Tokyo { get; set; } = null!;

        #endregion


        #region Hotels
        private Hotel IbisParis { get; set; } = null!;
        private Hotel CataloniaPuerta { get; set; } = null!;
        private Hotel HiltonGarden { get; set; } = null!;
        private Hotel SotetsuFresa { get; set; } = null!;

        #endregion


        #region Rooms
        private Room IbisParisRoomDouble { get; set; } = null!;
        private Room IbisParisRoomTriple { get; set; } = null!;
        private Room CataloniaPuertaRoomSingle { get; set; } = null!;
        private Room CataloniaPuertaRoomDoubleFour { get; set; } = null!;
        private Room HiltonGardenRoomTriple { get; set; } = null!;
        private Room SotetsuFresaRoomSingle { get; set; } = null!;

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


            #region Languages

            Spanish = new Language
            {
                Id = 1,
                Name = "Spanish"
            };

            English = new Language
            {
                Id = 2,
                Name = "English"
            };

            Japanese = new Language
            {
                Id = 3,
                Name = "Japanese"
            };

            French = new Language
            {
                Id = 4,
                Name = "French"
            };

            #endregion


            #region Continents

            Europe = new Continent()
            {
                Id = 1,
                Name = "Europe",
            };

            NorthAmerica = new Continent()
            {
                Id = 2,
                Name = "NorthAmerica",
            };

            Asia = new Continent()
            {
                Id = 3,
                Name = "Asia",
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
                Details = "France, located in Western Europe, is renowned for its rich history, culture, and culinary excellence. Its capital, Paris, is home to iconic landmarks such as the Eiffel Tower and the Louvre Museum. France is known for its contributions to art, literature, and philosophy, with figures like Voltaire, Rousseau, and Monet shaping its cultural landscape. The country boasts diverse landscapes, from the picturesque vineyards of Bordeaux to the stunning beaches of the French Riviera. Additionally, France is a founding member of the European Union and plays a significant role in global diplomacy and trade.",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/800px-Flag_of_France.svg.png",
                Language_Id = 4,
            };

            Spain = new Country()
            {
                Id = 2,
                Name = "Spain",
                Capital = "Madrid",
                Population = 47_473_373,
                Continent_Id = 1,
                Details = "Spain, situated in southwestern Europe, is celebrated for its vibrant culture, stunning architecture, and lively festivals. The capital, Madrid, is famous for its art museums like the Prado and Reina Sofía, while Barcelona captivates with its unique blend of Catalan identity, exemplified by architectural masterpieces like the Sagrada Família and Park Güell designed by Antoni Gaudí. Spain's rich history is evident in its numerous UNESCO World Heritage Sites, including the Alhambra in Granada and the historic city of Toledo. Its culinary scene is diverse and flavorful, with tapas and paella being among its most iconic dishes. Additionally, Spain is known for its passion for soccer, with clubs like FC Barcelona and Real Madrid enjoying worldwide recognition.",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://cdn.britannica.com/36/4336-050-056AC114/Flag-Spain.jpg",
                Language_Id = 1
            };

            UnitedStates = new Country()
            {
                Id = 3,
                Name = "United States",
                Capital = "Washington, D.C.",
                Population = 341_223_461,
                Continent_Id = 2,
                Details = "The United States, located in North America, is the world's third-largest country by land area and population. It is a diverse nation, known for its cultural melting pot and vast landscapes, ranging from the bustling metropolises of New York City and Los Angeles to the stunning natural wonders of the Grand Canyon and Yellowstone National Park. The U.S. is a global economic powerhouse, with a highly developed economy driven by innovation, technology, and entrepreneurship. It has a rich history shaped by diverse immigrant communities, pivotal events such as the American Revolution and Civil Rights Movement, and iconic figures like Abraham Lincoln and Martin Luther King Jr. The country's political system is characterized by a federal republic with a strong emphasis on individual freedoms and democratic principles.",
                CurrencyCode = "USD",
                FlagImageUrl = "https://cdn.britannica.com/33/4833-004-828A9A84/Flag-United-States-of-America.jpg",
                Language_Id = 2
            };

            Japan = new Country()
            {
                Id = 4,
                Name = "Japan",
                Capital = "Tokyo",
                Population = 122_844_590,
                Continent_Id = 3,
                Details = "Japan, an island nation located in East Asia, is known for its unique blend of ancient traditions and cutting-edge modernity. Its capital, Tokyo, is a bustling metropolis with towering skyscrapers, high-tech innovations, and vibrant street life. Japan's cultural heritage is rich and diverse, with landmarks such as Kyoto's temples and gardens, Hiroshima's Peace Memorial Park, and the iconic Mount Fuji symbolizing its spiritual and historical significance. Japanese cuisine, including sushi, tempura, and ramen, is celebrated worldwide for its freshness, quality, and meticulous preparation. The country is renowned for its contributions to technology, manufacturing, and pop culture, with brands like Sony, Toyota, and Nintendo shaping global trends. Japan's society is characterized by a strong sense of community, respect for tradition, and emphasis on harmony and order. Despite its densely populated cities, Japan boasts serene natural landscapes, including cherry blossom forests, hot springs, and scenic coastal regions. Overall, Japan offers visitors a captivating blend of tradition and innovation, making it a fascinating destination for exploration and discovery.",
                CurrencyCode = "JPY",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Flag_of_Japan.svg/1200px-Flag_of_Japan.svg.png",
                Language_Id = 3
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

            NewYork = new City()
            {
                Id = 3,
                Name = "New York",
                Population = 19_034_000,
                Area = "783,8 km²",
                Details = "New York City, often referred to as the \"Big Apple,\" is a bustling metropolis known for its iconic skyline, diverse culture, and vibrant energy. Visitors can explore world-famous landmarks such as the Statue of Liberty, Times Square, and Central Park, or immerse themselves in the city's rich cultural scene by visiting museums like the Metropolitan Museum of Art or catching a Broadway show. With its endless array of dining options, shopping districts, and neighborhoods to explore, New York City offers an unforgettable experience for travelers from around the world.",
                Country_Id = 3,
                ImageUrl = "https://cdn.britannica.com/61/93061-050-99147DCE/Statue-of-Liberty-Island-New-York-Bay.jpg"
            };

            Tokyo = new City()
            {
                Id = 4,
                Name = "Tokyo",
                Population = 37_115_035,
                Area = "2 194 km²",
                Details = "Tokyo, the capital of Japan, is a bustling metropolis where tradition meets innovation. Visitors can explore the city's iconic landmarks such as the historic Senso-ji Temple in Asakusa, the futuristic skyscrapers of Shinjuku, and the serene gardens of the Imperial Palace. With its vibrant neighborhoods, bustling street markets, and world-renowned cuisine ranging from sushi to ramen, Tokyo offers a captivating blend of old-world charm and modern excitement for travelers to experience and enjoy.",
                Country_Id = 4,
                ImageUrl = "https://facts.net/wp-content/uploads/2023/06/45-facts-about-tokyo-1688094762.jpeg"
            };

            #endregion


            #region Hotels

            IbisParis = new Hotel()
            {
                Id = 1,
                Name = "Ibis Paris Gare Montparnasse Catalogne",
                Address = "11 Rue Du Texel, 14th arr., 75014",
                City_Id = 1,
                StarRate = 3,
                Details = "Ibis Paris Details",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1",
                CheckIn = DateTime.ParseExact("16:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = true,
                IsActive = true
            };

            CataloniaPuerta = new Hotel()
            {
                Id = 2,
                Name = "Catalonia Puerta del Sol",
                Address = "Atocha, 23, Centro, 28012",
                City_Id = 2,
                StarRate = 4,
                Details = "Catalonia Puerta del Sol is set in a magnificent 18th-century building in the historic centre of Madrid, a few minutes from Puerta del Sol. It offers free Wi-Fi throughout the hotel.\r\n\r\nThe hotel is just 50 metres from Puerta del Sol, Madrid's main square and from main tapas restaurants. You can walk to Madrid's famous Art Triangle in 15 minutes. Atocha Train Station is 1 km away.\r\n\r\nThe air-conditioned rooms feature parquet floors and smart décor. ach one has flat-screen satellite smart TV with Chromecast app, a private bathroom and a minibar.\r\n\r\nThe Puerta del Sol's restaurant serves a buffet breakfast each morning, and available until 12:00 at weekends. There is also a bar with a roofed terrace, El Patio, where you can get a snack or a drink. There is also a patio with crystal domes.\r\n\r\nAll hotel rooms have smart TVs, which are equipped with Chromecast app.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/159811810.jpg?k=f40061a37ae157fd42e62ece3bd402bca73e10528b6160719bb103c4ab69be25&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = true,
                IsActive = true
            };

            HiltonGarden = new Hotel()
            {
                Id = 3,
                Name = "Hilton Garden Inn New York Times Square South",
                Address = "326 West 37th Street , Hell's Kitchen, New York, NY 10018",
                City_Id = 3,
                StarRate = 3,
                Details = "The Hilton Garden Inn New York Times Square South is located less than 1 km away from Jacob K. Javits Convention Centre and 1.3 km from Times Square. Complimentary WiFi is provided.\r\n\r\nAll rooms at this property are fitted with a flat-screen TV, coffee maker, microwave and mini-refrigerator. A desk with an ergonomic chair are also provided.\r\n\r\nGuests will have access to free coffee in the morning and a fitness centre. The 24-hour Garden Market will carry snacks and sundry items.\r\n\r\nLaGuardia Airport is 18.3 km from the property while JFK Airport is 27 km from Hilton Garden Inn New York Times Square South. The Empire State Building is 1.6 km away.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/485847819.jpg?k=c8a7d6fe3756b65ddf1e88e4ece012a9e377f4da075e7f6c65d0064bee9dab61&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = true,
                IsActive = true
            };

            SotetsuFresa = new Hotel()
            {
                Id = 4,
                Name = "Sotetsu Fresa Inn Tokyo Tamachi",
                Address = "108-0023 Tokyo-to, Minato-ku Shibaura 3-14-21",
                City_Id = 4,
                StarRate = 3,
                Details = "A 5-minute walk from JR Tamachi Train Station and Mita Subway Station, Sotetsu Fresa Inn Tokyo Tamachi offers simple modern accommodations with free wired internet access. Guests can request relaxing massages for an extra cost and store luggage for free at the 24-hour front desk. Tokyo Tamachi Sotetsu Fresa Inn is a 20-minute walk from Shiba Park and a 10-minute train ride from JR Shinagawa Train Station. The Imperial Palace is a 15-minute drive away.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/124760078.jpg?k=5b64947a1714bd3adbdebd6bff329c9a7debd693c4f02bb201390dc3988d4b63&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("11:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true,
            };

            #endregion


            #region Rooms

            IbisParisRoomDouble = new Room()
            {
                Id = 1,
                Type = RoomType.Double,
                Hotel_Id = 1,
                PricePerNight = 302m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            IbisParisRoomTriple = new Room()
            {
                Id = 4,
                Type = RoomType.Double,
                Hotel_Id = 1,
                PricePerNight = 302m,
                WiFi = true,
                IsActive = true,
                Count = 0
            };

            CataloniaPuertaRoomSingle = new Room()
            {
                Id = 2,
                Type = RoomType.Single,
                Hotel_Id = 2,
                PricePerNight = 201m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            CataloniaPuertaRoomDoubleFour = new Room()
            {
                Id = 6,
                Type = RoomType.Single,
                Hotel_Id = 2,
                PricePerNight = 201m,
                WiFi = true,
                IsActive = true,
                Count = 4
            };

            HiltonGardenRoomTriple = new Room()
            {
                Id = 3,
                Type = RoomType.Triple,
                Hotel_Id = 3,
                PricePerNight = 238m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            SotetsuFresaRoomSingle = new Room()
            {
                Id = 5,
                Type = RoomType.Single,
                Hotel_Id = 4,
                PricePerNight = 223m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            #endregion


            #region Reservations

            FirstUserReservation = new HotelReservation()
            {
                User_Id = "firstUserId",
                StartDate = DateTime.ParseExact("24/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("26/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 1,
                CreatedOn = DateTime.Now,
                FirstName = "First",
                LastName = "User",
                Id = "firstRes",
                Price = 604m,
                IsActive = true,
                Room_Id = 1
            };

            FirstUserReservationLate = new HotelReservation()
            {               
                User_Id = "firstUserId",
                StartDate = DateTime.ParseExact("12/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("13/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 1,
                CreatedOn = DateTime.Now,
                FirstName = "First",
                LastName = "User",
                Id = "firstResLate",
                Price = 604m,
                IsActive = false,
                Room_Id = 1
            };

            FirstUserReservationFourRooms = new HotelReservation()
            {
                User_Id = "firstUserId",
                StartDate = DateTime.ParseExact("22/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("27/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 1,
                CreatedOn = DateTime.Now,
                FirstName = "First",
                LastName = "User",
                Id = "firstResFourRooms",
                Price = 604m,
                IsActive = false,
                Room_Id = 6
            };

            SecondUserReservation = new HotelReservation()
            {
                User_Id = "secondUserId",
                StartDate = DateTime.ParseExact("23/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("24/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 2,
                CreatedOn = DateTime.Now,
                FirstName = "Second",
                LastName = "User",
                Id = "secondRes",
                Price = 201m,
                IsActive = true,
                Room_Id = 2
            };

            SecondUserReservationInvalidRoom = new HotelReservation()
            {
                User_Id = "secondUserId",
                StartDate = DateTime.ParseExact("25/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("26/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 2,
                CreatedOn = DateTime.Now,
                FirstName = "Second",
                LastName = "User",
                Id = "secondResInvRoom",
                Price = 201m,
                IsActive = true,
                Room_Id = 5
            };

            SecondUserReservationZeroRooms = new HotelReservation()
            {
                User_Id = "secondUserId",
                StartDate = DateTime.ParseExact("05/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("07/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 2,
                CreatedOn = DateTime.Now,
                FirstName = "Second",
                LastName = "User",
                Id = "secondResZeroRooms",
                Price = 201m,
                IsActive = true,
                Room_Id = 4
            };

            #endregion


            #region Collections

            languages = new List<Language>()
            {
                English, Spanish, French, Japanese
            };

            continents = new List<Continent>()
            {
                Europe, Asia, NorthAmerica
            };

            countries = new List<Country>()
            {
                France, Spain, Japan, UnitedStates
            };

            cities = new List<City>()
            {
                Paris, Madrid, Tokyo, NewYork
            };

            hotels = new List<Hotel>()
            {
                IbisParis, CataloniaPuerta, HiltonGarden, SotetsuFresa
            };

            rooms = new List<Room>()
            {
                IbisParisRoomDouble, IbisParisRoomTriple, CataloniaPuertaRoomSingle, CataloniaPuertaRoomDoubleFour, HiltonGardenRoomTriple, SotetsuFresaRoomSingle
            };

            reservations = new List<HotelReservation>()
            {
                FirstUserReservation, SecondUserReservation, FirstUserReservationFourRooms, FirstUserReservationLate, SecondUserReservationInvalidRoom, SecondUserReservationZeroRooms
            };

            users = new List<ApplicationUser>() 
            { 
                FirstUser, 
                SecondUser 
            };

            #endregion


            var dbContextOptions = new DbContextOptionsBuilder<BookingSystemDbContext>()
                    .UseInMemoryDatabase("BookingSystemInMemoryDb"
                        + Guid.NewGuid().ToString())
                    .Options;

            dbContext = new BookingSystemDbContext(dbContextOptions);

            dbContext.AddRangeAsync(languages);
            dbContext.AddRangeAsync(continents);
            dbContext.AddRangeAsync(countries);
            dbContext.AddRangeAsync(cities);
            dbContext.AddRangeAsync(hotels);
            dbContext.AddRangeAsync(rooms);
            dbContext.AddRangeAsync(reservations);
            dbContext.AddRangeAsync(users);
            dbContext.SaveChangesAsync();

            repository = new Repository(dbContext);
            service = new HotelService(repository);
        }

        [TearDown]
        public async Task Teardown()
        {
            await this.dbContext.Database.EnsureDeletedAsync();
            await this.dbContext.DisposeAsync();
        }

        [Test]
        public async Task Test_AllAsync_FiltersByCity()
        {
            var firstResult = await service.AllAsync("Paris");
            var secondResult = await service.AllAsync("NotAnExistingCity");

            Assert.That(firstResult.TotalHotelsCount, Is.EqualTo(1));
            Assert.IsTrue(firstResult.Hotels.First().Id == 1);

            Assert.That(secondResult.TotalHotelsCount, Is.EqualTo(0));
            Assert.IsEmpty(secondResult.Hotels);
        }

        [Test]
        public async Task Test_AllAsync_FiltersBySearchTerm()
        {
            var firstResult = await service.AllAsync(null, "Ibis Paris Gare Montparnasse Catalogne");
            var secondResult = await service.AllAsync(null, "NotAnExistingHotelName");

            Assert.That(firstResult.TotalHotelsCount, Is.EqualTo(1));
            Assert.IsTrue(firstResult.Hotels.First().Id == 1);

            Assert.That(secondResult.TotalHotelsCount, Is.EqualTo(0));
            Assert.IsEmpty(secondResult.Hotels);
        }

        [Test]
        public async Task Test_AllAsync_SortsByNewest()
        {
            var hotelsNewestSorting = await service.AllAsync();
            var hotelIds = new List<int>()
            {
                hotelsNewestSorting.Hotels.First().Id,
                hotelsNewestSorting.Hotels.Skip(1).First().Id,
                hotelsNewestSorting.Hotels.Skip(2).First().Id,
                hotelsNewestSorting.Hotels.Last().Id
            };

            Assert.IsNotNull(hotelsNewestSorting.Hotels);
            Assert.That(hotelsNewestSorting.Hotels.Count(), Is.EqualTo(4));
            Assert.That(hotelIds, Is.EqualTo(new List<int>() { 4, 3, 2, 1 }));
        }

        [Test]
        public async Task Test_AllAsync_SortsByOldest()
        {
            var hotelsOldestSorting = await service.AllAsync(null, null, Core.Enumerations.HotelSorting.Oldest);
            var hotelIds = new List<int>()
            {
                hotelsOldestSorting.Hotels.First().Id,
                hotelsOldestSorting.Hotels.Skip(1).First().Id,
                hotelsOldestSorting.Hotels.Skip(2).First().Id,
                hotelsOldestSorting.Hotels.Last().Id
            };

            Assert.IsNotNull(hotelsOldestSorting.Hotels);
            Assert.That(hotelsOldestSorting.Hotels.Count(), Is.EqualTo(4));
            Assert.That(hotelIds, Is.EqualTo(new List<int>() { 1, 2, 3, 4 }));
        }

        [Test]
        public async Task Test_AllAsync_SortsByPriceAscending()
        {
            var hotelsPriceAscSorting = await service.AllAsync(null, null, Core.Enumerations.HotelSorting.PriceAscending);
            var hotelIds = new List<int>()
            {
                hotelsPriceAscSorting.Hotels.First().Id,
                hotelsPriceAscSorting.Hotels.Skip(1).First().Id,
                hotelsPriceAscSorting.Hotels.Skip(2).First().Id,
                hotelsPriceAscSorting.Hotels.Last().Id
            };

            Assert.IsNotNull(hotelsPriceAscSorting.Hotels);
            Assert.That(hotelsPriceAscSorting.Hotels.Count(), Is.EqualTo(4));
            Assert.That(hotelIds, Is.EqualTo(new List<int>() { 2, 4, 3, 1 }));
        }

        [Test]
        public async Task Test_AllAsync_SortsByPriceDescending()
        {
            var hotelsPriceDescSorting = await service.AllAsync(null, null, Core.Enumerations.HotelSorting.PriceDescending);
            var hotelIds = new List<int>()
            {
                hotelsPriceDescSorting.Hotels.First().Id,
                hotelsPriceDescSorting.Hotels.Skip(1).First().Id,
                hotelsPriceDescSorting.Hotels.Skip(2).First().Id,
                hotelsPriceDescSorting.Hotels.Last().Id
            };

            Assert.IsNotNull(hotelsPriceDescSorting.Hotels);
            Assert.That(hotelsPriceDescSorting.Hotels.Count(), Is.EqualTo(4));
            Assert.That(hotelIds, Is.EqualTo(new List<int>() { 1, 3, 4, 2 }));
        }

        [Test]
        public async Task Test_GetRoomsAsync_ShouldReturnCorrectResult()
        {
            var result = await service.GetRoomsAsync(1);

            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.First().Id, Is.EqualTo(1));
            Assert.That(result.First().Hotel_Id, Is.EqualTo(1));
            Assert.That(result.First().Count, Is.EqualTo(5));
            Assert.That(result.First().PricePerNight, Is.EqualTo(302m));
            Assert.That(result.First().WiFi, Is.EqualTo(true));
            Assert.That(result.First().IsActive, Is.EqualTo(true));
            Assert.That(result.First().Type, Is.EqualTo(RoomType.Double));
        }

        [Test]
        public async Task Test_GetRoomAsync_ShouldReturnCorrectResult()
        {
            var result = await service.GetRoomAsync(1);

            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.Hotel_Id, Is.EqualTo(1));
            Assert.That(result.Count, Is.EqualTo(5));
            Assert.That(result.PricePerNight, Is.EqualTo(302m));
            Assert.That(result.WiFi, Is.EqualTo(true));
            Assert.That(result.IsActive, Is.EqualTo(true));
            Assert.That(result.Type, Is.EqualTo(RoomType.Double));
        }

        [Test]
        public async Task Test_GetHotelsCountAsync_ShouldReturnCorrectResult()
        {
            var result = await service.GetHotelsCountAsync();

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public async Task Test_HotelExistsAsync_ShouldReturnTrueIfExists()
        {
            var result = await service.HotelExistsAsync(1);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public async Task Test_HotelExistsAsync_ShouldReturnFalseIfDoesNotExist()
        {
            var result = await service.HotelExistsAsync(5);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public async Task Test_HotelReservationExistsAsync_ShouldReturnTrueIfExists()
        {
            var result = await service.HotelReservationExistsAsync("secondRes");

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public async Task Test_HotelReservationExistsAsync_ShouldReturnFalseIfDoesNotExist()
        {
            var result = await service.HotelReservationExistsAsync("NotExistingRes");

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public async Task Test_RoomExistsAsync_ShouldReturnTrueIfExists()
        {
            var result = await service.RoomExistsAsync(1);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public async Task Test_RoomExistsAsync_ShouldReturnFalseIfDoesNotExist()
        {
            var result = await service.RoomExistsAsync(999);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public async Task Test_AllCitiesNamesAsync_ShouldReturnCorrectResult()
        {
            var result = await service.AllCitiesNamesAsync();

            Assert.That(result.Count(), Is.EqualTo(4));
            Assert.That(result.First(), Is.EqualTo("Paris"));
            Assert.That(result.Skip(1).First(), Is.EqualTo("Madrid"));
            Assert.That(result.Skip(2).First(), Is.EqualTo("Tokyo"));
            Assert.That(result.Skip(3).First(), Is.EqualTo("New York"));
        }

        [Test]
        public async Task Test_GetPreviousActiveHotelIdAsync_ShouldReturnCorrectResult()
        {
            var result = await service.GetPreviousActiveHotelIdAsync(2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public async Task Test_GetPreviousActiveHotelIdAsync_ShouldReturnCorrectResultIfCurrentHotelIdIsFirst()
        {
            var result = await service.GetPreviousActiveHotelIdAsync(1);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public async Task Test_GetNextActiveHotelIdAsync_ShouldReturnCorrectResult()
        {
            var result = await service.GetNextActiveHotelIdAsync(1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public async Task Test_GetPreviousActiveHotelIdAsync_ShouldReturnCorrectResultIfCurrentHotelIdIsLast()
        {
            var result = await service.GetNextActiveHotelIdAsync(4);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public async Task Test_GetFirstActiveHotelIdAsync_ShouldReturnCorrectResult()
        {
            var result = await service.GetFirstActiveHotelIdAsync();

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public async Task Test_GetLastActiveHotelIdAsync_ShouldReturnCorrectResult()
        {
            var result = await service.GetLastActiveHotelIdAsync();

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public async Task Test_LastThreeHotelsAsync_ShouldReturnCorrectResult()
        {
            var result = await service.LastThreeHotelsAsync();

            Assert.Multiple(() =>
            {
                Assert.That(result.Count(), Is.EqualTo(3));
                Assert.That(result.First().Id, Is.EqualTo(4));
                Assert.That(result.First().Name, Is.EqualTo("Sotetsu Fresa Inn Tokyo Tamachi"));
                Assert.That(result.First().Address, Is.EqualTo("108-0023 Tokyo-to, Minato-ku Shibaura 3-14-21"));
                Assert.That(result.First().ImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/124760078.jpg?k=5b64947a1714bd3adbdebd6bff329c9a7debd693c4f02bb201390dc3988d4b63&o=&hp=1"));
                Assert.That(result.Skip(1).First().Id, Is.EqualTo(3));
                Assert.That(result.Skip(1).First().Name, Is.EqualTo("Hilton Garden Inn New York Times Square South"));
                Assert.That(result.Skip(1).First().Address, Is.EqualTo("326 West 37th Street , Hell's Kitchen, New York, NY 10018"));
                Assert.That(result.Skip(1).First().ImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/485847819.jpg?k=c8a7d6fe3756b65ddf1e88e4ece012a9e377f4da075e7f6c65d0064bee9dab61&o=&hp=1"));
                Assert.That(result.Skip(2).First().Id, Is.EqualTo(2));
                Assert.That(result.Skip(2).First().Name, Is.EqualTo("Catalonia Puerta del Sol"));
                Assert.That(result.Skip(2).First().Address, Is.EqualTo("Atocha, 23, Centro, 28012"));
                Assert.That(result.Skip(2).First().ImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/159811810.jpg?k=f40061a37ae157fd42e62ece3bd402bca73e10528b6160719bb103c4ab69be25&o=&hp=1"));
            });
        }

        [Test]
        public async Task Test_DetailsAsync_ShouldReturnCorrectResultIfHotelExists()
        {
            var result = await service.DetailsAsync(1);

            Assert.Multiple(() =>
            {
                Assert.That(result.Id, Is.EqualTo(1));
                Assert.That(result.Name, Is.EqualTo("Ibis Paris Gare Montparnasse Catalogne"));
                Assert.That(result.Address, Is.EqualTo("11 Rue Du Texel, 14th arr., 75014"));
                Assert.That(result.City.Id, Is.EqualTo(1));
                Assert.That(result.City.Name, Is.EqualTo("Paris"));
                Assert.That(result.CountryName, Is.EqualTo("France"));
                Assert.That(result.StarRate, Is.EqualTo(3));
                Assert.That(result.Details, Is.EqualTo("Ibis Paris Details"));
                Assert.That(result.ImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1"));
                Assert.That(result.CheckIn, Is.EqualTo("16:00"));
                Assert.That(result.CheckOut, Is.EqualTo("12:00"));
                Assert.That(result.Parking, Is.EqualTo(true));
                Assert.That(result.Pets, Is.EqualTo(true));
                Assert.That(result.Rooms.First().Id, Is.EqualTo(1));
                Assert.That(result.Rooms.First().Type, Is.EqualTo(RoomType.Double));
                Assert.That(result.Rooms.First().Hotel_Id, Is.EqualTo(1));
                Assert.That(result.Rooms.First().PricePerNight, Is.EqualTo(302m));
                Assert.That(result.Rooms.First().WiFi, Is.EqualTo(true));
                Assert.That(result.Rooms.First().IsActive, Is.EqualTo(true));
                Assert.That(result.Rooms.First().Count, expression: Is.EqualTo(5));
                Assert.That(result.HotelsCount, Is.EqualTo(4));
            });
        }

        [Test]
        public async Task Test_DetailsAsync_ShouldReturnCorrectResultIfHotelDoesNotExist()
        {
            try
            {
                await service.DetailsAsync(5);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel was not found!"));
            }     
        }

        [Test]
        public async Task Test_ReserveAsync_ShouldReturnCorrectResultIfRoomExists()
        {
            // Arrange
            var model = new HotelReservationInputModel()
            {
                FirstName = "John",
                LastName = "Doe",
                Room_Id = 1,
                StartDate = "15/04/2024",
                EndDate = "18/04/2024"
            };

            var userId = "firstUserId";

            // Act
            var result = await service.ReserveAsync(model, userId);
            var exists = await service.HotelReservationExistsAsync(result);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(exists, Is.True);
        }

        [Test]
        public async Task Test_ReserveAsync_ShouldReturnCorrectResultIfRoomDoesNotExist()
        { 
            var model = new HotelReservationInputModel()
            {
                FirstName = "John",
                LastName = "Doe",
                Room_Id = 5,
                StartDate = "15/04/2024",
                EndDate = "18/04/2024"
            };

            var userId = "firstUserId";

            try
            {
                _= await service.ReserveAsync(model, userId);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The room was not found!"));
            }
        }

        [Test]
        public async Task Test_GetForReserveAsync_ShouldReturnCorrectResultIfHotelExists()
        {
            var model = new HotelReservationInputModel()
            {
                Hotel_Id = 1,
                Rooms = await service.GetRoomsAsync(1),
                Name = "Ibis Paris Gare Montparnasse Catalogne",
                Address = "11 Rue Du Texel, 14th arr., 75014",
            };

            var result = await service.GetForReserveAsync(1);
           
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Hotel_Id, Is.EqualTo(model.Hotel_Id));
                Assert.That(result.Rooms?.First().Id, Is.EqualTo(1));
                Assert.That(result.Rooms?.First().Type, Is.EqualTo(RoomType.Double));
                Assert.That(result.Rooms?.First().Hotel_Id, Is.EqualTo(1));
                Assert.That(result.Rooms?.First().PricePerNight, Is.EqualTo(302m));
                Assert.That(result.Rooms?.First().WiFi, Is.EqualTo(true));
                Assert.That(result.Rooms?.First().IsActive, Is.EqualTo(true));
                Assert.That(result.Rooms?.First().Count, expression: Is.EqualTo(5));
                Assert.That(result.Name, Is.EqualTo(model.Name));
                Assert.That(result.Address, Is.EqualTo(model.Address));
            });
        }

        [Test]
        public async Task Test_GetForReserveAsync_ShouldReturnCorrectResultIfHotelDoesNotExist()
        {
            try
            {
                var result = await service.GetForReserveAsync(5);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel does not exist!"));
            }          
        }

        [Test]
        public async Task Test_GetForVerifyReservationAsync_ShouldCorrectlyDeleteVerificationsWithOldEndDateAndReturnCorrectResult()
        {
            // Arrange
            var userId = "firstUserId";

            // Record the count of verifications before method call
            var verificationsCountBefore = await repository.All<HotelReservation>()
                .Where(hr => hr.User_Id == userId && hr.IsActive == false
                    && hr.EndDate.Date < DateTime.Now.Date)
                .CountAsync();

            // Act
            var model = await service.GetForVerifyReservationAsync(userId);

            var verExists = await service.HotelVerificationExistsAsync("firstResFourRooms");

            var verificationsCountAfter = await repository.All<HotelReservation>()
                .Where(hr => hr.User_Id == userId && hr.IsActive == false
                    && hr.EndDate.Date < DateTime.Now.Date)
                .CountAsync();
           
            Assert.Multiple(() =>
            {
                Assert.That(verificationsCountBefore, Is.EqualTo(1));
                Assert.That(verificationsCountAfter, Is.EqualTo(0));
            });
            Assert.Multiple(() =>
            {
                Assert.That(model.First().FirstName, Is.EqualTo("First"));
                Assert.That(model.First().LastName, Is.EqualTo("User"));
                Assert.That(model.First().StartDate, Is.EqualTo("22/04/2024"));
                Assert.That(model.First().EndDate, Is.EqualTo("27/04/2024"));
                Assert.That(verExists, Is.EqualTo(true));
                Assert.That(model.First().RoomType, Is.EqualTo(RoomType.Single.ToString()));
                Assert.That(model.First().HotelName, Is.EqualTo("Ibis Paris Gare Montparnasse Catalogne"));
                Assert.That(model.First().HotelStarRate, Is.EqualTo(3));
                Assert.That(model.First().HotelImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1"));
                Assert.That(model.First().Price, Is.EqualTo(1005m));
                Assert.That(model.First().Nights, Is.EqualTo(5));
            });
        }
        
        [Test]
        public async Task Test_VerifyReservationAsync_ShouldWorkCorrectly()
        {
            var resBefore = await repository.GetByIdAsync<HotelReservation>("firstResFourRooms");

            var roomCntBefore = resBefore?.Room.Count;//4

            await service.VerifyReservationAsync("firstResFourRooms", "firstUserId");

            var room = await repository.GetByIdAsync<Room>(6);
            
            var roomCntAfter = room?.Count;//3

            var resAfter = await repository.GetByIdAsync<HotelReservation>("firstResFourRooms");

            Assert.Multiple(() =>
            {
                Assert.That(roomCntBefore, Is.EqualTo(4));
                Assert.That(roomCntAfter, Is.EqualTo(3));
                Assert.That(resAfter?.IsActive, Is.True);
                Assert.That(resAfter?.Price, Is.EqualTo(1005m));
            });
        }

        [Test]
        public async Task Test_VerifyReservationAsync_ShouldThrowAnExceptionIfResIsNotFound()
        {
            try
            {
                await service.VerifyReservationAsync("invalidRes", "firstUserId");
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current hotel reservation does not exist!"));
            }
        }
        
        [Test]
        public async Task Test_VerifyReservationAsync_ShouldThrowAnExceptionIfUserUnauthorized()
        {
            try
            {
                await service.VerifyReservationAsync("firstRes", "secondUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }
        }

        [Test]
        public async Task Test_VerifyReservationAsync_ShouldThrowAnExceptionIfRoomIsNotFound()
        {
            try
            {
                await service.VerifyReservationAsync("secondResInvRoom", "secondUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current room does not exist!"));
            }
        }
       
        [Test]
        public async Task Test_VerifyReservationAsync_ShouldThrowAnExceptionIfNoRoomsLeft()
        {
            try
            {
                await service.VerifyReservationAsync("secondResZeroRooms", "secondUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("No more rooms are available for the current time!"));
            }
        }

        [Test]
        public async Task Test_CancellVerificationAsync_ShouldWorkCorrectly()
        {
            var res = await repository.GetByIdAsync<HotelReservation>("firstResFourRooms");

            var verCnt = await repository.AllReadOnly<HotelReservation>()
                .CountAsync(hr => hr.IsActive == false && hr.StartDate.Date >= DateTime.Now.Date);
                
            var roomCnt = res?.Room.Count;//4
            
            await service.CancellVerificationAsync("firstResFourRooms", "firstUserId");

            var roomAfter = await repository.AllReadOnly<Room>()
                .FirstAsync(hr => hr.Id == 6);

            var roomCntAfter = roomAfter.Count;//5

            var verCntAfter = await repository.AllReadOnly<HotelReservation>()
                .CountAsync(hr => hr.IsActive == false && hr.StartDate.Date >= DateTime.Now.Date);

            Assert.Multiple(() =>
            {
                Assert.That(roomCnt, Is.EqualTo(4));
                Assert.That(roomCntAfter, Is.EqualTo(5));
                Assert.That(verCnt, Is.EqualTo(1));
                Assert.That(verCntAfter, Is.EqualTo(0));
            });
        }


        [Test]
        public async Task Test_CancellVerificationAsync_ShouldThrowAnExceptionIfVerificationWasNotFound()
        {
            try
            {
                await service.CancellVerificationAsync("NotFound", "firstUserId");
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel reservation does not exist!"));
            }
        }

        [Test]
        public async Task Test_CancellVerificationAsync_ShouldThrowAnExceptionIfUserIsUnauthorized()
        {
            try
            {
                await service.CancellVerificationAsync("firstResFourRooms", "secondUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }
        }

        [Test]
        public async Task Test_CancellVerificationAsync_ShouldThrowAnExceptionIfRoomDoesNotExists()
        {
            try
            {
                await service.CancellVerificationAsync("secondResInvRoom", "secondUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The room does not exist!"));
            }
        }
    }
}

//FirstUserReservation = new HotelReservation()
//{
//    User_Id = "firstUserId",
//    StartDate = DateTime.ParseExact("24/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
//    EndDate = DateTime.ParseExact("26/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
//    Hotel_Id = 1,
//    CreatedOn = DateTime.Now,
//    FirstName = "First",
//    LastName = "User",
//    Id = "firstRes",
//    Price = 604m,
//    IsActive = true,
//    Room_Id = 1
//};

//  IbisParis = new Hotel()
//  {
//    Id = 1,
//    Name = "Ibis Paris Gare Montparnasse Catalogne",
//    Address = "11 Rue Du Texel, 14th arr., 75014",
//    City_Id = 1,
//    StarRate = 3,
//    Details = "Ibis Paris Details",
//    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1",
//    CheckIn = DateTime.ParseExact("16:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
//    CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
//    Parking = true,
//    Pets = true,
//    IsActive = true
//};

//IbisParisRoomDouble = new Room()
//{
//    Id = 1,
//    Type = RoomType.Double,
//    Hotel_Id = 1,
//    PricePerNight = 302m,
//    WiFi = true,
//    IsActive = true,
//    Count = 5
//};