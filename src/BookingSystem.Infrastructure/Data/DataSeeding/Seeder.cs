namespace BookingSystem.Infrastructure.Data.DataSeeding
{
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using BookingSystem.Infrastructure.Data.Models.Landmarks;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using BookingSystem.Infrastructure.Data.Models.Roles;
    using Microsoft.AspNetCore.Identity;
    using System.Globalization;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Hotel;
    internal class Seeder
    {
        /// <summary>
        ///Seeder Constructor
        /// </summary>
        public Seeder()
        {
            SeedUsers();
            SeedAdministrator();
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
        public IdentityUser AdministratorUser { get; set; } = null!;
        public IdentityUser GuestUser { get; set; } = null!;

        #endregion


        #region Roles
        public Administrator Administrator { get; set; } = null!;

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
            var hasher = new PasswordHasher<IdentityUser>();

            AdministratorUser = new IdentityUser()
            {
                Id = "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                UserName = "Administrator",
                NormalizedUserName = "administrator",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com"
            };

            AdministratorUser.PasswordHash = hasher.HashPassword(AdministratorUser, "admin777");

            GuestUser = new IdentityUser()
            {
                Id = "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                UserName = "Guest",
                NormalizedUserName = "guest",
                Email = "guest@gmail.com",
                NormalizedEmail = "guest@gmail.com"
            };

            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "guest777");
        }
        private void SeedAdministrator()
        {
            Administrator = new Administrator()
            {
                Id = 1,
                UserId = AdministratorUser.Id
            };
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
                Continent_Id = 3,
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
                Country_Id = 1
            };

            Madrid = new City()
            {
                Id = 2,
                Name = "Madrid",
                Area = "8,028 km²",
                Details = "Madrid, the capital of Spain, is a vibrant metropolis known for its lively atmosphere, rich history, and cultural treasures. Visitors can explore world-class art museums such as the Prado and Reina Sofía, wander through historic neighborhoods like the Barrio de las Letras, and indulge in delicious tapas at bustling markets like Mercado de San Miguel. With its beautiful parks, grand boulevards, and dynamic nightlife, Madrid offers a captivating blend of tradition and modernity for travelers to enjoy.",
                Country_Id = 2          
            };

            NewYork = new City()
            {
                Id = 3,
                Name = "New York",
                Population = 19_034_000,
                Area = "783,8 km²",
                Details = "New York City, often referred to as the \"Big Apple,\" is a bustling metropolis known for its iconic skyline, diverse culture, and vibrant energy. Visitors can explore world-famous landmarks such as the Statue of Liberty, Times Square, and Central Park, or immerse themselves in the city's rich cultural scene by visiting museums like the Metropolitan Museum of Art or catching a Broadway show. With its endless array of dining options, shopping districts, and neighborhoods to explore, New York City offers an unforgettable experience for travelers from around the world.",
                Country_Id = 3
            };

            Istanbul = new City()
            {
                Id = 4,
                Name = "Istanbul",
                Population = 16_047_000,
                Area = "5 461 km²",
                Details = "Istanbul, the largest city in Turkey, is a mesmerizing blend of cultures, history, and modernity. It straddles two continents, Europe and Asia, and is known for its stunning architectural wonders such as the Hagia Sophia, Blue Mosque, and Topkapi Palace. Visitors can wander through the bustling streets of the Grand Bazaar, cruise along the Bosphorus, or savor delicious Turkish cuisine in traditional meyhanes (taverns). With its rich history as the former capital of the Byzantine and Ottoman Empires, Istanbul offers a unique and unforgettable experience for travelers.",
                Country_Id = 4
            };

            Rome = new City()
            {
                Id = 5,
                Name = "Rome",
                Population = 4_332_000,
                Area = "1,285 km²",
                Details = "Rome, the capital city of Italy, is a timeless destination steeped in history, art, and culture. Known as the \"Eternal City,\" Rome is home to iconic landmarks such as the Colosseum, Roman Forum, and Vatican City, which houses St. Peter's Basilica and the Sistine Chapel. Visitors can wander through cobblestone streets lined with ancient ruins, marvel at Renaissance masterpieces in museums and churches, and indulge in authentic Italian cuisine at trattorias and gelaterias. With its blend of ancient wonders and modern delights, Rome offers an unforgettable experience for travelers seeking to immerse themselves in the heart of Italy's rich heritage.",
                Country_Id = 5
            };

            Sofia = new City()
            {
                Id = 6,
                Name = "Sofia",
                Population = 1_288_000,
                Area = "492 km²",
                Details = "Sofia, the capital city of Bulgaria, is a dynamic metropolis with a rich history and vibrant culture. Visitors can explore its diverse architectural heritage, including ancient Roman ruins, Byzantine churches, and Ottoman mosques, alongside modern landmarks like the National Palace of Culture and the Alexander Nevsky Cathedral. The city also offers charming parks, bustling markets, and a burgeoning culinary scene, making it a fascinating destination for travelers looking to discover the unique blend of influences that shape Bulgaria's capital.",
                Country_Id = 11
            };

            Tokyo = new City()
            {
                Id = 7,
                Name = "Tokyo",
                Population = 37_115_035,
                Area = "2 194 km²",
                Details = "Tokyo, the capital of Japan, is a bustling metropolis where tradition meets innovation. Visitors can explore the city's iconic landmarks such as the historic Senso-ji Temple in Asakusa, the futuristic skyscrapers of Shinjuku, and the serene gardens of the Imperial Palace. With its vibrant neighborhoods, bustling street markets, and world-renowned cuisine ranging from sushi to ramen, Tokyo offers a captivating blend of old-world charm and modern excitement for travelers to experience and enjoy.",
                Country_Id = 21
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
                IsActive = true
            };

            PlazaMayor = new Landmark()
            {
                Id = 4,
                Name = "Plaza Mayor",
                Address = "Calle Gerona 4, 28012 Madrid Spain",
                Details = "Huge plaza packed with cafes, bars and tourists.",
                City_Id = 2,
                IsActive = true
            };

            CentralPark = new Landmark()
            {
                Id = 5,
                Name = "Central Park",
                Address = "59th to 110th Street Manhattan Borough, NY 10022",
                Details = "For more than 150 years, visitors have flocked to Central Park's 843 green acres in the heart of Manhattan. Since 1980, the Park has been managed by the Central Park Conservancy, in partnership with the public. Central Park is open 6 am to 1 am daily. Visit the official website of Central Park to learn more about Park happenings and activities and to learn how you to help Central Park!",
                City_Id = 4,
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
                IsActive = true
            };

            HagiaSophia = new Landmark()
            {
                Id = 7,
                Name = "Hagia Sophia Mosque",
                Address = "Sultan Ahmet, Ayasofya Meydanı No:1, Istanbul 34122 Türkiye",
                Details = "This architectural marvel displays 30 million gold tiles throughout its interior, and a wide, flat dome which was a bold engineering feat at the time it was constructed in the 6th century.",
                City_Id = 4,
                IsActive = true
            };
           
            BasilicaCistern = new Landmark()
            {
                Id = 8,
                Name = "Basilica Cistern",
                Address = "Alemdar Mahallesi, Yerebatan Caddesi, No:1/3, Istanbul 34410 TÃ¼rkiye",
                Details = "The Basilica Cistern, or Sunken Palace, in Istanbul's Sultanahmet district dates back to the 6th century. It's the largest surviving cistern from the Byzantine era, featuring over 330 marble and granite columns, including two famous Medusa heads. Recognizable from \"From Russia with Love,\" it's a must-visit spot along with Hagia Sophia and Topkapi Palace. Joining a tour can streamline your visit to these iconic Istanbul landmarks.",
                City_Id = 4,
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
                TicketPrice = 38.86m
            };
           
            Pantheon = new Landmark()
            {
                Id = 10,
                Name = "Pantheon",
                Address = "Piazza della Rotonda, 00186 Rome Italy",
                Details = "Dedicated to the seven planetary divinities and featuring an interior of gorgeous marble, the Pantheon is one of the most impressive monuments of Augustan Rome.",
                City_Id = 5,
                IsActive = true
            };
            
            StAlexanderNevskiCathedral = new Landmark()
            {
                Id = 11,
                Name = "St. Alexander Nevski Cathedral",
                Address = "Sofia Center, pl.Sveti Aleksandar Nevski, 1000 Sofia",
                Details = "Completed in 1912, St. Alexander Nevsky Patriarchal Cathedral Stauropigial Memorial-Church is an impressive landmark in Sofia. The church was built as a memorial to the 200,000 Russian soldiers who died in the Russo-Turkish Liberation War (1877-1878).",
                City_Id = 6,
                IsActive = true
            };
           
            CatedralDeSvetaNedelya = new Landmark()
            {
                Id = 12,
                Name = "Catedral de Sveta-Nedelya",
                Address = "pl.Sveta Nedelya, Sofia 1000 Bulgaria",
                Details = "The Cathedral of Sveta-Nedelya, also known as the Cathedral of the Holy Virgin, is an Orthodox church located in the center of Sofia, the capital of Bulgaria. It was completed in 1867 in a neo-Byzantine style. The cathedral has witnessed significant historical events, including a bomb attack in 1925 by a communist group that resulted in numerous casualties. Today, it remains an important religious and tourist destination, showcasing impressive architecture and a rich cultural heritage.",
                City_Id = 6,
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
                TicketPrice = 15.00m
            };
           
            SensoJiTemple = new Landmark()
            {
                Id = 14,
                Name = "Senso-ji Temple",
                Address = "2-3-1, Asakusa, Taito 111-0032 Tokyo Prefecture",
                Details = "According to legend, two brothers kept trying to return a statue of Kannon, the goddess of mercy, to the Sumida River only to have it returned to them the next day. This temple located in Tokyo's Asakusa district was built to honor her.",
                City_Id = 7,
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
                CheckIn = DateTime.ParseExact("15:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                CheckOut = DateTime.ParseExact("11:00", TimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None),
                Parking = true,
                Pets = false,
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
                IsReserved = false,
                IsActive = true
            };

            IbisParisRoomDouble = new Room()
            {
                Id = 2,
                Type = Enums.RoomType.Double,
                Hotel_Id = 1,
                PricePerNight = 302m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            IbisParisRoomTriple = new Room()
            {
                Id = 3,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 1,
                PricePerNight = 578m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            IbisParisRoomApartment = new Room()
            {
                Id = 4,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 1,
                PricePerNight = 630m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            KraftHotelRoomSingle = new Room()
            {
                Id = 5,
                Type = Enums.RoomType.Single,
                Hotel_Id = 3,
                PricePerNight = 630m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            KraftHotelRoomDouble = new Room()
            {
                Id = 6,
                Type = Enums.RoomType.Double,
                Hotel_Id = 3,
                PricePerNight = 470m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            SaintMarcelRoomSingle = new Room()
            {
                Id = 7,
                Type = Enums.RoomType.Single,
                Hotel_Id = 3,
                PricePerNight = 216m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            SaintMarcelRoomDouble = new Room()
            {
                Id = 8,
                Type = Enums.RoomType.Double,
                Hotel_Id = 3,
                PricePerNight = 157m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            //Madrid

            PestanaPlazaRoomSingle = new Room()
            {
                Id = 9,
                Type = Enums.RoomType.Single,
                Hotel_Id = 4,
                PricePerNight = 433m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            PestanaPlazaRoomDouble = new Room()
            {
                Id = 10,
                Type = Enums.RoomType.Double,
                Hotel_Id = 4,
                PricePerNight = 488m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            PestanaPlazaRoomTriple = new Room()
            {
                Id = 11,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 4,
                PricePerNight = 644m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            CataloniaPuertaRoomSingle = new Room()
            {
                Id = 12,
                Type = Enums.RoomType.Single,
                Hotel_Id = 5,
                PricePerNight = 201m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            CataloniaPuertaRoomDouble = new Room()
            {
                Id = 13,
                Type = Enums.RoomType.Double,
                Hotel_Id = 5,
                PricePerNight = 201m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            HostalCentralPalaceRoomDouble = new Room()
            {
                Id = 14,
                Type = Enums.RoomType.Double,
                Hotel_Id = 6,
                PricePerNight = 197m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            //New York

            TimesSquareHotelRoomDouble = new Room()
            {
                Id = 15,
                Type = Enums.RoomType.Double,
                Hotel_Id = 9,
                PricePerNight = 193m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            TimesSquareHotelRoomTriple = new Room()
            {
                Id = 16,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 9,
                PricePerNight = 244m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            HiltonGardenRoomDouble = new Room()
            {
                Id = 17,
                Type = Enums.RoomType.Double,
                Hotel_Id = 8,
                PricePerNight = 195m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            HiltonGardenRoomTriple = new Room()
            {
                Id = 18,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 8,
                PricePerNight = 238m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            HiltonGardenRoomApartment = new Room()
            {
                Id = 19,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 8,
                PricePerNight = 248m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            PrinceKitanoRoomDouble = new Room()
            {
                Id = 20,
                Type = Enums.RoomType.Double,
                Hotel_Id = 7,
                PricePerNight = 314m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            PrinceKitanoRoomApartment = new Room()
            {
                Id = 21,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 7,
                PricePerNight = 351m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            //Sofia

            HotelZOORoomSingle = new Room()
            {
                Id = 22,
                Type = Enums.RoomType.Single,
                Hotel_Id = 10,
                PricePerNight = 70m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            HotelZOORoomDouble = new Room()
            {
                Id = 23,
                Type = Enums.RoomType.Double,
                Hotel_Id = 10,
                PricePerNight = 78m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            HotelZOORoomTriple = new Room()
            {
                Id = 24,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 10,
                PricePerNight = 104m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            EurostarsSofiaRoomSingle = new Room()
            {
                Id = 25,
                Type = Enums.RoomType.Single,
                Hotel_Id = 11,
                PricePerNight = 71m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            EurostarsSofiaRoomDouble = new Room()
            {
                Id = 26,
                Type = Enums.RoomType.Double,
                Hotel_Id = 11,
                PricePerNight = 80m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            EurostarsSofiaRoomTriple = new Room()
            {
                Id = 27,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 11,
                PricePerNight = 161m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            EurostarsSofiaRoomApartment = new Room()
            {
                Id = 28,
                Type = Enums.RoomType.Apartment,
                Hotel_Id = 11,
                PricePerNight = 173m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            PremierSofiaRoomSingle = new Room()
            {
                Id = 29,
                Type = Enums.RoomType.Single,
                Hotel_Id = 12,
                PricePerNight = 112m,
                WiFi = true,
                IsReserved = false,
                IsActive = true,
            };

            PremierSofiaRoomDouble = new Room()
            {
                Id = 30,
                Type = Enums.RoomType.Double,
                Hotel_Id = 12,
                PricePerNight = 125m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            PremierSofiaRoomTriple = new Room()
            {
                Id = 31,
                Type = Enums.RoomType.Triple,
                Hotel_Id = 12,
                PricePerNight = 190m,
                WiFi = true,
                IsReserved = false,
                IsActive = true
            };

            //Istanbul
           
            EminPalaceRoomSingle = new Room()
            {
                Id = 32,
                Type = Enums.RoomType.Single,
                Hotel_Id = 13,
                PricePerNight = 95m,
                WiFi = true,
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                IsReserved = false,
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
                City_Id = 1
            };

            MadridAirport = new Airport()
            {
                Id = 2,
                Name = "Madrid–Barajas Airport",
                City_Id = 2
            };

            NewYorkAirport = new Airport()
            {
                Id = 3,
                Name = "John F. Kennedy International Airport",
                City_Id = 3
            };

            IstanbulAirport = new Airport()
            {
                Id = 4,
                Name = "Istanbul International Airport",
                City_Id = 4
            };

            RomeAirport = new Airport()
            {
                Id = 5,
                Name = "Leonardo da Vinci–Fiumicino Airport",
                City_Id = 5
            };

            SofiaAirport = new Airport()
            {
                Id = 6,
                Name = "Sofia International Airport",
                City_Id = 6
            };

            TokyoAirport = new Airport()
            {
                Id = 7,
                Name = "Haneda Airport",
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
