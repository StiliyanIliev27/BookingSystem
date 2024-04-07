﻿namespace BookingSystem.Infrastructure.Data.DataSeeding
{
    using BookingSystem.Core.Models.User;
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using BookingSystem.Infrastructure.Data.Models.Landmarks;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.AspNetCore.Identity;
    using System.Globalization;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Hotel;
    using static BookingSystem.Infrastructure.Data.Constants.CustomClaims;
    internal class Seeder
    {
        /// <summary>
        ///Seeder Constructor
        /// </summary>
        public Seeder()
        {
            SeedUsers();
            SeedLanguages();
            SeedContinents();
            SeedCountries();
            SeedCities();
            SeedLandmarks();
            SeedRooms();
            SeedHotels();
            SeedAirlines();
            SeedAirports();
            SeedFlights();
        }

        //Properties

        #region Users
        public ApplicationUser AdminUser { get; set; } = null!;
        public ApplicationUser GuestUser { get; set; } = null!;

        #endregion

      
        #region Claims
        public IdentityUserClaim<string> AdminUserClaim { get; set; } = null!;
        public IdentityUserClaim<string> GuestUserClaim { get; set; } = null!;
      
        #endregion


        #region Continents
        public Continent Asia { get; set; } = null!;
        public Continent Africa { get; set; } = null!;
        public Continent NorthAmerica { get; set; } = null!;
        public Continent SouthAmerica { get; set; } = null!;
        public Continent Antarctica { get; set; } = null!;
        public Continent Europe { get; set; } = null!;
        public Continent Australia { get; set; } = null!;

        #endregion


        #region Languages
        public Language Chinese { get; set; } = null!;
        public Language Spanish { get; set; } = null!;
        public Language English { get; set; } = null!;
        public Language German { get; set; } = null!;
        public Language Arabic { get; set; } = null!;
        public Language Hindi { get; set; } = null!;
        public Language Portuguese { get; set; } = null!;
        public Language Russian { get; set; } = null!;
        public Language Bulgarian { get; set; } = null!;
        public Language Greek { get; set;} = null!;
        public Language Japanese { get; set; } = null!;
        public Language French { get; set; } = null!;
        public Language Turkish { get; set; } = null!;
        public Language Serbian { get; set; } = null!;
        public Language Italian { get; set; } = null!;
        public Language Korean { get; set; } = null!;
        public Language Romanian { get; set; } = null!;
        public Language Hungarian { get; set; } = null!;

        #endregion


        #region Countries
        public Country France { get; set; } = null!;
        public Country Spain { get; set; } = null!;
        public Country UnitedStates { get; set; } = null!;
        public Country Turkey { get; set; } = null!;
        public Country Italy { get; set; } = null!;
        public Country Mexico { get; set; } = null!;
        public Country England { get; set; } = null!;
        public Country Germany { get; set; } = null!;
        public Country Greece { get; set; } = null!;
        public Country Austria { get; set; } = null!;
        public Country Bulgaria { get; set; } = null!;
        public Country Russia { get; set; } = null!;
        public Country Serbia { get; set; } = null!;
        public Country Hungary { get; set; } = null!;
        public Country Romania { get; set; } = null!;
        public Country China { get; set; } = null!;
        public Country India { get; set; } = null!;
        public Country UnitedArabEmirates { get; set; } = null!;
        public Country Egypt { get; set; } = null!;
        public Country Brazil { get; set; } = null!;
        public Country Japan { get; set; } = null!;

        #endregion


        #region Cities
        public City Paris { get; set; } = null!;
        public City Madrid { get; set; } = null!;
        public City Barcelona { get; set; } = null!;
        public City NewYork { get; set; } = null!;
        public City LosAngeles { get; set; } = null!;  
        public City Washington { get; set; } = null!;
        public City Istanbul { get; set; } = null!;
        public City Rome { get; set; } = null!;
        public City MexicoCity { get; set; } = null!;   
        public City London { get; set; } = null!;   
        public City Berlin { get; set; } = null!;
        public City Athens { get; set; } = null!;
        public City Vienna { get; set; } = null!;   
        public City Sofia { get; set; } = null!;
        public City Plovdiv { get; set; } = null!;
        public City VelikoTarnovo { get; set; } = null!;
        public City Moscow { get; set; } = null!;
        public City Belgrade { get;  set; } = null!;
        public City Budapest { get; set; } = null!;
        public City Bucharest { get; set; } = null!;
        public City Beijing { get; set; } = null!;
        public City NewDelhi { get; set; } = null!;
        public City AbuDhabi { get; set; } = null!; 
        public City Dubai { get; set; } = null!;
        public City Cairo { get; set; } = null!;
        public City RioDeJaneiro { get; set; } = null!;   
        public City Tokyo { get; set; } = null!;

        #endregion


        #region Landmarks

        //Paris
        public Landmark EiffelTower { get; set; } = null!;
        public Landmark LouvreMuseum { get; set; } = null!;

        //Madrid
        public Landmark RoyalPalaceOfMadrid { get; set; } = null!;
        public Landmark PlazaMayor { get; set; } = null!;

        //New York
        public Landmark CentralPark { get; set; } = null!;
        public Landmark EmpireStateBuilding { get; set; } = null!;

        //Istanbul
        public Landmark HagiaSophia { get; set; } = null!;
        public Landmark BasilicaCistern { get; set; } = null!;

        //Rome
        public Landmark Colosseum { get; set; } = null!;
        public Landmark Pantheon { get; set; } = null!;

        //Sofia
        public Landmark StAlexanderNevskiCathedral { get; set; } = null!;
        public Landmark CatedralDeSvetaNedelya { get; set; } = null!;

        //Tokyo
        public Landmark TokyoTower { get; set; } = null!;
        public Landmark SensoJiTemple { get; set; } = null!;

        #endregion


        #region Hotels

        //Paris
        public Hotel IbisParis { get; set; } = null!;
        public Hotel SaintMarcel { get; set; } = null!;
        public Hotel KraftHotel { get; set; } = null!;

        //Madrid
        public Hotel PestanaPlaza { get; set; } = null!;
        public Hotel CataloniaPuerta { get; set; } = null!;
        public Hotel HostalCentralPalace { get; set; } = null!;

        //New York
        public Hotel PrinceKitano { get; set; } = null!;
        public Hotel HiltonGarden { get; set; } = null!;
        public Hotel TimesSquareHotel { get; set; } = null!;
        
        //Sofia
        public Hotel HotelZOO { get; set; } = null!;
        public Hotel EurostarsSofia { get; set; } = null!;      
        public Hotel PremierSofia { get; set; } = null!;

        //Istanbul
        public Hotel EminPalace { get; set; } = null!;
        public Hotel HotelZurich { get; set; } = null!;
        public Hotel FlorinaHotel { get; set; } = null!;

        //Tokyo
        public Hotel LoisirHotel { get; set; } = null!;
        public Hotel SotetsuFresa { get; set; } = null!;
        public Hotel OakwoodPremier { get; set; } = null!;
        
        //Rome
        public Hotel FlaminioHolidays { get; set; } = null!;
        public Hotel AliusAndFreerome { get; set; } = null!;
        public Hotel AdMaioraSuite { get; set; } = null!;

        #endregion


        #region Rooms

        // Paris
        public Room IbisParisRoomSingle { get; set; } = null!;
        public Room IbisParisRoomDouble { get; set; } = null!;
        public Room IbisParisRoomTriple { get; set; } = null!;
        public Room IbisParisRoomApartment { get; set; } = null!;

        public Room KraftHotelRoomSingle { get; set; } = null!;
        public Room KraftHotelRoomDouble { get; set; } = null!;
      
        public Room SaintMarcelRoomSingle { get; set; } = null!;
        public Room SaintMarcelRoomDouble { get; set; } = null!;

        // Madrid
        public Room PestanaPlazaRoomSingle { get; set; } = null!;
        public Room PestanaPlazaRoomDouble { get; set; } = null!;
        public Room PestanaPlazaRoomTriple { get; set; } = null!;

        public Room CataloniaPuertaRoomSingle { get; set; } = null!;
        public Room CataloniaPuertaRoomDouble { get; set; } = null!;

        public Room HostalCentralPalaceRoomDouble { get; set; } = null!;

        // New York
        public Room TimesSquareHotelRoomDouble { get; set; } = null!;
        public Room TimesSquareHotelRoomTriple { get; set; } = null!;

        public Room HiltonGardenRoomDouble { get; set; } = null!;
        public Room HiltonGardenRoomTriple { get; set; } = null!;
        public Room HiltonGardenRoomApartment { get; set; } = null!;

        public Room PrinceKitanoRoomDouble { get; set; } = null!;
        public Room PrinceKitanoRoomApartment { get; set; } = null!;

        // Sofia
        public Room HotelZOORoomSingle { get; set; } = null!;
        public Room HotelZOORoomDouble { get; set; } = null!;
        public Room HotelZOORoomTriple { get; set; } = null!;

        public Room EurostarsSofiaRoomSingle { get; set; } = null!;
        public Room EurostarsSofiaRoomDouble { get; set; } = null!;
        public Room EurostarsSofiaRoomTriple { get; set; } = null!;
        public Room EurostarsSofiaRoomApartment { get; set; } = null!;

        public Room PremierSofiaRoomSingle { get; set; } = null!;
        public Room PremierSofiaRoomDouble { get; set; } = null!;
        public Room PremierSofiaRoomTriple { get; set; } = null!;

        // Istanbul
        public Room EminPalaceRoomSingle { get; set; } = null!;
        public Room EminPalaceRoomDouble { get; set; } = null!;
        public Room EminPalaceRoomTriple { get; set; } = null!;

        public Room HotelZurichRoomSingle { get; set; } = null!;
        public Room HotelZurichRoomDouble { get; set; } = null!;
        public Room HotelZurichRoomTriple { get; set; } = null!;
        public Room HotelZurichRoomApartment { get; set; } = null!;

        public Room FlorinaHotelRoomSingle { get; set; } = null!;
        public Room FlorinaHotelRoomDouble { get; set; } = null!;
        public Room FlorinaHotelRoomTriple { get; set; } = null!;
        public Room FlorinaHotelRoomApartment { get; set; } = null!;

        // Tokyo
        public Room LoisirHotelRoomSingle { get; set; } = null!;
        public Room LoisirHotelRoomDouble { get; set; } = null!;

        public Room SotetsuFresaRoomSingle { get; set; } = null!;
        public Room SotetsuFresaRoomDouble { get; set; } = null!;

        public Room OakwoodPremierRoomSingle { get; set; } = null!;
        public Room OakwoodPremierRoomDouble { get; set; } = null!;
        public Room OakwoodPremierRoomApartment { get; set; } = null!;

        //Rome
        public Room FlaminioHolidaysRoomSingle { get; set; } = null!;
        public Room FlaminioHolidaysRoomDouble { get; set; } = null!;
        public Room FlaminioHolidaysRoomTriple { get; set; } = null!;
        public Room FlaminioHolidaysRoomApartment { get; set; } = null!;

        public Room AliusAndFreeromeDouble { get; set; } = null!;
        public Room AliusAndFreeromeTriple { get; set; } = null!;
        public Room AliusAndFreeromeApartment { get; set; } = null!;

        public Room AdMaioraSuiteDouble { get; set; } = null!;
        public Room AdMaioraSuiteTriple { get; set; } = null!;
        public Room AdMaioraSuiteApartment { get; set; } = null!;


        #endregion


        #region Airlines
        public Airline Lufthansa { get; set; } = null!;
        public Airline BulgariaAir { get; set; } = null!;
        public Airline TurkishAirlines { get; set; } = null!;
        public Airline WizzAir { get; set; } = null!;
        public Airline Ryanair { get; set; } = null!;

        #endregion


        #region Airports
        public Airport ParisAirport { get; set; } = null!;
        public Airport MadridAirport { get; set; } = null!;
        public Airport NewYorkAirport { get; set; } = null!;
        public Airport IstanbulAirport { get; set; } = null!;
        public Airport RomeAirport { get; set; } = null!;
        public Airport SofiaAirport { get; set; } = null!;
        public Airport TokyoAirport { get; set; } = null!;

        #endregion


        #region Flights
        public Flight SofiaParis { get; set; } = null!;
        public Flight SofiaIstanbul { get; set; } = null!;
        public Flight SofiaMadrid { get; set; } = null!;
        public Flight SofiaRome { get; set; } = null!;

        public Flight ParisSofia { get; set; } = null!;
        public Flight IstanbulSofia { get; set; } = null!;
        public Flight MadridSofia { get; set; } = null!;
        public Flight RomeSofia { get; set; } = null!;
        
        public Flight ParisIstanbul { get; set; } = null!;
        public Flight ParisMadrid { get; set; } = null!;
        public Flight ParisRome { get; set; } = null!;
              
        public Flight IstanbulParis { get; set; } = null!;
        public Flight MadridParis { get; set; } = null!;
        public Flight RomeParis { get; set; } = null!;


        public Flight IstanbulMadrid { get; set; } = null!;
        public Flight IstanbulRome { get; set; } = null!;

        public Flight MadridIstanbul { get; set; } = null!;
        public Flight RomeIstanbul { get; set; } = null!;

        #endregion

        
        //Methods
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            AdminUser = new ApplicationUser()
            {
                Id = "62d28ee6-5a44-4529-bb9d-91cb7ee61ce0",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Stiliyan",
                LastName = "Iliev"
            };

            AdminUserClaim = new IdentityUserClaim<string>()
            {
                Id = 1,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Stiliyan Iliev",
                UserId = "62d28ee6-5a44-4529-bb9d-91cb7ee61ce0"
            };

            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "admin123");

            GuestUser = new ApplicationUser()
            {
                Id = "ebf07620-6aa8-4fef-9170-461d816c12f6",
                UserName = "guest@mail.com",
                NormalizedUserName = "GUEST@MAIL.COM",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@MAIL.COM",
                FirstName = "Bogdan",
                LastName = "Slavchev"
            };

            GuestUserClaim = new IdentityUserClaim<string>()
            {
                Id = 2,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Bogdan Slavchev",
                UserId = "ebf07620-6aa8-4fef-9170-461d816c12f6"
            };

            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "guest123");
        }
        private void SeedLanguages()
        {
            Chinese = new Language
            {
                Id = 1,
                Name = "Chinese"
            };

            Spanish = new Language
            {
                Id = 2,
                Name = "Spanish"
            };

            English = new Language
            {
                Id = 3,
                Name = "English"
            };

            German = new Language
            {
                Id = 4,
                Name = "German"
            };

            Arabic = new Language
            {
                Id = 5,
                Name = "Arabic"
            };

            Hindi = new Language
            {
                Id = 6,
                Name = "Hindi"
            };

            Portuguese = new Language
            {
                Id = 7,
                Name = "Portuguese"
            };

            Russian = new Language
            {
                Id = 8,
                Name = "Russian"
            };

            Bulgarian = new Language
            {
                Id = 9,
                Name = "Bulgarian"
            };

            Greek = new Language
            {
                Id = 10,
                Name = "Greek"
            };

            Japanese = new Language
            {
                Id = 11,
                Name = "Japanese"
            };

            French = new Language
            {
                Id = 12,
                Name = "French"
            };

            Turkish = new Language
            {
                Id = 13,
                Name = "Turkish"
            };

            Serbian = new Language
            {
                Id = 14,
                Name = "Serbian"
            };

            Italian = new Language
            {
                Id = 15,
                Name = "Italian"
            };

            Korean = new Language
            {
                Id = 16,
                Name = "Korean"
            };

            Romanian = new Language
            {
                Id = 17,
                Name = "Romanian"
            };

            Hungarian = new Language
            {
                Id = 18,
                Name = "Hungarian"
            };
        }
        private void SeedContinents()
        {
            Asia = new Continent()
            {
                Id = 1,
                Name = "Asia",                
            };

            Africa = new Continent()
            {
                Id = 2,
                Name = "Africa",
            };

            NorthAmerica = new Continent()
            {
                Id = 3,
                Name = "NorthAmerica",
            };

            SouthAmerica = new Continent()
            {
                Id = 4,
                Name = "SouthAmerica",
            };

            Antarctica = new Continent()
            {
                Id = 5,
                Name = "Antarctica"
            };

            Europe = new Continent()
            {
                Id = 6,
                Name = "Europe",                
            };

            Australia = new Continent()
            {
                Id = 7,
                Name = "Australia"
            };
        }
        private void SeedCountries()
        {
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
                Language_Id = 12,
            };

            Spain = new Country()
            {
                Id = 2,
                Name = "Spain",
                Capital = "Madrid",
                Population = 47_473_373,
                Continent_Id = 6,
                Details = "Spain, situated in southwestern Europe, is celebrated for its vibrant culture, stunning architecture, and lively festivals. The capital, Madrid, is famous for its art museums like the Prado and Reina Sofía, while Barcelona captivates with its unique blend of Catalan identity, exemplified by architectural masterpieces like the Sagrada Família and Park Güell designed by Antoni Gaudí. Spain's rich history is evident in its numerous UNESCO World Heritage Sites, including the Alhambra in Granada and the historic city of Toledo. Its culinary scene is diverse and flavorful, with tapas and paella being among its most iconic dishes. Additionally, Spain is known for its passion for soccer, with clubs like FC Barcelona and Real Madrid enjoying worldwide recognition.",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://cdn.britannica.com/36/4336-050-056AC114/Flag-Spain.jpg",
                Language_Id = 2
            };

            UnitedStates = new Country()
            {
                Id = 3,
                Name = "United States",
                Capital = "Washington, D.C.",
                Population = 341_223_461,
                Continent_Id = 3,
                Details = "The United States, located in North America, is the world's third-largest country by land area and population. It is a diverse nation, known for its cultural melting pot and vast landscapes, ranging from the bustling metropolises of New York City and Los Angeles to the stunning natural wonders of the Grand Canyon and Yellowstone National Park. The U.S. is a global economic powerhouse, with a highly developed economy driven by innovation, technology, and entrepreneurship. It has a rich history shaped by diverse immigrant communities, pivotal events such as the American Revolution and Civil Rights Movement, and iconic figures like Abraham Lincoln and Martin Luther King Jr. The country's political system is characterized by a federal republic with a strong emphasis on individual freedoms and democratic principles.",
                CurrencyCode = "USD",
                FlagImageUrl = "https://cdn.britannica.com/33/4833-004-828A9A84/Flag-United-States-of-America.jpg",
                Language_Id = 3
            };

            Turkey = new Country()
            {
                Id = 4,
                Name = "Turkey",
                Capital = "Ankara",
                Population = 86_116_034,
                Continent_Id = 1,
                Details = "Turkey, situated at the crossroads of Europe and Asia, boasts a rich historical and cultural heritage. Its largest city, Istanbul, straddles two continents and is famous for landmarks such as the Hagia Sophia and the Blue Mosque, reflecting its Byzantine and Ottoman influences. Turkey's diverse landscapes range from the Mediterranean coastline to the rugged mountains of Eastern Anatolia. The country is known for its cuisine, which includes dishes like kebabs, baklava, and Turkish delight. Modern Turkey is a secular republic with a parliamentary democracy, though its political landscape has experienced periods of turbulence. It plays a significant role in regional geopolitics, serving as a bridge between Europe and the Middle East.",
                CurrencyCode = "TRL",
                FlagImageUrl = "https://cdn.britannica.com/82/4782-004-4119489D/Flag-Turkey.jpg",
                Language_Id = 13
            };

            Italy = new Country()
            {
                Id = 5,
                Name = "Italy",
                Capital = "Rome",
                Population = 58_753_507,
                Continent_Id = 6,
                Details = "Italy, located in southern Europe, is renowned for its rich history, art, and culinary traditions. Its capital, Rome, is home to iconic landmarks such as the Colosseum, the Vatican City, and the Pantheon, reflecting its status as the center of the ancient Roman Empire and the Catholic Church. Italy is a treasure trove of art and architecture, with masterpieces by Michelangelo, Leonardo da Vinci, and Botticelli housed in museums and churches throughout the country. Its diverse regions offer a range of landscapes, from the picturesque hills of Tuscany to the stunning coastlines of the Amalfi Coast and Cinque Terre. Italian cuisine is celebrated worldwide, with dishes like pasta, pizza, gelato, and espresso representing just a fraction of its culinary delights. Additionally, Italy is known for its fashion industry, luxury car brands, and vibrant cultural festivals.",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://img.goodfon.com/original/5000x3333/c/cf/italy-italia-flag-of-italy-italian-flag-flag.jpg",
                Language_Id = 15,
            };

            Mexico = new Country()
            {
                Id = 6,
                Name = "Mexico",
                Capital = "Mexico City",
                Population = 129_388_467,
                Continent_Id = 3,
                Details = "Mexico, situated in North America, is renowned for its rich cultural heritage, vibrant traditions, and diverse landscapes. Its capital, Mexico City, is one of the largest urban centers in the world and is home to historic sites such as the ancient Aztec temple of Templo Mayor and the impressive murals of Diego Rivera. Mexico's culinary scene is celebrated globally, with dishes like tacos, tamales, and mole showcasing the country's flavorful and diverse cuisine. The country boasts stunning natural wonders, including the beaches of Cancun and the biodiversity-rich jungles of Chiapas. Mexico has a complex history shaped by indigenous civilizations, Spanish colonization, and a modern struggle for social and economic development. Despite challenges, Mexico's people are known for their warmth, hospitality, and cultural pride.",
                CurrencyCode = "MXN",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_Mexico.jpg/1024px-Flag_of_Mexico.jpg",
                Language_Id = 2
            };

            England = new Country()
            {
                Id = 7,
                Name = "England",
                Capital = "London",
                Population = 67_961_439,
                Continent_Id = 6,
                Details = "England, the largest constituent country of the United Kingdom, is renowned for its rich history, cultural heritage, and iconic landmarks. Its capital, London, is a global city known for landmarks such as the Tower of London, Westminster Abbey, and the Houses of Parliament. England's diverse landscapes encompass bustling cities, picturesque countryside, and stunning coastlines, with attractions like the Lake District, Stonehenge, and the White Cliffs of Dover. The country has made significant contributions to literature, art, and science, with figures like William Shakespeare, Charles Dickens, and Isaac Newton shaping its cultural landscape. England's monarchy, led by the House of Windsor, remains an enduring symbol of tradition and continuity. Additionally, England is renowned for its love of football (soccer), with the English Premier League being one of the most-watched and competitive football leagues in the world.",
                CurrencyCode = "GBP",
                FlagImageUrl = "https://media.istockphoto.com/id/486407806/vector/union-jack.jpg?s=612x612&w=0&k=20&c=KPRndA_Czak9T0w_Eq3GnhRaNxERiEiw2cjZe5GBY-E=",
                Language_Id = 3
            };

            Germany = new Country()
            {
                Id = 8,
                Name = "Germany",
                Capital = "Berlin",
                Population = 83_266_096,
                Continent_Id = 3,
                Details = "Germany, located in central Europe, is known for its rich history, strong economy, and cultural contributions. Its capital, Berlin, is a dynamic city with a thriving arts scene, historical landmarks like the Brandenburg Gate, and vibrant nightlife. Germany has played a significant role in shaping European history, from the Holy Roman Empire to its more recent reunification after the fall of the Berlin Wall in 1989. The country is celebrated for its achievements in science, engineering, and philosophy, with figures like Albert Einstein, Johann Wolfgang von Goethe, and Ludwig van Beethoven among its cultural icons. Germany's economy is one of the largest in the world, driven by industries such as automotive manufacturing, engineering, and technology. Additionally, Germany is known for its festivals, including Oktoberfest in Munich and the Christmas markets held throughout the country during the holiday season.",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Flag_of_Germany.svg/2560px-Flag_of_Germany.svg.png",
                Language_Id = 4
            };

            Greece = new Country()
            {
                Id = 9,
                Name = "Greece",
                Capital = "Athens",
                Population = 10_302_720,
                Continent_Id = 3,
                Details = "Greece, situated in southeastern Europe, is renowned for its ancient civilization, stunning landscapes, and vibrant culture. Its capital, Athens, is home to iconic landmarks such as the Acropolis, Parthenon, and Temple of Olympian Zeus, showcasing its rich history as the birthplace of democracy and Western philosophy. Greece's coastline is dotted with picturesque islands like Santorini, Mykonos, and Crete, offering crystal-clear waters and charming villages. Greek cuisine is celebrated for its Mediterranean flavors, with dishes like moussaka, souvlaki, and tzatziki delighting food enthusiasts worldwide. The country's cultural legacy includes renowned poets like Homer and Nobel laureates such as Giorgos Seferis and Odysseas Elytis. Despite economic challenges in recent years, Greece remains a popular destination for travelers seeking history, beauty, and hospitality.",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0a/Flag_of_Greece.png",
                Language_Id = 10
            };

            Austria = new Country()
            {
                Id = 10,
                Name = "Austria",
                Capital = "Vienna",
                Population = 8_977_139,
                Continent_Id = 3,
                Details = "Austria, nestled in the heart of Europe, is renowned for its stunning Alpine landscapes, rich cultural heritage, and historical contributions. Its capital, Vienna, is famous for its imperial palaces, classical music, and vibrant coffeehouse culture. Austria's architectural treasures include landmarks such as Schönbrunn Palace, Hofburg Palace, and the iconic Stephansdom cathedral. The country has a long tradition of producing influential composers, including Mozart, Beethoven, and Strauss, making it a hub for classical music enthusiasts. Austria's Alpine regions offer opportunities for skiing, hiking, and scenic drives, attracting outdoor enthusiasts year-round. Additionally, Austrian cuisine is characterized by hearty dishes like schnitzel, strudel, and Sachertorte, accompanied by fine wines and beers. Austria's commitment to environmental sustainability and quality of life consistently ranks it among the world's most livable countries.",
                CurrencyCode = "EUR",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/2560px-Flag_of_Austria.svg.png",
                Language_Id = 4
            };

            Bulgaria = new Country()
            {
                Id = 11,
                Name = "Bulgaria",
                Capital = "Sofia",
                Population = 6_618_615,
                Continent_Id = 6,
                Details = "Bulgaria, located in southeastern Europe, is known for its diverse landscapes, rich history, and cultural heritage. Its capital, Sofia, is home to ancient landmarks such as the Alexander Nevsky Cathedral and the National Palace of Culture, reflecting its long history as a crossroads between East and West. Bulgaria's natural beauty includes the majestic peaks of the Balkan Mountains, the sandy beaches of the Black Sea coast, and picturesque countryside dotted with traditional villages. The country has a rich cultural heritage, with influences from Thracian, Greek, Roman, and Ottoman civilizations evident in its architecture, cuisine, and traditions. Bulgarian cuisine is hearty and flavorful, with dishes like banitsa (a pastry filled with cheese), kebapche (grilled minced meat), and shopska salad (a refreshing mix of tomatoes, cucumbers, peppers, and cheese). Despite economic challenges, Bulgaria is a country of resilience, offering visitors a blend of history, nature, and warm hospitality.",
                CurrencyCode = "BGN",
                FlagImageUrl = "https://t3.ftcdn.net/jpg/01/01/18/68/360_F_101186804_qHCSqaphnoDq21DiftORwwDrjEApaewH.jpg",
                Language_Id = 9,
            };

            Russia = new Country()
            {
                Id = 12,
                Name = "Russia",
                Capital = "Moscow",
                Population = 143_957_079,
                Continent_Id = 1,
                Details = "Russia, the largest country in the world by land area, is known for its vast landscapes, rich history, and cultural heritage. Its capital, Moscow, is a bustling metropolis with iconic landmarks such as the Kremlin, Red Square, and St. Basil's Cathedral. Russia's other major city, St. Petersburg, is renowned for its elegant palaces, world-class museums like the Hermitage, and the picturesque canals of the historic center. The country has a complex history, from the Tsarist era to the Soviet period, and has made significant contributions to literature, music, and science, with figures like Tolstoy, Tchaikovsky, and Mendeleev leaving a lasting legacy. Russia's natural beauty includes the rugged mountains of the Caucasus, the vast Siberian wilderness, and the pristine shores of Lake Baikal, the deepest lake in the world. Despite its challenges, Russia remains a global power with a rich cultural tapestry and a diverse population representing numerous ethnic groups and cultures.",
                CurrencyCode = "RUB",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f3/Flag_of_Russia.svg/640px-Flag_of_Russia.svg.png",
                Language_Id = 8
            };

            Serbia = new Country()
            {
                Id = 13,
                Name = "Serbia",
                Capital = "Belgrade",
                Population = 7_113_869,
                Continent_Id = 6,
                Details = "Serbia, located in southeastern Europe, is known for its rich history, cultural heritage, and warm hospitality. Its capital, Belgrade, is a vibrant city with a lively nightlife, historic architecture, and picturesque waterfronts along the Danube and Sava rivers. Serbia's history is deeply intertwined with the Byzantine, Ottoman, and Austro-Hungarian empires, reflected in its diverse architecture, cuisine, and traditions. The country boasts numerous medieval monasteries, such as Studenica and Žiča, which are UNESCO World Heritage Sites. Serbian cuisine is hearty and flavorful, with dishes like čevapi (grilled minced meat), sarma (stuffed cabbage rolls), and ajvar (a roasted red pepper spread) being popular staples. Despite challenges, Serbia is a country of resilience, offering visitors a blend of history, natural beauty, and cultural experiences.",
                CurrencyCode = "RSD",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Flag_of_Serbia.svg/2560px-Flag_of_Serbia.svg.png",
                Language_Id = 14
            };

            Hungary = new Country()
            {
                Id = 14,
                Name = "Hungary",
                Capital = "Budapest",
                Population = 9_994_993,
                Continent_Id = 6,
                Details = "Hungary, located in Central Europe, is known for its rich history, vibrant culture, and stunning architecture. Its capital, Budapest, is famous for its grandeur, with landmarks such as the majestic Parliament Building, the historic Buda Castle, and the iconic Chain Bridge spanning the Danube River. Hungary's thermal baths, including the famous Széchenyi and Gellért Baths, are popular attractions offering relaxation and rejuvenation. Hungarian cuisine is hearty and flavorful, with dishes like goulash, lángos (fried dough), and dobos torte (layered sponge cake) delighting food enthusiasts. The country's cultural scene is diverse, with a strong tradition in classical music, folk dance, and literature. Despite its relatively small size, Hungary has made significant contributions to science, technology, and mathematics throughout history.",
                CurrencyCode = "HUF",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/00/Flag_of_Hungary.png",
                Language_Id = 18
            };

            Romania = new Country()
            {
                Id = 15,
                Name = "Romania",
                Capital = "Bucharest",
                Population = 19_706_234,
                Continent_Id = 6,
                Details = "Romania, located in southeastern Europe, is known for its stunning landscapes, rich history, and diverse cultural heritage. Its capital, Bucharest, is a bustling city with a mix of architectural styles, including elegant Belle Époque buildings and imposing communist-era structures. Romania's countryside is dotted with picturesque villages, medieval castles, and the stunning Carpathian Mountains, home to wildlife and pristine natural beauty. The country has a rich cultural heritage, influenced by its Roman, Byzantine, Ottoman, and Hungarian roots, which is evident in its cuisine, music, and traditions. Romanian cuisine features hearty dishes like sarmale (stuffed cabbage rolls), mămăligă (polenta), and cozonac (sweet bread), often enjoyed with local wines and tuică, a traditional plum brandy. Romania is also known for its contributions to literature, with figures like Mircea Eliade and Emil Cioran gaining international recognition. Despite challenges, Romania offers visitors a unique blend of history, nature, and warm hospitality.",
                CurrencyCode = "RON",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Romania.svg/1280px-Flag_of_Romania.svg.png",
                Language_Id = 17
            };

            China = new Country()
            {
                Id = 16,
                Name = "China",
                Capital = "Beijing",
                Population = 1_425_337_966,
                Continent_Id = 1,
                Details = "China, located in East Asia, is the world's most populous country and one of the oldest civilizations, with a history spanning over 5,000 years. Its capital, Beijing, is home to iconic landmarks such as the Great Wall, the Forbidden City, and the Temple of Heaven, reflecting its ancient imperial past. China's rapid economic growth has transformed it into a global powerhouse, with cities like Shanghai, Guangzhou, and Shenzhen serving as centers of commerce, innovation, and technology. The country's diverse landscapes range from the majestic mountains of Tibet to the bustling metropolises of the eastern seaboard and the picturesque countryside of regions like Guilin and Yunnan. Chinese cuisine is renowned worldwide for its variety, flavors, and regional specialties, with dishes like Peking duck, dim sum, and Sichuan hotpot enticing food enthusiasts. China's rich cultural heritage includes contributions to philosophy, literature, art, and martial arts, with figures like Confucius, Li Bai, and Bruce Lee leaving a lasting legacy. Despite its modernization, China maintains a deep reverence for its traditions and customs, making it a fascinating blend of old and new.",
                CurrencyCode = "CNY",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/2560px-Flag_of_the_People%27s_Republic_of_China.svg.png",
                Language_Id = 1
            };

            India = new Country()
            {
                Id = 17,
                Name = "India",
                Capital = "New Delhi",
                Population = 1_441_719_852,
                Continent_Id = 1,
                Details = "India, located in South Asia, is a vibrant and diverse country known for its rich history, cultural heritage, and spiritual traditions. Its capital, New Delhi, is a bustling metropolis with a mix of ancient monuments like the Red Fort and modern skyscrapers. India is home to a multitude of religions, languages, and ethnicities, contributing to its colorful tapestry of cultures. The country's landmarks include the iconic Taj Mahal in Agra, the holy city of Varanasi on the banks of the Ganges River, and the ancient temples of Khajuraho and Hampi. Indian cuisine is celebrated worldwide for its spices, flavors, and regional variations, with dishes like curry, biryani, dosa, and samosa captivating food enthusiasts. India's contributions to science, mathematics, literature, and philosophy date back thousands of years, with figures like Aryabhata, Rabindranath Tagore, and Swami Vivekananda leaving a lasting impact. Despite its challenges, India's resilience, cultural richness, and economic growth make it a dynamic and fascinating country.",
                CurrencyCode = "INR",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/India-flag-a4.jpg/1280px-India-flag-a4.jpg",
                Language_Id = 6
            };

            UnitedArabEmirates = new Country()
            {
                Id = 18,
                Name = "United Arab Emirates",
                Capital = "Abu Dhabi",
                Population = 9_567_209,
                Continent_Id = 1,
                Details = "The United Arab Emirates (UAE) is a federation of seven emirates located in the Arabian Peninsula, known for its modern cities, luxurious lifestyle, and rich cultural heritage. Its most famous city, Dubai, is a global hub for business, tourism, and entertainment, renowned for its futuristic skyline, extravagant shopping malls, and iconic landmarks such as the Burj Khalifa, the world's tallest building. Abu Dhabi, the capital of the UAE, is home to cultural institutions like the Louvre Abu Dhabi and the Sheikh Zayed Grand Mosque, showcasing the country's commitment to arts and heritage. The UAE's economy is fueled by oil wealth but has diversified into sectors like finance, tourism, and real estate. Despite its rapid modernization, the UAE maintains its traditional values and customs, with Emirati culture characterized by hospitality, respect for tradition, and a strong sense of community. Additionally, the UAE is known for hosting international events like the Dubai Expo and Formula One Grand Prix, further solidifying its position as a global destination for business and leisure.",
                CurrencyCode = "AED",
                FlagImageUrl = "https://media.istockphoto.com/id/472330093/vector/large-image-of-the-united-arab-emirates-flag.jpg?s=612x612&w=0&k=20&c=kUmMdjXjTQKJoijQEokPD6iLDSURrbp_6nT9MtNODTY=",
                Language_Id = 5
            };

            Egypt = new Country()
            {
                Id = 19,
                Name = "Egypt",
                Capital = "Cairo",
                Population = 113_903_534,
                Continent_Id = 2,
                Details = "Egypt, situated in North Africa and the Middle East, is renowned for its ancient civilization, iconic monuments, and rich cultural heritage. Its capital, Cairo, is a bustling metropolis with a mix of modernity and historical treasures, including the Giza Pyramids, the Sphinx, and the Egyptian Museum, home to a vast collection of artifacts from pharaonic times. Egypt's Nile River, the longest in the world, has played a central role in the country's history and sustains much of its population through agriculture and tourism. The country's Red Sea coast is famous for its pristine beaches and world-class diving sites, attracting tourists from around the globe. Egyptian cuisine is flavorful and diverse, with dishes like koshari, falafel, and ful medames representing the country's culinary traditions. Egypt's cultural influence extends far beyond its borders, with its ancient wonders and mythology inspiring art, literature, and films worldwide. Despite challenges, Egypt remains a captivating destination for travelers seeking history, adventure, and timeless beauty.",
                CurrencyCode = "EGP",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Egypt.svg/800px-Flag_of_Egypt.svg.png",
                Language_Id = 5
            };

            Brazil = new Country()
            {
                Id = 20,
                Name = "Brazil",
                Capital = "Brazil",
                Population = 219_624_301,
                Continent_Id = 4,
                Details = "Brazil, located in South America, is the largest country in both area and population in the region, known for its stunning natural landscapes, vibrant culture, and diverse ecosystems. Its most famous city, Rio de Janeiro, is renowned for its iconic landmarks such as the Christ the Redeemer statue, Copacabana Beach, and the annual Carnival festival, one of the largest in the world. Brazil's Amazon Rainforest is the largest tropical rainforest on Earth and is home to an incredible array of plant and animal species. The country's cultural heritage is rich and varied, with influences from indigenous peoples, African slaves, and European settlers shaping its music, dance, and cuisine. Brazilian cuisine is a delicious fusion of flavors, with dishes like feijoada (a hearty stew), churrasco (barbecue), and brigadeiro (chocolate truffle) being popular favorites. Despite economic and social challenges, Brazil's warmth, energy, and natural beauty make it a fascinating destination for travelers from around the globe.",
                CurrencyCode = "BRL",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/2560px-Flag_of_Brazil.svg.png",
                Language_Id = 7
            };

            Japan = new Country()
            {
                Id = 21,
                Name = "Japan",
                Capital = "Tokyo",
                Population = 122_844_590,
                Continent_Id = 1,
                Details = "Japan, an island nation located in East Asia, is known for its unique blend of ancient traditions and cutting-edge modernity. Its capital, Tokyo, is a bustling metropolis with towering skyscrapers, high-tech innovations, and vibrant street life. Japan's cultural heritage is rich and diverse, with landmarks such as Kyoto's temples and gardens, Hiroshima's Peace Memorial Park, and the iconic Mount Fuji symbolizing its spiritual and historical significance. Japanese cuisine, including sushi, tempura, and ramen, is celebrated worldwide for its freshness, quality, and meticulous preparation. The country is renowned for its contributions to technology, manufacturing, and pop culture, with brands like Sony, Toyota, and Nintendo shaping global trends. Japan's society is characterized by a strong sense of community, respect for tradition, and emphasis on harmony and order. Despite its densely populated cities, Japan boasts serene natural landscapes, including cherry blossom forests, hot springs, and scenic coastal regions. Overall, Japan offers visitors a captivating blend of tradition and innovation, making it a fascinating destination for exploration and discovery.",
                CurrencyCode = "JPY",
                FlagImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Flag_of_Japan.svg/1200px-Flag_of_Japan.svg.png",
                Language_Id = 11
            };
        }
        private void SeedCities()
        {
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

            Istanbul = new City()
            {
                Id = 4,
                Name = "Istanbul",
                Population = 16_047_000,
                Area = "5 461 km²",
                Details = "Istanbul, the largest city in Turkey, is a mesmerizing blend of cultures, history, and modernity. It straddles two continents, Europe and Asia, and is known for its stunning architectural wonders such as the Hagia Sophia, Blue Mosque, and Topkapi Palace. Visitors can wander through the bustling streets of the Grand Bazaar, cruise along the Bosphorus, or savor delicious Turkish cuisine in traditional meyhanes (taverns). With its rich history as the former capital of the Byzantine and Ottoman Empires, Istanbul offers a unique and unforgettable experience for travelers.",
                Country_Id = 4,
                ImageUrl = "https://emerald.bg/web/files/excursions/Excursion/50/images/thumb_920x616_Istanbul%20Emerald.jpg"
            };

            Rome = new City()
            {
                Id = 5,
                Name = "Rome",
                Population = 4_332_000,
                Area = "1,285 km²",
                Details = "Rome, the capital city of Italy, is a timeless destination steeped in history, art, and culture. Known as the \"Eternal City,\" Rome is home to iconic landmarks such as the Colosseum, Roman Forum, and Vatican City, which houses St. Peter's Basilica and the Sistine Chapel. Visitors can wander through cobblestone streets lined with ancient ruins, marvel at Renaissance masterpieces in museums and churches, and indulge in authentic Italian cuisine at trattorias and gelaterias. With its blend of ancient wonders and modern delights, Rome offers an unforgettable experience for travelers seeking to immerse themselves in the heart of Italy's rich heritage.",
                Country_Id = 5,
                ImageUrl = "https://media.timeout.com/images/105211701/750/422/image.jpg"
            };

            Sofia = new City()
            {
                Id = 6,
                Name = "Sofia",
                Population = 1_288_000,
                Area = "492 km²",
                Details = "Sofia, the capital city of Bulgaria, is a dynamic metropolis with a rich history and vibrant culture. Visitors can explore its diverse architectural heritage, including ancient Roman ruins, Byzantine churches, and Ottoman mosques, alongside modern landmarks like the National Palace of Culture and the Alexander Nevsky Cathedral. The city also offers charming parks, bustling markets, and a burgeoning culinary scene, making it a fascinating destination for travelers looking to discover the unique blend of influences that shape Bulgaria's capital.",
                Country_Id = 11,
                ImageUrl = "https://media.tacdn.com/media/attractions-content--1x-1/10/7d/eb/99.jpg"
            };

            Tokyo = new City()
            {
                Id = 7,
                Name = "Tokyo",
                Population = 37_115_035,
                Area = "2 194 km²",
                Details = "Tokyo, the capital of Japan, is a bustling metropolis where tradition meets innovation. Visitors can explore the city's iconic landmarks such as the historic Senso-ji Temple in Asakusa, the futuristic skyscrapers of Shinjuku, and the serene gardens of the Imperial Palace. With its vibrant neighborhoods, bustling street markets, and world-renowned cuisine ranging from sushi to ramen, Tokyo offers a captivating blend of old-world charm and modern excitement for travelers to experience and enjoy.",
                Country_Id = 21,
                ImageUrl = "https://facts.net/wp-content/uploads/2023/06/45-facts-about-tokyo-1688094762.jpeg"
            };
        }
        private void SeedLandmarks()
        {
            EiffelTower = new Landmark()
            {
                Id = 1,
                Name = "Eiffel Tower",
                Address = "Champ de Mars, 5 Av. Anatole France, 75007 Paris",
                Details = "Completed in 1889, this colossal landmark, although initially hated by many Parisians, is now a famous symbol of French civic pride.",
                City_Id = 1,
                TicketPrice = 40m,
                ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/15/a3/a1/c-emeric-livinec-sete.jpg?w=1400&h=-1&s=1",
                IsActive = true
            };

            LouvreMuseum = new Landmark()
            {
                Id = 2,
                Name = "Louvre Museum",
                Address = "99 Rue de Rivoli, 75001 Paris France",
                Details = "The Louvre Museum, located in Paris, is the world's largest art museum and a historic monument in France. It houses thousands of works of art, including the renowned Mona Lisa and the Venus de Milo, spanning from ancient civilizations to the 19th century.",
                City_Id = 1,
                TicketPrice = 46.46m,
                ImageUrl = "https://media.cntraveler.com/photos/57d961ce3e6b32bf25f5ad0f/16:9/w_2560,c_limit/most-beautiful-paris-louvre-GettyImages-536267205.jpg",
                IsActive = true
            };

            RoyalPalaceOfMadrid = new Landmark()
            {
                Id = 3,
                Name = "Royal Palace Of Madrid",
                Address = "Calle de Bailen s/n, 28071 Madrid Spain",
                Details = "Luxurious, over-the-top rococo palace with over 2,000 opulently gilded rooms.",
                City_Id = 2,
                TicketPrice = 43.14m,
                ImageUrl = "https://cdn.britannica.com/37/242537-050-A7EB558F/Royal-Palace-Madrid-Spain.jpg",
                IsActive = true
            };

            PlazaMayor = new Landmark()
            {
                Id = 4,
                Name = "Plaza Mayor",
                Address = "Calle Gerona 4, 28012 Madrid Spain",
                Details = "Huge plaza packed with cafes, bars and tourists.",
                City_Id = 2,
                ImageUrl = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoGBxMTEhYTExMYGBYZGh8aGhoZGyAcHBoaGhoZGhwZGRoaHysiGhwoIBwfIzQjKiwuMTExGiI3PDcwOyswMS4BCwsLDw4PHBERHTIoHykwMDAuMDAwLjAwMC4xMDIwMDAuMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMP/AABEIAK4BIgMBIgACEQEDEQH/xAAbAAACAwEBAQAAAAAAAAAAAAADBAIFBgEAB//EAEkQAAEDAgMGAgUIBwcCBwEAAAECAxEAIQQSMQUTIkFRYQZxFDKBkaEVQlKxwdHh8AcjM1NikvEWQ3KCorLSwtNEVHODk6PiNP/EABkBAQEBAQEBAAAAAAAAAAAAAAABAgMEBf/EACkRAAICAAYCAgICAwEAAAAAAAABAhEDEiExQVETYQSBFHGh8FKRsSL/2gAMAwEAAhEDEQA/AKg1wipkVwivunxgZFcipxXDQAyKiaIRUCKA4agakRXDQ0DVUCKKRUCKgBkVE1MioKBnQx15VlsqRAiompkVEioCJqJqRFeihSBFcipxXIoCEV6KnFeihCMV2K7FdiqLORXYroFeArSRls8BXQKmTMa2EfEm3vroFWJJaEQKmE11KamE1syeSmppTXUpoiU1SHAmuhFESmiJRWi0BDdSCKMEVIIoKAhFTCaKEVLJQlActeo+SvUFECKiRRSK5lrgdQJFcKaMU1HLQASKiRRimolNUACKiRRymoFNQAyKgRRSKgRQAiK4Xsqcl4WoWm3CFkEjmdY8zRCKTx6oU13X9cJ/6q54jSWvaOmGnf8AsIRUSKKRUSK0YBEVyKLFcIqFBRXIosVzLQgOK9FEy11NUEUNzU1MGmsM8j5yPb+FXmzmGHLSJOmv21JSymowzGXLcV1KK27mwAoCRPQxB7aa0jjPD+RZgWknyA6dakcWLLLBkUGIWSlpJnhQY6AKccNulwaEE1b7RwU4hLaLDcJXHYOuX/1UgtsA2q4Mk46dsziwaevSApTREpqSUUYNHpXc5UCSmipRU0ooiUVbFEEooqUVNKKKhFLLQNKKkG6OluphupZaF93Ug3TG7ru7pYoX3depnd1ylkoSyV7JTO7r27rjZuhXJUSimi3XC3SxQsU1EopgoqKk1bAspNDUmmVJoak1QLEVApphSaiU0AuU0rtzBkIbc+aTbivKSZtkgCU9aeUKS29tQlpLaWzlQIz5iLlSlGBly3mNdBXl+TKkv2d/jrV/oIBa4jt0rhTRm+ISCD5EGO1q4U13RxYAprmWj5a5lqgDlr2Wi5K9koQEE0VpKeYmuhFSDdaA3hW2Z4xHkavtmP4Vs2zH3Gs222nnM9vvpzC4sIMhA9on665zhZ0jOj6Dg8Y2sAAfCmn8CFDNkzEA25nte1ZLZ/ikpgZAfYPsFaXAeIgoTuz7onsCqB8a8OJhyjrR64TjIwO0tnv+mNgwouJyetojLnIjJAA8zdOpq7f8MIbSkqix4lcz2SOnek29trcx+Gc3I3UhJWpxWUApWhQUMmXMM3zZEwJ1r6TiMElaYtHKsYeLKKos8NSdnzpDbYMIav1Ik/cKM/s1XzlBAPTX2k1o8TswouPVHSqxzBqUokAf5psO1eqOLZweHRm8RhUJJCSVd/zrQkt1dYzDJ0sO6jr5c6RDQ5V6oTtHnlCgKW6KhuipaoyW61ZKApbooboqW6KlupmNUL7uvbumg3Xd1UzDKK7uvU1uq9TMMp75IUdKE7stxPzapW/Hil8TbaI5wo69+YppH6QHhqyg+014fOz0+JDC8KofNNAU3XsV49Wle7cwyEriQlRUFEXEjMJOh91LYjxfm1wyfYs/8a0vkrlGXg9BFJqCk0jiPEBCC4WClAMFcqygnkVZYGo586CdvH92P5vwrovkQ7M+GRYFNQUiq5e3D+7+JM2JjToCfYagnbsiQgEdQqfsp+RDsnil0WKkUMopRraq1mEMFR1hMqMdYCaGjbYUJCAR/i/Cr+RDseKfR7ajLqgcjeZIIkg3BJgWj76Qx6i6yGd2pITlUSFAyQnWMnPUXtHOr/ZeJ3rbgKcvE0NerkHpFqR2dhlreWA+tO7iFBQkw4hsWy2tB9kV8z5GI5TbT0R9DAw1GCT3borthtFtxbSsyTAISqx5zaBpb31bEVXeN3MuIIbBU4lc85AyJvw+f11SI2o/OpPa/wB9evCx8sEmjy4uFcrNXlrmSswraOInKZB7lX2mjJU+TxPqB6X+GgNdPyV0c/CzQ5K6G6oZWn1n3D7SPeacweJUhQVmJAB9YlQNjqCbij+XFLYq+O3yWm6qQbqsxGIcCjK1TzmQZ7g3BoKccsmM6pHmKkflpq6D+O73LsN1MNVRKxqxHGq/nFoOvuqYxTn01nyk/VWvy49D8d9l82kg2qG18M6+lKWwVrQc5APqouLz1VHuqiGIcN86/eRW7/RximxhcShRO+LiZJBCsmUQOK5AKTp1FcMf5GaNJHXCwcsrbMnsnbxaw7rIbneZpWTBTKADAKSCRrfryrZfojx7oY9H3ctNyQ7NyVKJylMcXO9oAAqlwOxlvBCUvlAUWhBCTBUjMowbwMmnl0FC2h4qdwDWGShIXnbKipRy6KMWSL2NeOEm5JPk9U4pJtcM+vgBQg0njNmg3Hw+2vlLX6YMQP7hs+aj91NYT9LGMU4FFloNlMZDMk8lJVY/WK700cLTNRjsIB6wi+oF/ao6eQqr3I60hi/0iuOCDhmr9FKqvPipfJlA15m8mvTh4yW5xnht7GhS1Rkt1mB4sc/dI95og8Wrid0j3muvngc/FI06W6KlusuPFzn7pHvNTR4udOjKD5ZqnniXxSNOG6luqy48Yufuke8/fXv7ZO/um/j99TzRL42ajd16sx/ax/8AcJ9yvvrtPPEeNmBw6igZ0swI1lUden5mjNbRUowEA9uI/ZV7gNtspwe5U4krG8tcqlSG0i+h9Wo4B1LeVxcIQTHERl1SdUkxXypTakl2fUhhRcJSe62XZUbZ2pvnN480M+UJ1UBAJvGXvXEY05ZDfDGsqNh3Ka0/ibarOIxQOHyrG7Qn9WAAFZlyL+dCVtdhth5twpz5FNhMcWYhEG+kZTeosSTk1Wn/AESwYqEZXq910Ujm01bhTRa4FELJuOnPLpYUsy5lTKWyExM8RGkzpV+na7Aw7suIK1IQgJF1Sl1SzfQWPWjtbZw4wpbUtG8G84dVcTTaB21Brbk7+jCgq+6+uzPocK0ghtRuTICuikn5vQq91CwabSltRB/xEHrHDBrS7N2wyhjKpxAWCs5Sb8Ta0i4t86p+HdsMt4dhtx1AWglRC80iXMwkgEaAUTboSilddlNsrai217xprMbpuFEciRZOulI4dIBOVtesGyjfoRlie1afYO12UtNhxxCCHVOEKnQoCQZE6nlraobG2w2lpaVuJBLy1iZ9VWYBQPS+mtS26Dildcbeyt2RjnP1gbbJjLmOUqKTm4ZSQLzNu0UFlDyQvJmzWJhMkcQUJgSLwfdVtszaAnFOCSFvZk2JCgXVKGWNDfnSmB2sG14hyQS6GxofmKSTPT2fXWU27s1JKLVMjtlotPqU4yhZOi1KcEwBwjI4gc+Ym/OlmEklWXBtSk2BL8mVC4G9+/SrDxJtEOODKpIhRVxA2nJpGvq1zZe1m2syiTKlkm2mscrXtWrdIxSt2BZDi1IIwjJzyUqIeIKUkCQreQRJjoOtQdxKiSk4RpRTCssPGBAAMbywIIg9x1FG2fttLS2CVJ/VNFHqmCSXCEgm5HEJ/Cl3toJ3j7wWBvWW2oIMylDSSVTYXRFu1qW7YqNL+RnEhxCsisG0SRwwl45iZGUDezMTbWp5EoaK14dlCSFkiHQoJQOIjM5Fx0nnzFWGysX6U/h0pUkbtSVFS5+a0oEzzVZVjqAa7tPDNKdbQh1S1NTmUUwnKAonX1b2kVE2STimyl2e404gqYYyqzAr3qyVAwJQmCJQQZBMKEwNARJWIaBSVYdjiEnieVEg3P62ALcponix1pCwtlOYpHEuUlH6y2UieJXCOUWjlFZ/GNIO8DOeIGUEgTJGaeQ099b9mE+DSelklsehMKDiZbgOnOlYE5RvOI5SPwqQxC2294cEwlIjk6ICrBRzOWBNhFjPLnA7SCnsM7I/UiLJJ0Tl4QLK0m/MVzFbRDmEOHJgqCSTlgAhxC4nLpw2rFvQ6JLX+CLeNUpc+hsSpOcqO+gjXUOQZEEfCnNn7SxGcbvDNtqJgqCXrFQkggqPK+mhnSlsBtBDZPFJDKG021ytZCbjqDe2lWKtutnEbxBJSXW1XTEZcOhozGlwTz0pdiloKtYrEtFKEhOY5FJ4ZV6mUEQOij105VW7dwbi0YfegSEKgHUJzxJCoj2dqtG9pNpxjD5UmG20jQ5vVMQkazmF7a1FnGB13DqFwhtQURoP1oVfpa9ZcnFJo6QipSyvYzScG0PWHxSPt+2rbFbRQrCtYZKCA0sqCwtN0kKEQdNZ1rWeJX8N6Nhkt7pTls4byrVOSOKO5PxqLLuEGCdStTQcywlJUnODkSICOsz8arxJW16CwY5VLt1RjEGRwpze1J+qi+klTZQgGDMwQYPDEETOnxrZeEcXhkph/dIASYCrEmTBgWNqh4MxWHTAfDaEzJz2zCAJtrcGinJ17/gPCir9PT2Y1CwZhMxrF47dffR2MYAFJgg6QOQIIM9Nfh79T4bxWHS8S4UJbK1HjsCDBsRy7f0o+ycfh/S3VHIloumFGySnMqwI7EUU5Oiywoq/SX2YplYFozEazqLaWTRsLtBtKrgCDyPMHQiK2uDxuF9Ndu2GiYuYSU5QLfy+2q1jK5iFqQ0SkOFWbLwxmnUWFZniSikzeFgQm2m60szeKxIKs6rWAvMWtzRUUYoEykJPkFG/mE1uPE+PYWwlLakqUFoICRmkBlCTbnxSPMGobCWy2psPhLaVKlQcGWUwPeKSxJqSjx2SODB4Tnz0Y75SHb4/8K9V3i8XhytZlN1E6DmT3r1c/NidHT8fB7M1h8KynD7zKkqLOaFAEZr3voaf8HuMOqcQpCUndLUEwIKhl7Qq02NZobQcylGY5CmAmBbTtdMzbpRsI+tn9YXEtEiEkJBVBieEDQivRJRk062OEZzhFrs0O0cAxmRlaQBkk5UgXC1iYHYCnPQ8OphxTpQClADcpSZUpNhJEzqfMVm/ll5zibfS4oJhQUhOaATdKVJsL8qmjbL5bUlL8Aou3lSMxSABACYUJGkzeubilJt8nRTcsNRXD113LrD7PwpYeUrdZ0BORISLyUJXJI1SVRbqKLhtlsFolTTVmVrHCmcwjnHeap8G9jilwJWMiwCuyYKlBCgfUIGg0iYp3DIx+7WEOgo3ZK0xmtlzXO5IAJA59q04q/r+swpSr7/qLLYWw8O62srQ2Mja3IypuUzzI8q94V2Jhn15HEtga+qm8T1FIbMcx0Q26kBSCFpSkerJB0ZIA9te2SrGIhxt1CL5VExeVQABuiJMxUSWn6/37NtyqX7729EcFg2t2g7lslToSqUiAjdOLntxJSJ0v3p7Y2x8O4+W1IbCSsicqTAEdRyvVZhG8UtAKVtjKqReBoEAjK2RPGRfrRMM7jG1Z23EJUFqSlRymbTybMnuetRJKvsTlJuXG3OxY4LDNNKxYSlISlxKdBBSHoExyiqw4dlWIdaABQkoA4jbMhpSoIN5UTr17UXC4V91bynHEpyqTJFsxU7cnKkX1M3pQ7IxBBWAeMAzYSEr3aZvpIyjSkVSdMzittq11/wv8Xs5h3FOJUY4ZNzOaUgSeeoqOK2YwkLbAtvSAc5JgEpmDbkB7DSeMw2KbfIacXmygW14b6Adhp0pR7B4lIUtbikqSswITchVzmmcwM8gO/KtPg5rn9FydmYZtxpSVTIWVZiSIty5iOXOh4fZGHUxvCTMXGY/vUp/2k+2q84XFrcQHFuAqlIJCSYERqRaSb/XFRbw2NLaUhS8hEoGZMQlwgGOQzSPOnL1JwtCyedaGKaUkwP1hUpRsN2y7GY8xCoJ1N6rMc9iXlpXhmSQprMQlNwlzjAVEgECDroe4qG0dh4iQhMrgBaym8BZSmCB7j51Z7jFtFKytSC4shYGXkYPzSQCAeo08qLZGZK5MzDOzcSHMrzCsrmUQohsRnSoLk6gQdORNaPwlsbDrw6lqdC173KAFKSUonhzDWTGYcoUIqTmGxSlNqccWZUoICkjkDEnLaSqOmtJbO2XjCM8qJhCJBtCTCEgk3jMr3npV4CVSNDh9l4ZaiVCRvm2xEjhUFA6czAvXmsBhllluJTMkDNPqkkzNp7RpVUnZ+JDhbbWsnMhVlZeNYOWRpNiJvoaAnZ+JSEELyqzZE5SPVUkmQUnprMa1Oje1lq5s9hC2wkGFtJCtdVhwmRpExFJ7CYZU+nMB+2WkRaEpCiiCI6UFvAYlXruGCiZJBNs4QL3uEmImIruE2DiCpJiAVAkyNVJK57kpk0SWob2DYXCNLfwyDBQ4k541lKWIuNLrVXFsoCsKBoWRMkn1nZIE3HOl2dnYha0btUiE5YGmdCZgzAsj2ZaHuXkoZSCkrW3In5o3ohIInUgG9+Wlc5pONNnXBbjO4q2N7T2PhgHcrKcyX0tiNClSXFE9zw0ziNj4f0feFlKlbh9cnWWW2ikT/nPuFV2Mdx27lSAUbwQZQCVKQsgqUACVZbjXXyogXtE4cjKC1lWFTuyboClJBImMuSb6RVcY5vrY0pTyJe97/gsfCOwsPiUpzNIA4TBAnicUlXlZNd8K+G8O/CVttpk3OUdE8iO9Vfh93aDeVOHKUFRjLwKMZoBEpMnMVakcqnsvG7RF2CEGSAIbMgZSLBsydOlSo6f2yuU6lfa52LXYvhzDuuqbLbaRmUJKQdCIHxNCRsTDh91vdNZQtwCQPVbDhECOL1U0lhsZjwteTKlWYgTu5UL5iYQZPq8utCxKcWHA2htAUlZEEJAQ5czAT1BiZ5eRKKpf2xPEmm/0vr2XiPDuFOJUyltopzZc2UHRKJMDuSSKSb2cy3iFBDaUjelFhHDnIi3YUF3HY1lajCQsKTEpbGZSwCQU5DF8oAjrPSkl7VxOZThRCQbuKCUgGTJJSIkmYAJmuc1GX/lPk7YUsSFyktKVa+ty82nsDDejpeDbZWtaQYTyU2V8+/1d6lsTZTLxSwtCIKoGYTEDkKrUbbxLyd0hTTgB4EAtpJgFMnMkScvITqel+MY/Go4wA2tKgE+pqqxmEG85Rcdaksimm9uhhyxJYTjHV9kdo7Nw6XXEhlEBagOEaBRAr1KvbdVmOfeFUnMYauqb8uteqVHs65p/wCJkcO0AUlSkwInW4BHaKU2lic6ydZ51eJCNEuSI7jn0vVanZ7SlkLxCE3gZW3Fn/aBX0MnR8Z4jluV+AdKVykgEXBJgW71aYgpUSpKkgG8X536RTbOzdmplK8Q4TeeEpA9mT7asXWMOkAIxFosClWnmkW91TJ2WOI47ENm7bQ2yW1H1ss2vCQEg69jVxgPEGGQ0+jfD9Y2EDgVGkHyF+lZv5MeLqRvWwkRmzOgBQKiYHzjwkDT4irvZXg9l5Si5tZpkzKUGCDEfPU4n3a1HHn6KsR1l+xzY+3MMyFy9q2pIhBgkmYMiQOWlL4Pa+GDSm1OXlKhlSYJQvPHUTAv3oG1PB+KU44MHiGcQEgcLLySU3iV5jCQb6nlV+5+jF514lGKbZaypgZt6sKjikAgR/mrNJVXBvO3d86sz2xdoMNJWFLIkgiBNwUqjX+Gus45rLGeJd3lkg6iADxVoPE/6Mn0ceFeStCUcSdFZgDKtSL252rObT2epsMJkpWWhveKRveYsY9xrEpKKzPgquTrsbY2o0M8qKkuEKUEoJISFqJuRGtpB+2jM7ZbS2EKLvq5SSiwl/eWv007mo7Q2UhvBIdBIWpScxza/tRAOo0E1i8Dtp1x1tC3FFK1pSpMmIKgJEnUTz6XmrBJq1yJylm14N5hPEbYxAdJVz0SJ5A8+gHvpfaO2Wlbw5lStZVGXkVKIi8c6zfjFws4haEGONy8AnhJAEm0WFM7fcCMNh3UiFOMpUefEpa5Pwt0EVa2JdWaHG+IGHFpUXHISDqmYKlJUBrYDL8aix4iYyNIJXCWyk8Ii7q3OvQ1nPDKt7hsUpRJLe6yqNrLcGoHOEkT/EaHsNhw4tlDqgpta4ISdBciJAPLnr7aVuTNsfTfC20VPNv+huJaKchcUWlLUsneFPrOQkWOgpF3xBtgaHMOoQmPvFL/AKNllteOCvVCUBMGdC7PlqB7KvcA42NUoUpWdUFKYsIAMmeU26gdRXF3mpHRU1bKP+1W2L/9tP31V4TxO6VL36spKwSEtyCQVFRVJNx0jma1GD4YzlBJBVYJBEkxMXTCQBlNuLmZrC7Pwm+xjTaindrdXn0mDChl5zYj21qN3TI0krRfYLbrSXSvM7BW2qyPoby0T/EB764jbLKVNmXSUzIyDUtrTaTcCR7qxu0Uu7x3duIShtBWASOIJNwoEXPIDy71beOljDjD7uUhbSFKg34lOFUdTcCdYArpRi9y9+XmAlN3AQgJ9ToFTN+p+FE/tM0lKAC7KSg3R9FpSDz6q9wFUGynQvZWIxJ/aIdyAn6ISVgW7mCecedC/R2+p955LqlLyMrcEmOIJiLapvp2HelaFuzQ7A200yASXVQAJDJ5JcHXWVR76rFbTZDjXEoIQ2lHEhWuYk6TzFvwrJO+IsQlxQDrkJMJSFGCATJJmZP2mtP44Y9HDaUKIVuQoqUfnF1d/jFSUU9GIYji7RebR23hXMO22HwTvUqPAoQEs7vpeT06V1vxBhRhtzvrkr+YqONptAvHVJrMeD1pfxKUrWVpCVKUJ5AGND1INV2HxBdeS0lapU4lBINk5lBIiOcnSs7u6fRVJpVxdm78N7fwjDuZxxUgQkhBKTJUq4idTbTSveG9tYZlYK3Rob5FG5CY5TqKyPixxbWIdbbDgCQAkpMpBKZuSZo/jsqw+IU22VJCUagkjNmWmVH2VVSrTYrnJ3fO5qdjbYwyHQtTlpUZ3arTYGCBz6V4bVYOIU8HoSXc5O7UYus3BAms543SrDKbQ2pSYa4lDmuSJV5mjeIMI63h8OGt5vVttlWS6itTQVp0lV+1FFaLokpydvsudv7RZdeU4lYhToV6qhAQUkcieVYjxdjFFaEpWnIgkhIVfO4pS1LKNdCEyRoB1r6bsHwy4cIyHCjeKDanVOLEmVJUU8JPIlPesV4u8EL363U4nBBKohKn0oVr/GAO2vKpHDipNmp485QUHsip2FilB9opyhSVBQKlBIscxkqIA0r6F4nxbCnju3EgZkqjiOmRXzQfKfur5ycE4xxK3SoNwl5tyQOUtLVFfYtrYPORqUqU2YUqwENGOIwLTasywo7EwsaUHaPnWJ2e0palb1NyT6quZmvVoMXsBWdWXcxmMfrWtJt8+vU8UTt+TPs+ZMhMAZyVSAY6ASchTIJ98TQCuHAE3MhQJ7i/vn+lb/w14FWXhmWEIyqC1cwhSTnyCZKsoOk97SKQZ8HocKloUpSMxAUYJKQSEklIANgDYV63KJ4lB0Y1a0esQTmJURcWvfzk6aVb7O2at5AUhxEqBASXBmSUquXBEp4QTBF7QbgVpEeBxzDh8gPupljwWgAjdO3M2I1tccNtBp0FYlPo1GPaMdidmFQS80rMlJS3OU3cASTlA1ie4ggzegbSwC2gCpQJOVRtosgLyWGsfEG/OtnjNlHDlpltlQS46hS1LWCUJStLR3YynKVF1MqsYQI0kUHhDaDiHHMGG/1bzoK7SoBGdISokGUkqGo1AIgwayrb12N5Y17Kdbe8JUpUKIgkJNgSAOxuQIga9qewmxEPBhTjqE51FN5GYAyRcSCcwAt3vMDX7X2UnjY3Kg2WHHCYE50lIRBF4BvEGbdCQXb2wkrQzlQ7mQsJTIbAhUBYMX9VMz0T5CmZNjI0UD+xGXGy6XjwIhKbRCcuZKVWm89AJJ4qVxDiXSEuMrcaQgpbKJtCoSZBIcOWwJ7E9++Ltiej4YJCVXcEAq4UCFlKehMam3qjWaufA7a04VI3ZPEohUIIIJmUZkk5e/WYtelpIrVuqE2i6rCnDtoXkaTnIUieFKVGc5hIJUuMsTcRoarH9hEOtLw+HdSkOesZu2MkKM3CjxyNO1bn0jEgrQhs7pbULUogFJzCMuUerGYG3zhpaVPTWQkSVlQAmALmOUjSucZSzPTQrjHLvqZrxBsRx/FLKguFLOQgAznUFHNJEBKSZ7/Hu1sI+4whhLDhU0lKMqklC0IOZxBM2ghXnI8xWh9IKiC22baEgE8jYwPtqq2Hh3VKcVi1rnhSAoQcqSqJPO32Xrd6GaFGmPRG32ChQLiG4cSlWVRbcBIVxKhRnsL3AiSTZ2HAxDLqUkhDhzEC1uUczf4itM/tnDt4drDZwFFbsJgyQUpINuGIOpgzMc6p/D+FUWisoUBvCRYXSed7nU0fZKNH+j7ZygjGrdSEpdIShRBObKHJEdOIaCSSelWzGx3CEkKa9T6K9IM86TxGOS3hW0BeVRUlKhIEhSwTwzzmqc7VWhte7ejKkBIUoRBSgmL8yT7TWWkyptGke2K7kN2vVMcK+iqxeH2WpnaKf1YhtxRtJkEHLAUZMyI86ErxZioMLmxFunO8xzqCPEjjeMZfeGcNhKikfOylRAJE3nn2FWMVwRyfJVu7NdDzw3ZzLbUlAIAlQMEQdCCUi9XuMxby8VhFpw7Tgw6kg5kxKAkDiVqqxzCAcquuhUY2iX8Qy8gLGYrdcESEJWppRGZSQFAQq/Xzqx8R7ZbS0VMPJD1ghQKJBm5NjbKDVvUJDwdZfStLyClt95DywlKgCkIbStOZN0qPFAgKhJMA6Z/wbhPR8Q8koIUtp5CBrwZkhBVA55j/ACGmWHZSXvSkFppbWXMsKhS0EXBFgpLenVJ63cR4mYOXO63w5roLfzsoNiI+aPdSnqadGKe8LYneDOzkRnhTilJCYUs8RKiAkX+Fa3bmBcxpQtK0oHo5uTKUrEuFGdJg3WUzMcCjUfExaxeHUjDr3riSlzLLaYSkwokiARCu94qr2ahQ2YpltWZ0rO8RYwnPlKQRpITztc01ZEkNbHSplCH221rbUA2E5gpQtddimxA18rXri8EtnGMbptSWgtpwEmyA4pC1yVEkAAnmo3oewXFnCNsJQolSXPmqIAUspXyInRMjpOorWqx6CRmZfmALJJgAQAJbqU1ydG4uNJU9Cm2nsleIcfW3mLhEtISArOUoiOxnNM2ggybivbYwS8ZinGyytDhDjiwSAQ2hJUEmCpKVcShMESRrEVaYQKS+p1outlQSlJUggIyzC1EwD6xmbQB0pXZDK049nMt1Lm7WVuTwwkzdrLORa4PrEXIIMVbTl9GEqjfsqdp4V/HYVeLJQ2pIKC2cwUoAOKJEpsALzedLU74jw4caShassBnNmOUJAbAVJIMQU6QbEdassBsheVolteZsCxLSk5ogmFDSRp5VZeHtkJOJc3zKFMLSFObxIWSoQhKG0pnKCpQUfKNKUntuR77aFJh8Y2W0s70JUwEJTmUMig0lDiFFYSVDMAEjhgqJEaGs7t3ZDSmmcQG1lThcC4BVlyheUtxGYAwdBe17zpXdgJcUHQlSZSRlQgJRkJzBIRMJA5AaaVYtY11llnApTwmYN5CUBWVspuNAVSQZg8wDReg/0YHD4NlPE4HFISpRUhEpU4gIBSlAIJSSqQSSbada2ze3nHm0lZQFpdCYB1S2WwDbX1SJtpNqcbwzo/uj/o/7dEOGV+4V7Aj/AI1HJsqijLO4N1ais5gVEqIhVpvGlerTbhX/AJdz3Ir1Ztike2BhQ3vHXG3FJQAMio4yuUFJGW4iZF5gWiaUWw4lxwI0zEiGwbKOZOqTlsRaqv5Qd3JaSuxUFFWZzMSAQJUVGBc2Ea0sp94f3mvR1yfaQJPtNdOKM2aJTmJ+kseSAPsoRZxB1U4fMVQB9+f2rif/AHHTz7r+ypIxeIH/AIlfxt71GplZcyLheylqIz5uhITBAzJMgzYiAQap8D4XS2sPoWRvBmuQRqlYy9U9/wCHvU/S3xriXfYQPbauJZzDieNzNwTeefDrSqGaxvGrSUgKdTIniTJVeQRYwBfkBSa8aUzD6721i3mTNGThWealT5W+EUZpbCdE+3L0PIxQfYl6IMaNw44oJMkLuoIXlISqJvrHkTRNl4Z/dNhBcSgISAM6hAjok08raQIy71YAINlEGRBHxE0NvHhKcvpCz3zaST0TFrW5VLZaVbj2zGnWkvShxZcbLcwZAIVMlRm5AFqRa2W6kyEKB6wuf91dO09Tv3B+T/D+fqGNp3//AKXPq/6aWxSGDhMR1c97n/cqQw+IAsF+5X2rpM7SQNcQ5PMyr6gPzNdZ2wg/37nQSpfIxI7fhUpltCeO8OPuvhwpOYBGRSkqgBKl50qN8oIV3M9IEv8AyYZP6v8A+pUeypnbKP3yv9V9Pz7K98ro/fK7zm/OtHfQpdnhgdBuyL2/VKAvbmNKsxsFPVPnuyL++hbK2qzJUt4mNBCiLzJ0MWH19BTv9oMOf7wgf4V21/h7HrUojYurw0kj1ke4/fSfyUoSMo6epPaQYNXCdqsmSHR55TI1m0Ty+FZPxI66X94w+4UEAqAWpKUqvNiQBME25g0oWWWB2KWkhLaMoFhwX1vJjqTPnQGfDW7JUEq4jJlJ1Pl51nlHF5p3ro5TvjaJgK4uV9e8UQrxk/tnfLfHlr8634HpWqYzI1DWylpBSG7GJ4VctJg0VGAcGiB/Ir76yqfTeTrs/wDqqn/d3+vvXkHG/vnf/mV524tKUy5kaZ3ZqihwFscQA4UlJMuI1POwNu1J7T2Vu23sgytgrgRYArPMCO8eVUo9MAMuukEc3SRyP0ormIZxbhKpWcx5uWM+Zj+tFaYbi17HfBqHzhGVokgBSRE6BagY7cPI1Y4rGOJ/aAp7ytPuOaKz2H2biUpAAKSL+uBz/wAVSLWK0zueW8//AFVM8Gga242RBfA8xI+CzNHbKFkKS6hSoiYvHSSqsywzic2pPWVgj4qg0ZtzESMyQR5pHvMwKlFzGo+Slm8T/kP33pzZCVsKKwJOUwN3aZBE9pFZVh9xJnIpF7wocu8z39tOs7RfB/aLOmqp18zJHKaUyZkWQGITZM+2w/2mu7h0qzqQnMABmgkgCdBED1iNOflCje1nLZjr3IP40wNpkmCVe+ftBipqjVxYUMumZUfYlP8AxqQwivprH+VP/GhfKiQYK1f6vLkDUfllNjvT7le28VNRp2M+j/xufypr1K/LSf3n+/7q9TUadmewzTh5RPMgC3WmE4VUglfe3xk/D+lMJ2e7zbJmYNrT9t/6UVWz3pjIfh7yJ71rOzOVA28MkXJ7XMR005xU1YZuOvXWfrvRU7Pfn1D79O3559KInAv2hBjW5Aiet7HW3bW9S2WkJ7pPJP1+0XOgrnoyPo/E9un586eGDeAkp7C6dCZ6wTURs97mg3N7iB39aenvpbLSEfREa5fbc28q6MOn6I5an4fnrTqNnOkCUxcG5FhyAE+tHb31IbPfAnJPYEXjQfeefLvLZaRXeho0y+fbmfM1E4Fv6I+OvSrBGznDJCVHpPDp0CrmdNPb0INlu2O7NgNCm553m2nsi1LYpFWrBt67u1zfoB99c9BQDdKQLT1v7datzsxy8Nqkd0gHlGug9nWvegLkgtk3AkKTdIMnQ256XNLYpFQcE2IGQfGT2+2pJ2ej6IMxrPmNORq3TgXZkItJJuCI0JMH4jSaGMI7EQYuDcDS4FjqevKpbFIrzstBvksbST7j9f514nZiCQkJEn3gdeUWE07iMK6DKkxpe2ijrY26e6mdl4NUkkXVmFgCI5z5xAP10tikMYHYmHj9nJN7zJHKQnn91eOxcP8AukzHcWPkq5v1pnMrUQQbajkLgQdPcbVMsmI0g3jQe3lyt5d6WyUhQ7Kw5JG6BOhub6j6Xc/m1dVspiDwCTYGT1m96Yb0kCDPeSL3N9POfhXnXUj1phVrDzIJI5DWliihXhEC2Ua9eneeUC/WeteU0m0pHaBHt/PQdKedZU4oFIJJmRYXGsZjrb3edDTs94/3fkZHP23/ABtUtm6QmWEg2SJ+/WplItw2o6NnvalFvNPked/smvK2a7F0R5KANuwN/bypYpAEJbsChPsF/wAak6wiPUF/t0vR/kx02yTPcXMaa0RGzHfoTyuU+U3M6iPb50sUhQMJ0yj8LTzqIw6OaR76ea2c4qxRASLXCgSNdNBepr2U8I4LazIj/dVtkpFccMgn1Z9/2HWupw6On5uKdTs9yYIj2i/LrUk4FyPU/wBSTr7TNLYpCQwaRfKR7SPtqZw6eke0016A4R6vPqB9ov2miegL0KRPmOftpbFIUThUXOX4nyNRcwaBpIN9PxkUz6Kscj7Ij3/D7OdEGCciSg+/W3nepbJSKdeylG6XDPced560q5hXwRYmNMpntoRJrQ+iLHzYjuPfHO1RewjhsEkR3q52RwRmty59Bf8AKa9Wi9EV9Bdeq530TIux5hSspvmPzoFyb9OXKeVSS5/CeWkxMaHsOprIo2m9BOe4kaJECCDcJk6aWog2u8lCTvNZjgRoDPS3xoKNSziSdAecQIkg6Ann2jUUzJkSnKI537+X3Vl2NoPqCQHYChPqpPqxdVuI8+QnpRw+6EJ4gQbGQJIVJvw9tOXLssUXxRqolVpIlVp6cIMm3LoZriVqPK06iBqJv2PLryqg+UnErLYUZJlRgaiQCLTOlz0rnyq8UFQXAEmIF1aEm3fWllymiw7arQJ5WJPYjnoJ6c7VFZm6zEG0Gx8oidPZ1qhG0nSQM5jXkPMQBH5mlkbUfJUS4SEwI6mbSe326UFGlYSpJVKiq+kAFMyQTzymNVfE0QLtpztaNRYxMgnS+vlWQTtN1RAzm9zoLlUch2N/L2FOMdCjLirAkcx0J5Xt8ago1r5Ta5HIgkEm8AAaT8B8KArEFSiE5YgXHrTzTmBi0XV3rMN4ha20la1QRmgEiUHlYiDp186M3jVhSOMjNwiABlTcR307TQtGi3yeSrGCTyAFptaBHD5g1EmALHKABAm0mEo63Ik6cp1msu5iVKC1KUTCRGgsJta9uV6kMW5wcZEiTzvfryvQUXa3CvKAs9VAcOa2VZJOnY+yj4NxKSSLaBIkC0xYpNyO/b2o7EncF1fEVE634QpSQOQ5THfW00/g0ozABCQYHK2qQOc/nnUAUuAAAHLmF4MxEfOyyLdvdXN5zBkA2CREGYjn3MmmQ0AQIAsIgcgD5fbSzDojS8gHnYgzr9QigJi5OptzzBJm0KPafhpXLplUWA+lMxrIUNOc2iTUd1lCiCMpBMQReTyCu551IslQg9/9I5ef21AAxD0G60o4pBPDJB14hca6CKcw6wtKVI0PQzcagdCDf4ik38G2U5nEJUE2jUkjhuTqLnkNBSDi93CmiUxeLf4ba8otpr1pZasvSM3FIBFyQdJ5wDofLrXQZAkiLReBJ5TzE6E/hWW+UHDmOdUAkakTeeWlo52NEViHLnersmdeUEx26Willo0qsObfmbTrFvL21xM5ZkAd+ffofr7Gs6rHuTJdXIvrpa0CY94rxxC4JC1DredBFh/T4UsUX5kyRbykG3eba9PdR94Yyq0mRHO5N5t+edUKi4ElW9X/ADHTLNuQ52v586gxiHCOFagkGBJPIxEdLcyfKrZMpo3W8wzGCDy0+B59+o1FLlQCoJExbnryJnWJ66a1QKxK5JzqtFpIFjlGnlyy60Jt4LJEqnmSZnpAnh8zmpYympKSQQkg+0k9/IdqGQrnIItF79gT9VUXpTiYhaoBygZjrMXPS/4UYOLJMrUVWkyecmw5XHeljKXJyA8VjHsPlJj66i4RzEedv61UqdctxGIBFzJM2zGujOk5c5lQk9BpIHvqZiUyxcHf8+VjUXDf7ZnTt9lU7LqjCkqIBJSB1IUUyojuDby8qKpaxIznhEnvqqBMxp+daWMpZwvor8+2vVQKdcN8x/mP3V6ljKf/2Q==",
                IsActive = true
            };

            CentralPark = new Landmark()
            {
                Id = 5,
                Name = "Central Park",
                Address = "59th to 110th Street Manhattan Borough, NY 10022",
                Details = "For more than 150 years, visitors have flocked to Central Park's 843 green acres in the heart of Manhattan. Since 1980, the Park has been managed by the Central Park Conservancy, in partnership with the public. Central Park is open 6 am to 1 am daily. Visit the official website of Central Park to learn more about Park happenings and activities and to learn how you to help Central Park!",
                City_Id = 3,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/New_York_City-Manhattan-Central_Park_%28Gentry%29.jpg/1200px-New_York_City-Manhattan-Central_Park_%28Gentry%29.jpg",
                IsActive = true
            };

            EmpireStateBuilding = new Landmark()
            {
                Id = 6,
                Name = "Empire State Building",
                Address = "20 W 34th St., New York, NY 10001",
                Details = "The Empire State Building is the World's Most Famous Building. It rises 1,454 ft from ground to antenna & features the only 360 degree open-air vantage point of Midtown. The 86th & 102nd Fl Observatories are open daily, see esbnyc.com for hours.",
                City_Id = 3,
                TicketPrice = 47.91m,
                ImageUrl = "https://www.esbnyc.com/sites/default/files/2020-01/ESB%20Day.jpg",
                IsActive = true
            };

            HagiaSophia = new Landmark()
            {
                Id = 7,
                Name = "Hagia Sophia Mosque",
                Address = "Sultan Ahmet, Ayasofya Meydanı No:1, Istanbul 34122 Türkiye",
                Details = "This architectural marvel displays 30 million gold tiles throughout its interior, and a wide, flat dome which was a bold engineering feat at the time it was constructed in the 6th century.",
                City_Id = 4,
                ImageUrl = "https://cdn.britannica.com/03/189803-050-871B95C4/Hagia-Sophia-Istanbul.jpg",
                IsActive = true
            };
           
            BasilicaCistern = new Landmark()
            {
                Id = 8,
                Name = "Basilica Cistern",
                Address = "Alemdar Mahallesi, Yerebatan Caddesi, No:1/3, Istanbul 34410 TÃ¼rkiye",
                Details = "The Basilica Cistern, or Sunken Palace, in Istanbul's Sultanahmet district dates back to the 6th century. It's the largest surviving cistern from the Byzantine era, featuring over 330 marble and granite columns, including two famous Medusa heads. Recognizable from \"From Russia with Love,\" it's a must-visit spot along with Hagia Sophia and Topkapi Palace. Joining a tour can streamline your visit to these iconic Istanbul landmarks.",
                City_Id = 4,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cc/Basilica_Cistern_after_restoration_2022_%2811%29.jpg",
                IsActive = true
            };
           
            Colosseum = new Landmark()
            {
                Id = 9,
                Name = "Colosseum",
                Address = "Piazza del Colosseo, 00184 Rome Italy",
                Details = "The ancient Flavian Amphitheater was built by the Flavian emperors in 70 C.E. as a gift to the Roman people. As the largest Roman theater ever built, it was designed to house over 50,000 people, and had played host to gladiator games, plays and even public executions.",
                City_Id = 5,
                IsActive = true,
                ImageUrl = "https://cdn.mos.cms.futurecdn.net/BiNbcY5fXy9Lra47jqHKGK.jpg",
                TicketPrice = 38.86m
            };
           
            Pantheon = new Landmark()
            {
                Id = 10,
                Name = "Pantheon",
                Address = "Piazza della Rotonda, 00186 Rome Italy",
                Details = "Dedicated to the seven planetary divinities and featuring an interior of gorgeous marble, the Pantheon is one of the most impressive monuments of Augustan Rome.",
                City_Id = 5,
                ImageUrl = "data:image/jpeg;base64,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",
                IsActive = true
            };
            
            StAlexanderNevskiCathedral = new Landmark()
            {
                Id = 11,
                Name = "St. Alexander Nevski Cathedral",
                Address = "Sofia Center, pl.Sveti Aleksandar Nevski, 1000 Sofia",
                Details = "Completed in 1912, St. Alexander Nevsky Patriarchal Cathedral Stauropigial Memorial-Church is an impressive landmark in Sofia. The church was built as a memorial to the 200,000 Russian soldiers who died in the Russo-Turkish Liberation War (1877-1878).",
                City_Id = 6,
                ImageUrl = "https://central-hotel.com/wp-content/uploads/2016/08/St.-Alexander-Nevsky-1.jpg",
                IsActive = true
            };
           
            CatedralDeSvetaNedelya = new Landmark()
            {
                Id = 12,
                Name = "Catedral de Sveta-Nedelya",
                Address = "pl.Sveta Nedelya, Sofia 1000 Bulgaria",
                Details = "The Cathedral of Sveta-Nedelya, also known as the Cathedral of the Holy Virgin, is an Orthodox church located in the center of Sofia, the capital of Bulgaria. It was completed in 1867 in a neo-Byzantine style. The cathedral has witnessed significant historical events, including a bomb attack in 1925 by a communist group that resulted in numerous casualties. Today, it remains an important religious and tourist destination, showcasing impressive architecture and a rich cultural heritage.",
                City_Id = 6,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/91/StNedelyaChurch_Sofia_%28cropped%29.jpg",
                IsActive = true
            };
           
            TokyoTower = new Landmark()
            {
                Id = 13,
                Name = "Tokyo Tower",
                Address = "4-chome 2-8, Shibakoen, Minato 105-0011 Tokyo Prefecture",
                Details = "Tokyo Tower, built in 1958, is a communications and observation tower located in the Shiba-koen district of Minato, Tokyo, Japan. Standing at a height of 332.9 meters, it held the title of Japan's tallest tower until the construction of the Tokyo Sky Tree, which now surpasses it in height.",
                City_Id = 7,
                IsActive = true,
                ImageUrl = "https://media.tacdn.com/media/attractions-splice-spp-674x446/0b/27/61/f1.jpg",
                TicketPrice = 15.00m
            };
           
            SensoJiTemple = new Landmark()
            {
                Id = 14,
                Name = "Senso-ji Temple",
                Address = "2-3-1, Asakusa, Taito 111-0032 Tokyo Prefecture",
                Details = "According to legend, two brothers kept trying to return a statue of Kannon, the goddess of mercy, to the Sumida River only to have it returned to them the next day. This temple located in Tokyo's Asakusa district was built to honor her.",
                City_Id = 7,
                ImageUrl = "data:image/jpeg;base64,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",
                IsActive = true
            };
        } 
        private void SeedHotels()
        {
            //Paris
            
            IbisParis = new Hotel()
            {
                Id = 1,
                Name = "Ibis Paris Gare Montparnasse Catalogne",
                Address = "11 Rue Du Texel, 14th arr., 75014",
                City_Id = 1,
                StarRate = 3,
                Details = "Ideally set in the 14th arr. District of Paris, Ibis Paris Gare Montparnasse Catalogne is located 1.6 miles from Rodin Museum, 1.6 miles from Luxembourg Gardens and 2 miles from Orsay Museum. With a bar, the 3-star hotel has air-conditioned rooms with free WiFi, each with a private bathroom. Private parking is available on site.\r\n\r\nAt the hotel, rooms have a closet. The rooms include a desk and a flat-screen TV, and some accommodations at Ibis Paris Gare Montparnasse Catalogne have a balcony.\r\n\r\nA buffet, continental or American breakfast is available each morning at the property.\r\n\r\nSpeaking English, Spanish, French and Ukrainian at the 24-hour front desk, staff are ready to help around the clock.\r\n\r\nSainte Chapelle is 2 miles from the accommodation, while Paris Expo – Porte de Versailles is 2.1 miles from the property. The nearest airport is Paris - Orly Airport, 8.1 miles from Ibis Paris Gare Montparnasse Catalogne.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1",
                CheckIn = DateTime.ParseExact("16:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = true,
                IsActive = true
            };

            SaintMarcel = new Hotel()
            {
                Id = 2,
                Name = "Hôtel Saint Marcel",
                Address = "43 Boulevard Saint-Marcel, 13th arr., 75013",
                City_Id = 1,
                StarRate = 3,
                Details = "You're eligible for a Genius discount at Hôtel Saint Marcel! To save at this property, all you have to do is sign in.\r\n\r\nFeaturing free Wi-Fi, Hôtel Saint Marcel offers accommodations in Paris, 1.2 mi from AccorHotels Arena. Guests can make use of the fitness area in the gym\r\n\r\nRooms feature a flat-screen TV with satellite channels. Certain rooms have a seating area where you can relax. For your comfort, you will find free toiletries and a hairdryer in the bathroom.\r\n\r\nYou will find a 24-hour front desk at the property.\r\n\r\nNoter Dame Cathedral is 1.2 mi from Hôtel Saint Marcel, while Opéra Bastille is 1.2 mi away. The nearest airport is Orly Airport, 7.5 mi from the property.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/50496815.jpg?k=8e4c7075f4c48de078c1d584716f38ccfcf56f51ee455b01fb0abcefddc2c9bd&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true
            };

            KraftHotel = new Hotel()
            {
                Id = 3,
                Name = "Kraft Hotel",
                Address = "37, rue du Hameau, 15th arr., 75015",
                City_Id = 1,
                StarRate = 4,
                Details = "You're eligible for a Genius discount at Kraft Hotel! To save at this property, all you have to do is sign in.\r\n\r\nThis hotel is located opposite the main entrance of Dôme de Paris - Palais des Sports, near the lively Vaugirard area with its boutiques, cafés and lovely restaurants.\r\n\r\nThe ambiance of the Kraft Hotel suits perfectly the diversity of guests who come to stay: those who come to discover the treasures of Paris and those who come to attend a show, symposium, fair or exposition.\r\n\r\nGuestrooms are stylishly decorated and furnished to offer you high-quality comfort. They offer a private bathroom and a TV.\r\n\r\nThe Kraft Hotel is an ideal location for business or leisure. It is located near the local metro station which offers direct access into the heart of the capital.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/501485308.jpg?k=4db18f42e477c422e0c412d87df0aed2bf16a463342daad5d672731287488c54&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("11:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true
            };

            //Madrid

            PestanaPlaza = new Hotel()
            {
                Id = 4,
                Name = "Pestana Plaza Mayor Madrid",
                Address = "Calle Imperial 8, Centro, 28012",
                City_Id = 2,
                StarRate = 4,
                Details = "Less than 1 km from Mercado San Miguel and a 13-minute walk from Puerta de Toledo, the property offers a terrace and a bar. The accommodation provides a 24-hour front desk, spa and free WiFi is available.\r\n\r\nAt the hotel, every room comes with a desk and a flat-screen TV. The private bathroom is equipped with a shower, free toiletries and a hair dryer. The units at Pestana Plaza Mayor Madrid have air conditioning and a wardrobe.\r\n\r\nA buffet breakfast is available daily at the property.\r\n\r\nPestana Plaza Mayor Madrid is located in Plaza Mayor, while Thyssen-Bornemisza Museum is 1.1 km from the property. Adolfo Suarez Madrid-Barajas Airport is 13.8 km away.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/255649687.jpg?k=84b89c322748a0e6479cd2d71263e56f2eb9771d4010cc30d3018488d7ccc671&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = false,
                IsActive = true
            };

            CataloniaPuerta = new Hotel()
            {
                Id = 5,
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

            HostalCentralPalace = new Hotel()
            {
                Id = 6,
                Name = "Hostal Central Palace Madrid",
                Address = "Plaza de Oriente 2, 3º izquierda, Centro, 28013",
                City_Id = 2,
                StarRate = 1,
                Details = "Centrally located overlooking the Royal Palace and Sabatini Gardens in Madrid’s Plaza de Oriente, this elegant guest house offers 24-hour reception and free WiFi.\r\n\r\nThe spacious rooms at Hostal Central Palace Madrid feature wooden floors and classic décor. They all feature a private bathroom with shower and a hairdryer and toiletries. Some rooms offer views of the Royal Palace, Almudena Cathedral and the Sabatini Gardens.\r\n\r\nThere are many shops, bars and restaurants are within a short walk.\r\n\r\nLuggage storage is offered. Staff at reception can provide information about what to see and do in Madrid. There are also various car parks within a short walk.\r\n\r\nHostal Central Palace Madrid is the only guest house located in the Plaza de Oriente square, opposite the Royal Palace. It is 200 metres from Opera Metro Station and 10 minutes’ walk from Puerta del Sol.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/33799890.jpg?k=1d94fedc1ccb9dd41e53fcefc908ecc8f09cba9919315b4d9a7bf6d3afa951be&o=&hp=1",
                CheckIn = DateTime.ParseExact("14:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true
            };

            //New York

            PrinceKitano = new Hotel()
            {
                Id = 7,
                Name = "The Prince Kitano New York",
                Address = "66 Park Avenue, Murray Hill, New York, NY 10016",
                City_Id = 3,
                StarRate = 4,
                Details = "This Japanese-style hotel is located 500 metres from Grand Central Station and features a rotating repertoire of gallery pieces in the lobby. There are 2 on-site restaurants.\r\n\r\nKitano New York features rooms with flat-screen TVs, iPod docking stations and a work desk. Free Japanese green tea and dressing gowns and slippers are provided.\r\n\r\nHakubai Restaurant at the New York Kitano serves gourmet Japanese cuisine for lunch and dinner. Guests can also have American and European dishes at Jazz at The Kitano Restaurant. In the evening, the Bar Lounge serves a full selection of cocktails.\r\n\r\nAvailable services at the Kitano include car rental, a tour desk, foreign currency exchange and a gift shop. The hotel also features a fitness centre, laundry facilities and dry cleaning.\r\n\r\nThe Empire State Building is 645 metres from the Kitano Manhattan.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/505296139.jpg?k=7e84172ea344cde933840092c3a9f3c4099e70903084b0d91ce3db747901c49d&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("11:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = false,
                IsActive = true
            };

            HiltonGarden = new Hotel()
            {
                Id = 8,
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

            TimesSquareHotel = new Hotel()
            {
                Id = 9,
                Name = "45 Times Square Hotel",
                Address = "125 West 45th Street, New York, NY 10036",
                City_Id = 3,
                StarRate = 3,
                Details = "Featuring 3-star accommodation, 45 Times Square Hotel is located in New York, 200 metres from Times Square and 500 metres from Radio City Music Hall. With free WiFi, this 3-star hotel offers a 24-hour front desk and a tour desk. The property is 600 metres from Bryant Park, and within 300 metres of the city centre.\r\n\r\nPopular points of interest near the hotel include Broadway Theatre, Rockefeller Center and New York Public Library. The nearest airport is LaGuardia Airport, 12 km from 45 Times Square Hotel.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/442811339.jpg?k=e89ae66126c9c1239ea05e7a9b5f0423ed15739432d7649eb6e6b06109aba180&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true
            };

            //Sofia

            HotelZOO = new Hotel()
            {
                Id = 10,
                Name = "Hotel ZOO Sofia - Secured Paid Parking",
                Address = "6 Simeonovsko Shausse Blvd., Lozenets, 1700",
                City_Id = 6,
                StarRate = 4,
                Details = "Hotel ZOO Sofia is located In Sofia and next to a large green park, perfect for relaxation. Sopharma Business Towers are a 7-minute drive away, Inter Expo Center is a 10-minute drive away and the Grand Sports Hall Arena Armeec is 0.9 mi away.\r\n\r\nEnjoy a drink in the stylish bar and sample an assortment of cuisine in the elegant Bijou restaurant. The tastefully decorated, fully-equipped accommodations provide you with the air of tranquility.\r\n\r\nMake use of the free gym and free WiFi throughout the hotel. A secure parking is available against a surcharge.\r\n\r\nSofia City Zoo is only 656 feet from Hotel ZOO Sofia. Paradise Center, a vast shopping and entertainment center, is 1.6 mi away. Interpred business area is a 12-minute drive away.\r\n\r\nSofia Airport is a 15 minute drive away. Pickup from the Airport or Central Train Station pickup can be organized against a surcharge.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/294238843.jpg?k=11770c2bb4bcf168f0b6d6bc6435bcd507a1447750d6418205993540c608e268&o=&hp=1",
                CheckIn = DateTime.ParseExact("14:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = false,
                IsActive = true,
            };

            EurostarsSofia = new Hotel()
            {
                Id = 11,
                Name = "Eurostars Sofia City",
                Address = "6 Stara Planina Str., 1000",
                City_Id = 6,
                StarRate = 4,
                Details = "Conveniently located in the center of Sofia, Eurostars Sofia City provides air-conditioned rooms with free WiFi and private parking. This 4-star hotel offers a 24-hour front desk and a business center. The property is non-smoking throughout and is located a 4-minute walk from Cathedral Saint Alexandar Nevski.\r\n\r\nRooms are complete with a private bathroom equipped with free toiletries, while certain rooms at the hotel also offer a balcony.\r\n\r\nEurostars Sofia City offers a buffet or continental breakfast.\r\n\r\nPopular points of interest near the accommodation include Banya Bashi Mosque, Sofia University St. Kliment Ohridski and Council of Ministers Building. The nearest airport is Sofia, 3.1 miles from Eurostars Sofia City, and the property offers a paid airport shuttle service.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/281027010.jpg?k=ada420d7944091b2d98b431b4239a0ca5f07da5239023b81ad27f17d5ca52a35&o=&hp=1",
                CheckIn = DateTime.ParseExact("14:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = false,
                IsActive = true
            };

            PremierSofia = new Hotel()
            {
                Id = 12,
                Name = "Best Western Premier Sofia Airport Hotel",
                Address = "11 Briuksel Blvd., 1592",
                City_Id = 6,
                StarRate = 4,
                Details = "The modern 4-star Best Western Premier Sofia Airport Hotel is located in a new business district, only 2461 feet away by car from Sofia International Airport Terminal 1 and 0.6 mi from Sofia International Airport Terminal 2. It is 2953 feet away from Sofia Airport Center and 1.4 mi away from Trade Center Europe.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/77419722.jpg?k=c00e5324b8b60246cc03dc25568672a7f3a4729c3b10598f5170bc09965838d3&o=&hp=1",
                CheckIn = DateTime.ParseExact("14:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = true,
                IsActive = true
            };

            //Istanbul

            EminPalace = new Hotel()
            {
                Id = 13,
                Name = "Emin Palace",
                Address = "Güvenlik Caddesi, Fatih, 34130",
                City_Id = 4,
                StarRate = 3,
                Details = "Located in Istanbul, Emin Palace offers 3-star accommodations with a terrace and a restaurant. The property is around 1.1 miles from Suleymaniye Mosque, 1.5 miles from Blue Mosque and 1.7 miles from Basilica Cistern. The property has a 24-hour front desk, airport transportation, room service and free WiFi throughout the property.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/306033163.jpg?k=b0e00a1da26349cd39fa387e6b76a82b94bef8b51630828e2afb6a98ec46164c&o=&hp=1",
                CheckIn = DateTime.ParseExact("14:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true,
            };
           
            HotelZurich = new Hotel()
            {
                Id = 14,
                Name = "Hotel Zurich Istanbul Old Citye",
                Address = "Güvenlik Caddesi, Fatih, 34130",
                City_Id = 4,
                StarRate = 4,
                Details = "Featuring a welcoming terrace, Hotel Zurich Istanbul Old City is close to Istanbul’s vibrant shopping district and 15 minutes’ walk from Grand Bazaar. It also offers a health center. Hagia Sophia, Blue Mosque and other major attractions are in 30 minutes' walk distance.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/501751933.jpg?k=99a158e38f1640dcaa9a56b0906ecafa05e8fe6c524667bbe1600a7200afa521&o=&hp=1",
                CheckIn = DateTime.ParseExact("14:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true,
            };
            
            FlorinaHotel = new Hotel()
            {
                Id = 15,
                Name = "Florina Hotel",
                Address = "Alemdar, Marmara Region, Prof. Kazım İsmail Gürkan Cd. NO: 3, 34110",
                City_Id = 4,
                StarRate = 4,
                Details = "Popular points of interest near Florina Hotel include Basilica Cistern, Column of Constantine and Blue Mosque. The nearest airport is Istanbul, 28 miles from the hotel, and the property offers a paid airport shuttle service.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309103534.jpg?k=d788f9ac2c270a0f155a7214d9e94089d86288f6acb8aefd8e95010903e5b580&o=&hp=1",
                CheckIn = DateTime.ParseExact("14:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true,
            };
            
            //Tokyo
           
            LoisirHotel = new Hotel()
            {
                Id = 16,
                Name = "Loisir Hotel Shinagawa Seaside",
                Address = "140-0002 Tokyo-to, 4-12-8, higashishinagawa",
                City_Id = 7,
                StarRate = 4,
                Details = "In a prime location in the Shinagawa Ward district of Tokyo, Loisir Hotel Shinagawa Seaside is located a few steps from Shinagawa Seaside Forest Oval Garden, a 9-minute walk from Sinagawa Sentaikoujin Temple and half a mile from Seiun Inari Shrine. This 4-star hotel offers a 24-hour front desk. Free WiFi is available and private parking can be arranged at an extra charge.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/326305836.jpg?k=a4fddd97529943d3c8342a0cfe1110d14aeb57033494152dd86ce113f80afee9&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("11:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = false,
                IsActive = true,
            };
           
            SotetsuFresa = new Hotel()
            {
                Id = 17,
                Name = "Sotetsu Fresa Inn Tokyo Tamachi",
                Address = "108-0023 Tokyo-to, Minato-ku Shibaura 3-14-21",
                City_Id = 7,
                StarRate = 3,
                Details = "A 5-minute walk from JR Tamachi Train Station and Mita Subway Station, Sotetsu Fresa Inn Tokyo Tamachi offers simple modern accommodations with free wired internet access. Guests can request relaxing massages for an extra cost and store luggage for free at the 24-hour front desk. Tokyo Tamachi Sotetsu Fresa Inn is a 20-minute walk from Shiba Park and a 10-minute train ride from JR Shinagawa Train Station. The Imperial Palace is a 15-minute drive away.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/124760078.jpg?k=5b64947a1714bd3adbdebd6bff329c9a7debd693c4f02bb201390dc3988d4b63&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("11:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true,
            };
            
            OakwoodPremier = new Hotel()
            {
                Id = 18,
                Name = "Oakwood Premier Tokyo",
                Address = "100-0005 Tokyo-to, Chiyoda-ku, Marunouchi 1-8-2",
                City_Id = 7,
                StarRate = 5,
                Details = "Oakwood Premier Tokyo is a luxury serviced apartment with hotel-like services, located at just a 2-minute walk from JR Tokyo Station’s Yaesu North Exit. Located on the 6-19th floors of a 19-story building, this property is designed to offer a getaway in the center of Tokyo. There is a 24-hour front desk on site.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/253998054.jpg?k=3b996abd68f812376d2bea8e57bb8f5918e25228677a88d17db49e444c521d91&o=&hp=1",
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("11:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = false,
                IsActive = true,
            };

            //Rome
          
            FlaminioHolidays = new Hotel()
            {
                Id = 19,
                Name = "Flaminio Holidays",
                Address = "Viale Pinturicchio 19, Villa Borghese Parioli, 00196",
                City_Id = 5,
                StarRate = 3,
                Details = "Featuring air conditioning, Flaminio Holidays offers en suite rooms and an apartment in Rome. Ponte Milvio is 300 metres from the property. Free WiFi is provided throughout the property.There is a tram stop linking to Piazza del Popolo right in front of the property. Foro Italico - Rome is 700 metres from Flaminio Holidays.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/466841541.jpg?k=cb07cb3e10ddcbc2b29fdf20f30cb7f3e756e9cffa6bd9e5c8854a57e6c8984d&o=&hp=1",
                CheckIn = DateTime.ParseExact("13:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("10:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = false,
                IsActive = true,
            };
            
            AliusAndFreerome = new Hotel()
            {
                Id = 20,
                Name = "Alius and Freerome Hotel",
                Address = "243 Via Nazionale, Central Station, 00184",
                City_Id = 5,
                StarRate = 2,
                Details = "Ideally situated in the Central Station district of Rome, Alius and Freerome Hotel is situated 800 metres from Santa Maria Maggiore, 1 km from Cavour Metro Station and 700 metres from Quirinal Hill. With free WiFi, this 2-star hotel offers a tour desk. The property is 1.1 km from the city centre and 200 metres from Repubblica - Teatro dell'Opera Metro Station.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/355779789.jpg?k=e854ebae86fae75b72fff8469f9783cac0428f94ff76313dffe0dc6018cc64b1&o=&hp=1",
                CheckIn = DateTime.ParseExact("14:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("06:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = false,
                IsActive = true,
            };
           
            AdMaioraSuite = new Hotel()
            {
                Id = 21,
                Name = "Ad maiora suite",
                Address = "102 Via Principe Amedeo, Central Station, 00185",
                City_Id = 5,
                StarRate = 4,
                Details = "Right in the heart of Rome, situated within a short distance of Vittorio Emanuele Metro Station and Santa Maria Maggiore, AD MAIORA SUITE offers free WiFi, air conditioning and household amenities such as a fridge and coffee machine. This recently renovated apartment is located 1.1 km from Cavour Metro Station and 500 metres from Rome Termini Metro Station. The property is non-smoking and is located 400 metres from Rome Termini Train Station.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/472491611.jpg?k=d6136cf78533b12276bd7ff21f0a59f5a0d83dcda6b0d2e6d163986f39104f19&o=&hp=1",
                CheckIn = DateTime.ParseExact("12:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("09:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = false,
                Pets = true,
                IsActive = true,
            };
        }
        private void SeedRooms()
        {
            //Paris

            IbisParisRoomSingle = new Room()
            {
                Id = 1,
                Type = Enums.RoomType.Single,
                Hotel_Id = 1,
                PricePerNight = 165m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            IbisParisRoomDouble = new Room()
            {
                Id = 2,
                Type = Enums.RoomType.Double,
                Hotel_Id = 1,
                PricePerNight = 302m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            IbisParisRoomTriple = new Room()
            {
                Id = 3,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 1,
                PricePerNight = 578m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            IbisParisRoomApartment = new Room()
            {
                Id = 4,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 1,
                PricePerNight = 630m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

           
            KraftHotelRoomSingle = new Room()
            {
                Id = 5,
                Type = Enums.RoomType.Single,
                Hotel_Id = 3,
                PricePerNight = 630m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            KraftHotelRoomDouble = new Room()
            {
                Id = 6,
                Type = Enums.RoomType.Double,
                Hotel_Id = 3,
                PricePerNight = 470m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

           
            SaintMarcelRoomSingle = new Room()
            {
                Id = 7,
                Type = Enums.RoomType.Single,
                Hotel_Id = 2,
                PricePerNight = 216m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            SaintMarcelRoomDouble = new Room()
            {
                Id = 8,
                Type = Enums.RoomType.Double,
                Hotel_Id = 2,
                PricePerNight = 157m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            //Madrid

            PestanaPlazaRoomSingle = new Room()
            {
                Id = 9,
                Type = Enums.RoomType.Single,
                Hotel_Id = 4,
                PricePerNight = 433m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            PestanaPlazaRoomDouble = new Room()
            {
                Id = 10,
                Type = Enums.RoomType.Double,
                Hotel_Id = 4,
                PricePerNight = 488m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            PestanaPlazaRoomTriple = new Room()
            {
                Id = 11,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 4,
                PricePerNight = 644m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            
            CataloniaPuertaRoomSingle = new Room()
            {
                Id = 12,
                Type = Enums.RoomType.Single,
                Hotel_Id = 5,
                PricePerNight = 201m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            CataloniaPuertaRoomDouble = new Room()
            {
                Id = 13,
                Type = Enums.RoomType.Double,
                Hotel_Id = 5,
                PricePerNight = 201m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

           
            HostalCentralPalaceRoomDouble = new Room()
            {
                Id = 14,
                Type = Enums.RoomType.Double,
                Hotel_Id = 6,
                PricePerNight = 197m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            //New York

            TimesSquareHotelRoomDouble = new Room()
            {
                Id = 15,
                Type = Enums.RoomType.Double,
                Hotel_Id = 9,
                PricePerNight = 193m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            TimesSquareHotelRoomTriple = new Room()
            {
                Id = 16,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 9,
                PricePerNight = 244m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

           
            HiltonGardenRoomDouble = new Room()
            {
                Id = 17,
                Type = Enums.RoomType.Double,
                Hotel_Id = 8,
                PricePerNight = 195m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            HiltonGardenRoomTriple = new Room()
            {
                Id = 18,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 8,
                PricePerNight = 238m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            HiltonGardenRoomApartment = new Room()
            {
                Id = 19,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 8,
                PricePerNight = 248m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

           
            PrinceKitanoRoomDouble = new Room()
            {
                Id = 20,
                Type = Enums.RoomType.Double,
                Hotel_Id = 7,
                PricePerNight = 314m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            PrinceKitanoRoomApartment = new Room()
            {
                Id = 21,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 7,
                PricePerNight = 351m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            //Sofia

            HotelZOORoomSingle = new Room()
            {
                Id = 22,
                Type = Enums.RoomType.Single,
                Hotel_Id = 10,
                PricePerNight = 70m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            HotelZOORoomDouble = new Room()
            {
                Id = 23,
                Type = Enums.RoomType.Double,
                Hotel_Id = 10,
                PricePerNight = 78m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            HotelZOORoomTriple = new Room()
            {
                Id = 24,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 10,
                PricePerNight = 104m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            
            EurostarsSofiaRoomSingle = new Room()
            {
                Id = 25,
                Type = Enums.RoomType.Single,
                Hotel_Id = 11,
                PricePerNight = 71m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            EurostarsSofiaRoomDouble = new Room()
            {
                Id = 26,
                Type = Enums.RoomType.Double,
                Hotel_Id = 11,
                PricePerNight = 80m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            EurostarsSofiaRoomTriple = new Room()
            {
                Id = 27,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 11,
                PricePerNight = 161m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            EurostarsSofiaRoomApartment = new Room()
            {
                Id = 28,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 11,
                PricePerNight = 173m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            
            PremierSofiaRoomSingle = new Room()
            {
                Id = 29,
                Type = Enums.RoomType.Single,
                Hotel_Id = 12,
                PricePerNight = 112m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            PremierSofiaRoomDouble = new Room()
            {
                Id = 30,
                Type = Enums.RoomType.Double,
                Hotel_Id = 12,
                PricePerNight = 125m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            PremierSofiaRoomTriple = new Room()
            {
                Id = 31,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 12,
                PricePerNight = 190m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            //Istanbul
           
            EminPalaceRoomSingle = new Room()
            {
                Id = 32,
                Type = Enums.RoomType.Single,
                Hotel_Id = 13,
                PricePerNight = 95m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            EminPalaceRoomDouble = new Room()
            {
                Id = 33,
                Type = Enums.RoomType.Double,
                Hotel_Id = 13,
                PricePerNight = 108m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
          
            EminPalaceRoomTriple = new Room()
            {
                Id = 34,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 13,
                PricePerNight = 209m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            
            HotelZurichRoomSingle = new Room()
            {
                Id = 35,
                Type = Enums.RoomType.Single,
                Hotel_Id = 14,
                PricePerNight = 260m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            HotelZurichRoomDouble = new Room()
            {
                Id = 36,
                Type = Enums.RoomType.Double,
                Hotel_Id = 14,
                PricePerNight = 207m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            HotelZurichRoomTriple = new Room()
            {
                Id = 37,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 14,
                PricePerNight = 327m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            HotelZurichRoomApartment = new Room()
            {
                Id = 38,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 14,
                PricePerNight = 350m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            
            FlorinaHotelRoomSingle = new Room()
            {
                Id = 39,
                Type = Enums.RoomType.Single,
                Hotel_Id = 15,
                PricePerNight = 133m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            FlorinaHotelRoomDouble = new Room()
            {
                Id = 40,
                Type = Enums.RoomType.Double,
                Hotel_Id = 15,
                PricePerNight = 155m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            FlorinaHotelRoomTriple = new Room()
            {
                Id = 41,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 15,
                PricePerNight = 200m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
         
            FlorinaHotelRoomApartment = new Room()
            {
                Id = 42,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 15,
                PricePerNight = 329m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            //Tokyo
          
            LoisirHotelRoomSingle = new Room()
            {
                Id = 43,
                Type = Enums.RoomType.Single,
                Hotel_Id = 16,
                PricePerNight = 135m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
          
            LoisirHotelRoomDouble = new Room()
            {
                Id = 44,
                Type = Enums.RoomType.Double,
                Hotel_Id = 16,
                PricePerNight = 198m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            
            SotetsuFresaRoomSingle = new Room()
            {
                Id = 45,
                Type = Enums.RoomType.Single,
                Hotel_Id = 17,
                PricePerNight = 223m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
            
            SotetsuFresaRoomDouble = new Room()
            {
                Id = 46,
                Type = Enums.RoomType.Double,
                Hotel_Id = 17,
                PricePerNight = 289m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            
            OakwoodPremierRoomSingle = new Room()
            {
                Id = 47,
                Type = Enums.RoomType.Single,
                Hotel_Id = 18,
                PricePerNight = 378m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
            
            OakwoodPremierRoomDouble = new Room()
            {
                Id = 48,
                Type = Enums.RoomType.Double,
                Hotel_Id = 18,
                PricePerNight = 460m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            OakwoodPremierRoomApartment = new Room()
            {
                Id = 49,
                Type = Enums.RoomType.Double,
                Hotel_Id = 18,
                PricePerNight = 853m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            //Rome
            
            FlaminioHolidaysRoomSingle = new Room()
            {
                Id = 50,
                Type = Enums.RoomType.Single,
                Hotel_Id = 19,
                PricePerNight = 123m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
            
            FlaminioHolidaysRoomDouble = new Room()
            {
                Id = 51,
                Type = Enums.RoomType.Double,
                Hotel_Id = 19,
                PricePerNight = 163m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            FlaminioHolidaysRoomTriple = new Room()
            {
                Id = 52,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 19,
                PricePerNight = 182m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            FlaminioHolidaysRoomApartment = new Room()
            {
                Id = 53,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 19,
                PricePerNight = 198m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

           
            AliusAndFreeromeDouble = new Room()
            {
                Id = 54,
                Type = Enums.RoomType.Double,
                Hotel_Id = 20,
                PricePerNight = 178m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            AliusAndFreeromeTriple = new Room()
            {
                Id = 55,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 20,
                PricePerNight = 217m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            AliusAndFreeromeApartment = new Room()
            {
                Id = 56,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 20,
                PricePerNight = 218m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };

            
            AdMaioraSuiteDouble = new Room()
            {
                Id = 57,
                Type = Enums.RoomType.Double,
                Hotel_Id = 21,
                PricePerNight = 128m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
            
            AdMaioraSuiteTriple = new Room()
            {
                Id = 58,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 21,
                PricePerNight = 140m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
           
            AdMaioraSuiteApartment = new Room()
            {
                Id = 59,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 21,
                PricePerNight = 153m,
                WiFi = true,
                IsActive = true,
                Count = 5
            };
        }      
        private void SeedAirlines()
        {
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

            TurkishAirlines = new Airline()
            {
                Id = 3,
                Name = "Turkish Airlines",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Turkish_Airlines_logo_2019_compact.svg/2560px-Turkish_Airlines_logo_2019_compact.svg.png",
                WebSiteUrl = "https://www.turkishairlines.com/"
            };

            WizzAir = new Airline()
            {
                Id = 4,
                Name = "Wizz Air",
                ImageUrl = "https://1000logos.net/wp-content/uploads/2020/04/Wizz-Air-logo.jpg",
                WebSiteUrl = "https://wizzair.com/"
            };

            Ryanair = new Airline()
            {
                Id = 5,
                Name = "Ryanair",
                ImageUrl = "https://logos-world.net/wp-content/uploads/2020/03/Ryanair-Logo-2013-present.jpg",
                WebSiteUrl = "https://www.ryanair.com/"
            };
        }
        private void SeedAirports()
        {
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

            NewYorkAirport = new Airport()
            {
                Id = 3,
                Name = "John F. Kennedy International Airport",
                ShorterName = "JFK",
                City_Id = 3
            };

            IstanbulAirport = new Airport()
            {
                Id = 4,
                Name = "Istanbul International Airport",
                ShorterName = "SAW",
                City_Id = 4
            };

            RomeAirport = new Airport()
            {
                Id = 5,
                Name = "Leonardo da Vinci–Fiumicino Airport",
                ShorterName = "FCO",
                City_Id = 5
            };

            SofiaAirport = new Airport()
            {
                Id = 6,
                Name = "Sofia International Airport",
                ShorterName = "SOF",
                City_Id = 6
            };

            TokyoAirport = new Airport()
            {
                Id = 7,
                Name = "Haneda Airport",
                ShorterName = "HND",
                City_Id = 7
            };
        }
        private void SeedFlights()
        {
            SofiaParis = new Flight()
            {
                Id = 1,
                Airline_Id = 4,
                DepartureAirport_Id = 6,
                ArrivalAirport_Id = 1,
                DepartureTime = DateTime.ParseExact("18:15", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("20:25", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 190,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 75m,
                IsActive = true
            };

            SofiaIstanbul = new Flight()
            {
                Id = 2,
                Airline_Id = 3,
                DepartureAirport_Id = 6,
                ArrivalAirport_Id = 4,
                DepartureTime = DateTime.ParseExact("15:55", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("18:25", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 90,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 131m,
                IsActive = true
            };

            SofiaMadrid = new Flight()
            {
                Id = 3,
                Airline_Id = 4,
                DepartureAirport_Id = 6,
                ArrivalAirport_Id = 2,
                DepartureTime = DateTime.ParseExact("06:40", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("09:35", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 235,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 91m,
                IsActive = true
            };

            SofiaRome = new Flight()
            {
                Id = 4,
                Airline_Id = 2,
                DepartureAirport_Id = 6,
                ArrivalAirport_Id = 5,
                DepartureTime = DateTime.ParseExact("10:15", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("11:05", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 110,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 99m,
                IsActive = true
            };

            ParisSofia = new Flight()
            {
                Id = 5,
                Airline_Id = 4,
                DepartureAirport_Id = 1,
                ArrivalAirport_Id = 6,
                DepartureTime = DateTime.ParseExact("21:00", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("00:50", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 170,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 75m,
                IsActive = true
            };

            IstanbulSofia = new Flight()
            {
                Id = 6,
                Airline_Id = 3,
                DepartureAirport_Id = 4,
                ArrivalAirport_Id = 6,
                DepartureTime = DateTime.ParseExact("08:45", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("09:00", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 75,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 131m,
                IsActive = true
            };

            MadridSofia = new Flight()
            {
                Id = 7,
                Airline_Id = 4,
                DepartureAirport_Id = 2,
                ArrivalAirport_Id = 6,
                DepartureTime = DateTime.ParseExact("13:45", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("18:10", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 205,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 91m,
                IsActive = true
            };

            RomeSofia = new Flight()
             {
                 Id = 8,
                 Airline_Id = 2,
                 DepartureAirport_Id = 5,
                 ArrivalAirport_Id = 6,
                 DepartureTime = DateTime.ParseExact("14:45", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                 ArrivalTime = DateTime.ParseExact("17:40", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                 FlightDuration = 120,
                 CabinClass = Enums.CabinClass.Economy,
                 TicketPrice = 99m,
                 IsActive = true
             };


            ParisIstanbul = new Flight()
            {
                Id = 9,
                Airline_Id = 3,
                DepartureAirport_Id = 1,
                ArrivalAirport_Id = 4,
                DepartureTime = DateTime.ParseExact("11:20", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("16:55", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 210,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 116m,
                IsActive = true
            };

            IstanbulParis = new Flight()
            {
                Id = 10,
                Airline_Id = 3,
                DepartureAirport_Id = 4,
                ArrivalAirport_Id = 1,
                DepartureTime = DateTime.ParseExact("15:35", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("17:20", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 225,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 116m,
                IsActive = true
            };

            ParisMadrid = new Flight()
            {
                Id = 11,
                Airline_Id = 5,
                DepartureAirport_Id = 1,
                ArrivalAirport_Id = 2,
                DepartureTime = DateTime.ParseExact("09:05", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("11:15", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 130,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 65m,
                IsActive = true
            };

            MadridParis = new Flight()
            {
                Id = 12,
                Airline_Id = 5,
                DepartureAirport_Id = 2,
                ArrivalAirport_Id = 1,
                DepartureTime = DateTime.ParseExact("14:55", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("17:05", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 130,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 65m,
                IsActive = true
            };

            ParisRome = new Flight()
            {
                Id = 13,
                Airline_Id = 5,
                DepartureAirport_Id = 1,
                ArrivalAirport_Id = 5,
                DepartureTime = DateTime.ParseExact("19:00", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("21:00", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 120,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 45m,
                IsActive = true
            };

            RomeParis = new Flight()
            {
                Id = 14,
                Airline_Id = 5,
                DepartureAirport_Id = 5,
                ArrivalAirport_Id = 1,
                DepartureTime = DateTime.ParseExact("06:30", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("08:45", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 135,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 45m,
                IsActive = true
            };


            IstanbulMadrid = new Flight()
            {
                Id = 15,
                Airline_Id = 3,
                DepartureAirport_Id = 4,
                ArrivalAirport_Id = 2,
                DepartureTime = DateTime.ParseExact("07:55", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("10:20", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 265,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 250m,
                IsActive = true
            };

            MadridIstanbul = new Flight()
            {
                Id = 16,
                Airline_Id = 3,
                DepartureAirport_Id = 2,
                ArrivalAirport_Id = 4,
                DepartureTime = DateTime.ParseExact("14:55", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("21:10", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 255,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 250m,
                IsActive = true
            };
           
            IstanbulRome = new Flight()
            {
                Id = 17,
                Airline_Id = 3,
                DepartureAirport_Id = 4,
                ArrivalAirport_Id = 5,
                DepartureTime = DateTime.ParseExact("09:15", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("09:55", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 140,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 150m,
                IsActive = true
            };
           
            RomeIstanbul = new Flight()
            {
                Id = 18,
                Airline_Id = 3,
                DepartureAirport_Id = 5,
                ArrivalAirport_Id = 4,
                DepartureTime = DateTime.ParseExact("20:00", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                ArrivalTime = DateTime.ParseExact("00:30", "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None),
                FlightDuration = 130,
                CabinClass = Enums.CabinClass.Economy,
                TicketPrice = 150m,
                IsActive = true
            };

            //Rome-Madrid, Madrid-Rome need to be implemented...

        }
    }
}
