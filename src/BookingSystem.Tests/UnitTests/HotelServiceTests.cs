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
using System.Net;
using System.Xml.Linq;
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
        private ApplicationUser ThirdUser { get; set; } = null!;
        private ApplicationUser FourthUser { get; set; } = null!;

        #endregion


        #region Reservations

        private HotelReservation FirstUserReservation { get; set; } = null!;

        private HotelReservation FirstUserReservationLate { get; set; } = null!;

        private HotelReservation FirstUserReservationFourRooms { get; set; } = null!;

        private HotelReservation SecondUserReservation { get; set; } = null!;

        private HotelReservation SecondUserReservationInvalidRoom { get; set; } = null!;

        private HotelReservation SecondUserReservationZeroRooms { get; set; } = null!;

        private HotelReservation ThirdUserReservation { get; set; } = null!;
        private HotelReservation ThirdUserReservationLate { get; set; } = null!;
        private HotelReservation ThirdUserReservationNotActive { get; set; } = null!;
        private HotelReservation ThirdUserReservationToCancell { get; set; } = null!;
        private HotelReservation ThirdUserReservationInvalidRoom { get; set; } = null!;

        private HotelReservation FourthUserReservationToBeDeleted { get; set; } = null!;

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
        private Hotel HotelToDelete { get; set; } = null!;

        #endregion


        #region Rooms
        private Room IbisParisRoomDouble { get; set; } = null!;
        private Room IbisParisRoomTriple { get; set; } = null!;
        private Room CataloniaPuertaRoomSingle { get; set; } = null!;
        private Room CataloniaPuertaRoomDoubleFour { get; set; } = null!;
        private Room HiltonGardenRoomTriple { get; set; } = null!;
        private Room SotetsuFresaRoomSingle { get; set; } = null!;
        private Room SotetsuFresaRoomDouble { get; set; } = null!;
        private Room SotetsuFresaRoomTriple { get; set; } = null!;

        private Room HotelToDeleteRoomSingle { get; set; } = null!;
        private Room RoomWithInvalidHotelId { get; set; } = null!; 

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

            ThirdUser = new ApplicationUser()
            {
                Id = "thirdUserId",
                UserName = "thirdUser@mail.com",
                NormalizedUserName = "THIRDUSER@MAIL.COM",
                Email = "thirdUser@mail.com",
                NormalizedEmail = "THIRDDUSER@MAIL.COM",
                FirstName = "Kamen",
                LastName = "Kalchev"
            };

            FourthUser = new ApplicationUser()
            {
                Id = "fourthUserId",
                UserName = "fourthUser@mail.com",
                NormalizedUserName = "FOURTHUSER@MAIL.COM",
                Email = "fourthUser@mail.com",
                NormalizedEmail = "FOURTHUSER@MAIL.COM",
                FirstName = "Dimitar",
                LastName = "Tanchev"
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

            HotelToDelete = new Hotel()
            {
                Id = 5,
                Name = "Hotel to be deleted",
                Address = "no address",
                City_Id = 3,
                StarRate = 4,
                Details = "hotel to be deleted Details",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1",
                CheckIn = DateTime.ParseExact("16:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = true,
                IsActive = true
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
                Type = RoomType.Triple,
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
                Count = 4
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

            SotetsuFresaRoomDouble = new Room()
            {
                Id = 7,
                Type = RoomType.Double,
                Hotel_Id = 4,
                PricePerNight = 150m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            SotetsuFresaRoomTriple = new Room()
            {
                Id = 8,
                Type = RoomType.Triple,
                Hotel_Id = 4,
                PricePerNight = 200m,
                WiFi = true,
                IsActive = true,
                Count = 4
            };

            HotelToDeleteRoomSingle = new Room()
            {
                Id = 9,
                Type = RoomType.Single,
                Hotel_Id = 5,
                PricePerNight = 250m,
                WiFi = true,
                IsActive = true,
                Count = 4
            };

            RoomWithInvalidHotelId = new Room()
            {
                Id = 10,
                Type = RoomType.Single,
                Hotel_Id = 999,
                PricePerNight = 250m,
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
                Room_Id = 999
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


            ThirdUserReservation = new HotelReservation()
            {
                User_Id = "thirdUserId",
                StartDate = DateTime.ParseExact("05/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("06/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 4,
                CreatedOn = DateTime.Now,
                FirstName = "Third",
                LastName = "User",
                Id = "thirdRes",
                Price = 150m,
                IsActive = true,
                Room_Id = 7
            };

            ThirdUserReservationLate = new HotelReservation()
            {
                User_Id = "thirdUserId",
                StartDate = DateTime.ParseExact("13/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("15/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 4,
                CreatedOn = DateTime.Now,
                FirstName = "Third",
                LastName = "User",
                Id = "thirdResInvalid",
                Price = 300m,
                IsActive = true,
                Room_Id = 3
            };

            ThirdUserReservationNotActive = new HotelReservation()
            {
                User_Id = "thirdUserId",
                StartDate = DateTime.ParseExact("13/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("15/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 4,
                CreatedOn = DateTime.Now,
                FirstName = "Third",
                LastName = "User",
                Id = "thirdResNotActive",
                Price = 300m,
                IsActive = false,
                Room_Id = 3
            };

            ThirdUserReservationToCancell = new HotelReservation()
            {
                User_Id = "thirdUserId",
                StartDate = DateTime.ParseExact("13/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("15/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 4,
                CreatedOn = DateTime.Now,
                FirstName = "Third",
                LastName = "User",
                Id = "thirdResToCancell",
                Price = 400m,
                IsActive = true,
                Room_Id = 8
            };

            ThirdUserReservationInvalidRoom = new HotelReservation()
            {
                User_Id = "thirdUserId",
                StartDate = DateTime.ParseExact("13/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("15/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 3,
                CreatedOn = DateTime.Now,
                FirstName = "Third",
                LastName = "User",
                Id = "thirdResInvalidRoom",
                Price = 400m,
                IsActive = true,
                Room_Id = 999 //Invalid room 
            };

            FourthUserReservationToBeDeleted = new HotelReservation()
            {
                User_Id = "fourthUserId",
                StartDate = DateTime.ParseExact("13/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("14/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Hotel_Id = 5,
                CreatedOn = DateTime.Now,
                FirstName = "Fourth",
                LastName = "User",
                Id = "fourthResToDelete",
                Price = 250m,
                IsActive = true,
                Room_Id = 9
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
                IbisParis, CataloniaPuerta, HiltonGarden, SotetsuFresa, HotelToDelete
            };

            rooms = new List<Room>()
            {
                IbisParisRoomDouble, IbisParisRoomTriple, CataloniaPuertaRoomSingle,
                CataloniaPuertaRoomDoubleFour, HiltonGardenRoomTriple,
                SotetsuFresaRoomSingle, SotetsuFresaRoomDouble, SotetsuFresaRoomTriple, HotelToDeleteRoomSingle,
                RoomWithInvalidHotelId
            };

            reservations = new List<HotelReservation>()
            {
                FirstUserReservation, SecondUserReservation, FirstUserReservationFourRooms,
                FirstUserReservationLate, SecondUserReservationInvalidRoom,
                SecondUserReservationZeroRooms, ThirdUserReservation, ThirdUserReservationLate,
                ThirdUserReservationNotActive, ThirdUserReservationToCancell, ThirdUserReservationInvalidRoom,
                FourthUserReservationToBeDeleted

            };

            users = new List<ApplicationUser>()
            {
                FirstUser,
                SecondUser,
                ThirdUser,
                FourthUser
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
            Assert.That(hotelIds, Is.EqualTo(new List<int>() { 5, 4, 3, 2 }));
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
            Assert.That(hotelIds, Is.EqualTo(new List<int>() { 4, 2, 3, 5 }));
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
            Assert.That(hotelIds, Is.EqualTo(new List<int>() { 1, 5, 3, 2 }));
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

            Assert.That(result, Is.EqualTo(5));
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
            var result = await service.HotelExistsAsync(999);

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

            Assert.That(result, Is.EqualTo(5));
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
            var result = await service.GetNextActiveHotelIdAsync(5);

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

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public async Task Test_LastThreeHotelsAsync_ShouldReturnCorrectResult()
        {
            var result = await service.LastThreeHotelsAsync();

            Assert.Multiple(() =>
            {
                Assert.That(result.Count(), Is.EqualTo(3));
                Assert.That(result.First().Id, Is.EqualTo(5));
                Assert.That(result.First().Name, Is.EqualTo("Hotel to be deleted"));
                Assert.That(result.First().Address, Is.EqualTo("no address"));
                Assert.That(result.First().ImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1"));
                Assert.That(result.Skip(1).First().Id, Is.EqualTo(4));
                Assert.That(result.Skip(1).First().Name, Is.EqualTo("Sotetsu Fresa Inn Tokyo Tamachi"));
                Assert.That(result.Skip(1).First().Address, Is.EqualTo("108-0023 Tokyo-to, Minato-ku Shibaura 3-14-21"));
                Assert.That(result.Skip(1).First().ImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/124760078.jpg?k=5b64947a1714bd3adbdebd6bff329c9a7debd693c4f02bb201390dc3988d4b63&o=&hp=1"));
                Assert.That(result.Skip(2).First().Id, Is.EqualTo(3));
                Assert.That(result.Skip(2).First().Name, Is.EqualTo("Hilton Garden Inn New York Times Square South"));
                Assert.That(result.Skip(2).First().Address, Is.EqualTo("326 West 37th Street , Hell's Kitchen, New York, NY 10018"));
                Assert.That(result.Skip(2).First().ImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/485847819.jpg?k=c8a7d6fe3756b65ddf1e88e4ece012a9e377f4da075e7f6c65d0064bee9dab61&o=&hp=1"));
            });
        }

        //HiltonGarden = new Hotel()
        //{
        //    Id = 3,
        //        Name = "Hilton Garden Inn New York Times Square South",
        //        Address = "326 West 37th Street , Hell's Kitchen, New York, NY 10018",
        //        City_Id = 3,
        //        StarRate = 3,
        //        Details = "The Hilton Garden Inn New York Times Square South is located less than 1 km away from Jacob K. Javits Convention Centre and 1.3 km from Times Square. Complimentary WiFi is provided.\r\n\r\nAll rooms at this property are fitted with a flat-screen TV, coffee maker, microwave and mini-refrigerator. A desk with an ergonomic chair are also provided.\r\n\r\nGuests will have access to free coffee in the morning and a fitness centre. The 24-hour Garden Market will carry snacks and sundry items.\r\n\r\nLaGuardia Airport is 18.3 km from the property while JFK Airport is 27 km from Hilton Garden Inn New York Times Square South. The Empire State Building is 1.6 km away.",
        //        ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/485847819.jpg?k=c8a7d6fe3756b65ddf1e88e4ece012a9e377f4da075e7f6c65d0064bee9dab61&o=&hp=1",
        //        CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
        //        CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
        //        Parking = true,
        //        Pets = true,
        //        IsActive = true
        //    };

        //SotetsuFresa = new Hotel()
        //{
        //    Id = 4,
        //        Name = "Sotetsu Fresa Inn Tokyo Tamachi",
        //        Address = "108-0023 Tokyo-to, Minato-ku Shibaura 3-14-21",
        //        City_Id = 4,
        //        StarRate = 3,
        //        Details = "A 5-minute walk from JR Tamachi Train Station and Mita Subway Station, Sotetsu Fresa Inn Tokyo Tamachi offers simple modern accommodations with free wired internet access. Guests can request relaxing massages for an extra cost and store luggage for free at the 24-hour front desk. Tokyo Tamachi Sotetsu Fresa Inn is a 20-minute walk from Shiba Park and a 10-minute train ride from JR Shinagawa Train Station. The Imperial Palace is a 15-minute drive away.",
        //        ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/124760078.jpg?k=5b64947a1714bd3adbdebd6bff329c9a7debd693c4f02bb201390dc3988d4b63&o=&hp=1",
        //        CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
        //        CheckOut = DateTime.ParseExact("11:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
        //        Parking = false,
        //        Pets = false,
        //        IsActive = true,
        //    };

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
                Assert.That(result.HotelsCount, Is.EqualTo(5));
            });
        }

        [Test]
        public async Task Test_DetailsAsync_ShouldReturnCorrectResultIfHotelDoesNotExist()
        {
            try
            {
                await service.DetailsAsync(5);
            }
            catch (ArgumentException ex)
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
                Room_Id = 999,//Invalid room
                StartDate = "15/04/2024",
                EndDate = "18/04/2024"
            };

            var userId = "firstUserId";

            try
            {
                _ = await service.ReserveAsync(model, userId);
            }
            catch (ArgumentException ex)
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
            catch (ArgumentException ex)
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
            catch (ArgumentException ex)
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
            catch (ArgumentException ex)
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

        [Test]
        public async Task Test_AllReservationsAsync_ShouldWorkCorrectly()
        {
            var invalidResCntBefore = await repository.All<HotelReservation>()
                .Where(hr => hr.EndDate.Date < DateTime.Now.Date
                    && hr.IsActive == true && hr.User_Id == "thirdUserId")
                .Include(hr => hr.Room)
                .CountAsync();//1

            var res = await service.AllReservationsAsync("thirdUserId");

            var invalidResCntAfter = await repository.All<HotelReservation>()
                .Where(hr => hr.EndDate.Date < DateTime.Now.Date
                    && hr.IsActive == true && hr.User_Id == "thirdUserId")
                .Include(hr => hr.Room)
                .CountAsync();//0

            Assert.That(invalidResCntBefore, Is.EqualTo(1));
            Assert.That(invalidResCntAfter, Is.EqualTo(0));

            Assert.Multiple(() =>
            {
                Assert.That(res.First().Id, Is.EqualTo("thirdRes"));
                Assert.That(res.First().FirstName, Is.EqualTo("Third"));
                Assert.That(res.First().LastName, Is.EqualTo("User"));
                Assert.That(res.First().Hotel_Id, Is.EqualTo(4));
                Assert.That(res.First().Name, Is.EqualTo("Sotetsu Fresa Inn Tokyo Tamachi"));
                Assert.That(res.First().Address, Is.EqualTo("108-0023 Tokyo-to, Minato-ku Shibaura 3-14-21"));
                Assert.That(res.First().HotelImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/124760078.jpg?k=5b64947a1714bd3adbdebd6bff329c9a7debd693c4f02bb201390dc3988d4b63&o=&hp=1"));
                Assert.That(res.First().Price, Is.EqualTo(150m));
                Assert.That(res.First().RoomType, Is.EqualTo(RoomType.Double.ToString()));
                Assert.That(res.First().StartDate, Is.EqualTo("05/05/2024"));
                Assert.That(res.First().EndDate, Is.EqualTo("06/05/2024"));
            });
        }

        [Test]
        public async Task Test_GetForEditReservationAsync_ShouldWorkCorrectly()
        {
            var model = await service.GetForEditReservationAsync("thirdRes", "thirdUserId");

            Assert.Multiple(() =>
            {
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo("thirdRes"));
                Assert.That(model.FirstName, Is.EqualTo("Third"));
                Assert.That(model.LastName, Is.EqualTo("User"));
            });
        }

        [Test]
        public async Task Test_GetForEditReservationAsync_ShouldThrowAnException_IfReservationDoesNotExist()
        {
            try
            {
                _ = await service.GetForEditReservationAsync("InvalidRes", "thirdUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel reservation does not exist!"));
            }
        }

        [Test]
        public async Task Test_GetForEditReservationAsync_ShouldThrowAnException_IfUnauthorizedUser()
        {
            try
            {
                _ = await service.GetForEditReservationAsync("thirdRes", "secondUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }
        }

        [Test]
        public async Task Test_GetForEditReservationAsync_ShouldThrowAnException_IfReservationIsNotActive()
        {
            try
            {
                _ = await service.GetForEditReservationAsync("thirdResNotActive", "thirdUserId");
            }
            catch (NoLongerActiveReservationException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The reservation is no longer available!"));
            }
        }

        [Test]
        public async Task Test_EditReservationAsync_ShouldWorkCorrectly()
        {
            var model = new HotelReservationEditInputModel()
            {
                Id = "thirdRes",
                FirstName = "Edit",
                LastName = "Editov"
            };

            await service.EditReservationAsync(model, "thirdUserId");

            var res = await repository.GetByIdAsync<HotelReservation>(model.Id);

            Assert.That(res, Is.Not.Null);
            Assert.That(res.Id, Is.EqualTo(model.Id));
            Assert.That(res.FirstName, Is.EqualTo(model.FirstName));
            Assert.That(res.LastName, Is.EqualTo(expected: model.LastName));
        }

        [Test]
        public async Task Test_EditReservationAsync_ShouldThrowAnException_IfReservationDoesNotExist()
        {
            var model = new HotelReservationEditInputModel()
            {
                Id = "invalidRes",
                FirstName = "Edit",
                LastName = "Editov"
            };

            try
            {
                await service.EditReservationAsync(model, "thirdUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel reservation does not exist!"));
            }
        }

        [Test]
        public async Task Test_EditReservationAsync_ShouldThrowAnException_IfUnauthorizedUser()
        {
            var model = new HotelReservationEditInputModel()
            {
                Id = "thirdRes",
                FirstName = "Edit",
                LastName = "Editov"
            };

            try
            {
                await service.EditReservationAsync(model, "secondUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }
        }

        [Test]
        public async Task Test_EditReservationAsync_ShouldThrowAnException_IfNoLongerActviveReservation()
        {
            var model = new HotelReservationEditInputModel()
            {
                Id = "thirdResNotActive",
                FirstName = "Edit",
                LastName = "Editov"
            };

            try
            {
                await service.EditReservationAsync(model, "thirdUserId");
            }
            catch (NoLongerActiveReservationException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The reservation is no longer available!"));
            }
        }

        [Test]
        public async Task Test_CancellReservationAsync_ShouldWorkCorrectly()
        {
            var room = await repository.GetByIdAsync<Room>(8);

            var resCntBefore = await repository.AllReadOnly<HotelReservation>().CountAsync();//10

            var roomCntBefore = room?.Count; //4

            await service.CancellReservationAsync("thirdResToCancell", "thirdUserId");

            var resCntAfter = await repository.AllReadOnly<HotelReservation>().CountAsync();//9

            var roomCntAfter = room?.Count;//5

            Assert.Multiple(() =>
            {
                Assert.That(resCntBefore, Is.EqualTo(12));
                Assert.That(resCntAfter, Is.EqualTo(11));
                Assert.That(roomCntBefore, Is.EqualTo(4));
                Assert.That(roomCntAfter, Is.EqualTo(5));
            });
        }

        [Test]
        public async Task Test_CancellReservationAsync_ShouldThrowAnException_IfReservationDoesNotExist()
        {
            try
            {
                await service.CancellReservationAsync("invalidRes", "thirdUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel reservation does not exist!"));
            }
        }

        [Test]
        public async Task Test_CancellReservationAsync_ShouldThrowAnException_IfUnauthorizedUser()
        {
            try
            {
                await service.CancellReservationAsync("thirdResToCancell", "secondUserId");
            }
            catch (UnauthorizedActionException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The current user is not the owner of the reservation!"));
            }
        }

        [Test]
        public async Task Test_CancellReservationAsync_ShouldThrowAnException_IfReservationIsNotActive()
        {
            try
            {
                await service.CancellReservationAsync("thirdResNotActive", "thirdUserId");
            }
            catch (NoLongerActiveReservationException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The reservation is no longer available!"));
            }
        }

        [Test]
        public async Task Test_CancellReservationAsync_ShouldThrowAnException_IfRoomDoesNotExists()
        {
            try
            {
                await service.CancellReservationAsync("thirdResInvalidRoom", "thirdUserId");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The room does not exist!"));
            }
        }

        [Test]
        public async Task Test_GetForEditAsync_ShouldWorkCorrectly()
        {
            var model = await service.GetForEditAsync(1);

            Assert.Multiple(() =>
            {
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1));
                Assert.That(model.Name, Is.EqualTo("Ibis Paris Gare Montparnasse Catalogne"));
                Assert.That(model.StarRate, Is.EqualTo(3));
                Assert.That(model.Address, Is.EqualTo("11 Rue Du Texel, 14th arr., 75014"));
                Assert.That(model.Details, Is.EqualTo("Ibis Paris Details"));
                Assert.That(model.CheckIn, Is.EqualTo("16:00"));
                Assert.That(model.CheckOut, Is.EqualTo("12:00"));
                Assert.That(model.ImageUrl, Is.EqualTo("https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1"));
                Assert.That(model.Parking, Is.EqualTo("Available"));
                Assert.That(model.Pets, Is.EqualTo("Allowed"));
            });
        }

        [Test]
        public async Task Test_GetForEditAsync_ShouldThrowAnException_IfHotelDoesNotExist()
        {
            try
            {
                _ = await service.GetForEditAsync(999);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel was not found!"));
            }
        }

        [Test]
        public async Task Test_EditAsync_ShouldWorkCorrectly()
        {
            var model = new HotelEditAddInputModel()
            {
                Id = 1,
                Name = "Ibis Paris Gare Montparnasse Catalogne",
                Address = "11 Rue Du Texel, 14th arr., 75014",
                City_Id = 1,
                StarRate = 3,
                Details = "Ibis Paris Details",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1",
                CheckIn = "16:00",
                CheckOut = "12:00",
                Parking = "Available",
                Pets = "Allowed"
            };

            await service.EditAsync(model);

            var hotel = await repository.GetByIdAsync<Hotel>(1);

            Assert.Multiple(() =>
            {
                Assert.That(hotel!.Id, Is.EqualTo(model.Id));
                Assert.That(hotel!.Name, Is.EqualTo(model.Name));
                Assert.That(hotel!.Address, Is.EqualTo(model.Address));
                Assert.That(hotel!.City_Id, Is.EqualTo(model.City_Id));
                Assert.That(hotel!.StarRate, Is.EqualTo(model.StarRate));
                Assert.That(hotel!.Details, Is.EqualTo(model.Details));
                Assert.That(hotel!.ImageUrl, Is.EqualTo(model.ImageUrl));
                Assert.That(hotel!.CheckIn, Is.EqualTo(DateTime.ParseExact("16:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None)));
                Assert.That(hotel!.CheckOut, Is.EqualTo(DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None)));
                Assert.That(hotel!.Parking, Is.EqualTo(true));
                Assert.That(hotel!.Pets, Is.EqualTo(true));
            });
        }

        [Test]
        public async Task Test_EditAsync_ShouldThrowAnException_IfHotelDoesNotExist()
        {
            var model = new HotelEditAddInputModel()
            {
                Id = 999,//Invalid Hotel_Id
                Name = "Ibis Paris Gare Montparnasse Catalogne",
                Address = "11 Rue Du Texel, 14th arr., 75014",
                City_Id = 1,
                StarRate = 3,
                Details = "Ibis Paris Details",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1",
                CheckIn = "16:00",
                CheckOut = "12:00",
                Parking = "Available",
                Pets = "Allowed"
            };

            try
            {
                await service.EditAsync(model);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel was not found!"));
            }
        }

        [Test]
        public async Task Test_DeleteAsync_ShouldWorkCorrectly()
        {
            var resCntBefore = await repository.AllReadOnly<HotelReservation>().CountAsync();//12
            var roomCntBefore = await repository.AllReadOnly<Room>()
               .Where(r => r.Hotel_Id == 5)
               .CountAsync();//1

            await service.DeleteAsync(5);

            var resCntAfter = await repository.AllReadOnly<HotelReservation>().CountAsync();//11
            var roomCntAfter = await repository.AllReadOnly<Room>()
                .Where(r => r.Hotel_Id == 5)
                .CountAsync();//0

            var hotel = await repository.GetByIdAsync<Hotel>(5);

            Assert.That(resCntBefore, Is.EqualTo(12));
            Assert.That(resCntAfter, Is.EqualTo(11));
            Assert.That(roomCntBefore, Is.EqualTo(1));
            Assert.That(roomCntAfter, Is.EqualTo(0));
            Assert.That(hotel!.IsActive, Is.EqualTo(false));
        }

        [Test]
        public async Task Test_DeleteAsync_ShouldThrowAnException_IfHotelDoesNotExist()
        {
            try
            {
                await service.DeleteAsync(999);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel was not found!"));
            }
        }

        [Test]
        public async Task Test_AddAsync_ShouldWorkCorrectly()
        {
            var model = new HotelEditAddInputModel()
            {
                Id = 6,
                Name = "Hotel 6",
                Address = "Hotel 6 address",
                City_Id = 2,
                StarRate = 4,
                Details = "Hotel 6 Details",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1",
                CheckIn = "16:00",
                CheckOut = "12:00",
                Parking = "Available",
                Pets = "Allowed"
            };

            var hotelsCntBefore = await repository.AllReadOnly<Hotel>().CountAsync();//5

            await service.AddAsync(model);

            var hotelsCntAfter = await repository.AllReadOnly<Hotel>().CountAsync();//6

            Assert.That(hotelsCntBefore, Is.EqualTo(5));
            Assert.That(hotelsCntAfter, Is.EqualTo(6));
        }

        [Test]
        public async Task Test_GetForAddAsync_ShouldWorkCorrectly()
        {
           var citiesToShow = await service.GetAllCitiesAsync();
           
           var model = await service.GetForAddAsync();
           
           Assert.That(model.Cities.Count(), Is.EqualTo(citiesToShow.Count()));
        }

        [Test]
        public async Task Test_GetAllCitiesAsync_ShouldWorkCorrectly()
        {
            var cities = await service.GetAllCitiesAsync();
            
            Assert.Multiple(() =>
            {
                Assert.That(cities.Count(), Is.EqualTo(4));
                Assert.That(cities.First().Id, Is.EqualTo(1));
                Assert.That(cities.First().Name, Is.EqualTo("Paris"));
                Assert.That(cities.Skip(1).First().Id, Is.EqualTo(2));
                Assert.That(cities.Skip(1).First().Name, Is.EqualTo("Madrid"));
                Assert.That(cities.Skip(2).First().Id, Is.EqualTo(4));
                Assert.That(cities.Skip(2).First().Name, Is.EqualTo("Tokyo"));
                Assert.That(cities.Skip(3).First().Id, Is.EqualTo(3));
                Assert.That(cities.Skip(3).First().Name, Is.EqualTo("New York"));
            });
            
        }

        [Test]
        public async Task Test_GetForAddRoomAsync_ShouldWorkCorrectly()
        {
            var model = await service.GetForAddRoomAsync(1);
            
            Assert.Multiple(() =>
            {
                Assert.That(model.Hotel_Id, Is.EqualTo(1));
                Assert.That(model.Types.Count(), Is.EqualTo(2));
                Assert.That(model.Name, Is.EqualTo("Ibis Paris Gare Montparnasse Catalogne"));
                Assert.That(model.Address, Is.EqualTo("11 Rue Du Texel, 14th arr., 75014"));
            });
        }

        [Test]
        public async Task Test_GetForAddRoomAsync_ShouldThrowAnException_IfNotValidHotelId()
        {
            try
            {
                _ = await service.GetForAddRoomAsync(999);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel does not exists!"));
            }
        }

        [Test]
        public async Task Test_AddRoomAsync_ShouldWorkCorrectly_AndWifiAvailable()
        {
            var model = new RoomInputModel()
            {
                Id = 2,
                PricePerNight = 140m,
                Type = "Apartment",
                Name = "Catalonia Puerta del Sol",
                Address = "Atocha, 23, Centro, 28012",
                Wifi = "Available"               
            };

            var roomsCntBefore = await repository.AllReadOnly<Room>().CountAsync();//9

            await service.AddRoomAsync(model);

            var roomsCntAfter = await repository.AllReadOnly<Room>().CountAsync();//10

            var room = await repository.GetByIdAsync<Room>(11);

            Assert.That(roomsCntBefore, Is.EqualTo(10));
            Assert.That(roomsCntAfter, Is.EqualTo(11));
            Assert.That(room, Is.Not.Null);
            Assert.That(room.Hotel_Id, Is.EqualTo(model.Id));
            Assert.That(room.PricePerNight, Is.EqualTo(model.PricePerNight));
            Assert.That(room.Type.ToString(), Is.EqualTo(model.Type));
            Assert.That(room.WiFi, Is.EqualTo(true));
        }

        [Test]
        public async Task Test_AddRoomAsync_ShouldWorkCorrectly_AndWifiNotAvailable()
        {
            var model = new RoomInputModel()
            {
                Id = 2,
                PricePerNight = 140m,
                Type = "Apartment",
                Name = "Catalonia Puerta del Sol",
                Address = "Atocha, 23, Centro, 28012",
                Wifi = "Not Available"
            };

            var roomsCntBefore = await repository.AllReadOnly<Room>().CountAsync();//9

            await service.AddRoomAsync(model);

            var roomsCntAfter = await repository.AllReadOnly<Room>().CountAsync();//10

            var room = await repository.GetByIdAsync<Room>(11);

            Assert.That(roomsCntBefore, Is.EqualTo(10));
            Assert.That(roomsCntAfter, Is.EqualTo(11));
            Assert.That(room, Is.Not.Null);
            Assert.That(room.Hotel_Id, Is.EqualTo(model.Id));
            Assert.That(room.PricePerNight, Is.EqualTo(model.PricePerNight));
            Assert.That(room.Type.ToString(), Is.EqualTo(model.Type));
            Assert.That(room.WiFi, Is.EqualTo(false));
        }

        [Test]
        public async Task Test_AddRoomAsync_ShouldThrowAnException_IfHotelDoesNotExist()
        {
            var model = new RoomInputModel()
            {
                Id = 999,
                PricePerNight = 140m,
                Type = "Apartment",
                Name = "Catalonia Puerta del Sol",
                Address = "Atocha, 23, Centro, 28012",
                Wifi = "Available"
            };

            try
            {
                await service.AddRoomAsync(model);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Hotel does not exist!"));
            }
        }

        [Test]
        public void Test_GetAllRoomTypes_ShouldReturnCorrectResult()
        {
            IEnumerable<string> types = new List<string>
            {
                "Single",
                "Double",
                "Triple",
                "Apartment"
            };

            Assert.That(types, Is.EqualTo(service.GetAllRoomTypes()));
        }

        [Test]
        public async Task Test_GetForEditRoomAsync_ShouldWorkCorrectly()
        {
            var model = await service.GetForEditRoomAsync(9);

            Assert.That(model, Is.Not.Null);
            Assert.That(model.Id, Is.EqualTo(9));
            Assert.That(model.Hotel_Id, Is.EqualTo(5));
            Assert.That(model.PricePerNight, Is.EqualTo(250));
            Assert.That(model.Name, Is.EqualTo("Hotel to be deleted"));
            Assert.That(model.Address, Is.EqualTo("no address"));
        }

        [Test]
        public async Task Test_GetForEditRoomAsync_ShouldThrowAnException_IfRoomDoesNotExist()
        {
            try
            {
                _ = await service.GetForEditRoomAsync(999);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The room does not exist!"));
            }
        }

        [Test]
        public async Task Test_GetForEditRoomAsync_ShouldThrowAnException_IfHotelDoesNotExist()
        {
            try
            {
                _ = await service.GetForEditRoomAsync(10);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel does not exist!"));
            }
        }

        [Test]
        public async Task Test_EditRoomAsync_ShouldWorkCorrectly()
        {
            var model = new RoomEditInputModel()
            {
                Id = 9,
                Hotel_Id = 5,
                Name = "Hotel to be deleted",
                Address = "no address",
                PricePerNight = 250m
            };

            await service.EditRoomAsync(model);

            var room = await repository.AllReadOnly<Room>().Include(r => r.Hotel)
                .Where(r => r.Id == model.Id).FirstAsync();

            Assert.That(room!.Id, Is.EqualTo(model.Id));
            Assert.That(room!.Hotel_Id, Is.EqualTo(model.Hotel_Id));
            Assert.That(room!.Hotel.Name, Is.EqualTo(model.Name));
            Assert.That(room!.Hotel.Address, Is.EqualTo(model.Address));
            Assert.That(room.PricePerNight, Is.EqualTo(model.PricePerNight));
        }

        [Test]
        public async Task Test_EditRoomAsync_ShouldThrowAnException_IfRoomDoesNotExist()
        {
            var model = new RoomEditInputModel()
            {
                Id = 999,
                Hotel_Id = 5,
                Name = "Hotel to be deleted",
                Address = "no address",
                PricePerNight = 250m
            };

            try
            {
                 await service.EditRoomAsync(model);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The room does not exist!"));
            }
        }

        [Test]
        public async Task Test_EditRoomAsync_ShouldThrowAnException_IfHotelDoesNotExist()
        {
            var model = new RoomEditInputModel()
            {
                Id = 10,
                Hotel_Id = 999,
                Name = "Hotel to be deleted",
                Address = "no address",
                PricePerNight = 250m
            };

            try
            {
                await service.EditRoomAsync(model);
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The hotel does not exist!"));
            }
        }
        
        [Test]
        public async Task Test_DeleteRoomAsync_ShouldWorkCorrectly()
        {
            var roomCntBefore = await repository.AllReadOnly<Room>().CountAsync();//10

            await service.DeleteRoomAsync(10);

            var roomCntAfter = await repository.AllReadOnly<Room>().CountAsync();//9

            Assert.That(roomCntBefore, Is.EqualTo(10));
            Assert.That(roomCntAfter, Is.EqualTo(9));
        }

        [Test]
        public async Task Test_DeleteRoomAsync_ShouldThrowAnException_IfRoomDoesNotExist()
        {
            try
            {
                await service.DeleteRoomAsync(999);
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("The room does not exist!"));
            }
        }

        [Test]
        public async Task Test_GetAllValidRoomTypesAsync_ShouldWorkCorrectly()
        {
            var types = await service.GetAllValidRoomTypesAsync(1);

            IEnumerable<string> validRoomTypes = new List<string>
            {
                "Single",
                "Apartment"
            };

            Assert.That(types.Count(), Is.EqualTo(validRoomTypes.Count()));
            Assert.That(types, Is.EqualTo(validRoomTypes));
        }
    }
}

