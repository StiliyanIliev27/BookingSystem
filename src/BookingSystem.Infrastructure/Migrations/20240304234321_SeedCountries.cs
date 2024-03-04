using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Continent_Id", "CurrencyCode", "Details", "FlagImageUrl", "Language_Id", "Name", "Population" },
                values: new object[,]
                {
                    { 1, "Paris", 6, "EUR", "France, located in Western Europe, is renowned for its rich history, culture, and culinary excellence. Its capital, Paris, is home to iconic landmarks such as the Eiffel Tower and the Louvre Museum. France is known for its contributions to art, literature, and philosophy, with figures like Voltaire, Rousseau, and Monet shaping its cultural landscape. The country boasts diverse landscapes, from the picturesque vineyards of Bordeaux to the stunning beaches of the French Riviera. Additionally, France is a founding member of the European Union and plays a significant role in global diplomacy and trade.", "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/800px-Flag_of_France.svg.png", 12, "France", 64841258L },
                    { 2, "Madrid", 6, "EUR", "Spain, situated in southwestern Europe, is celebrated for its vibrant culture, stunning architecture, and lively festivals. The capital, Madrid, is famous for its art museums like the Prado and Reina Sofía, while Barcelona captivates with its unique blend of Catalan identity, exemplified by architectural masterpieces like the Sagrada Família and Park Güell designed by Antoni Gaudí. Spain's rich history is evident in its numerous UNESCO World Heritage Sites, including the Alhambra in Granada and the historic city of Toledo. Its culinary scene is diverse and flavorful, with tapas and paella being among its most iconic dishes. Additionally, Spain is known for its passion for soccer, with clubs like FC Barcelona and Real Madrid enjoying worldwide recognition.", "https://cdn.britannica.com/36/4336-050-056AC114/Flag-Spain.jpg", 2, "Spain", 47473373L },
                    { 3, "Washington, D.C.", 3, "USD", "The United States, located in North America, is the world's third-largest country by land area and population. It is a diverse nation, known for its cultural melting pot and vast landscapes, ranging from the bustling metropolises of New York City and Los Angeles to the stunning natural wonders of the Grand Canyon and Yellowstone National Park. The U.S. is a global economic powerhouse, with a highly developed economy driven by innovation, technology, and entrepreneurship. It has a rich history shaped by diverse immigrant communities, pivotal events such as the American Revolution and Civil Rights Movement, and iconic figures like Abraham Lincoln and Martin Luther King Jr. The country's political system is characterized by a federal republic with a strong emphasis on individual freedoms and democratic principles.", "https://cdn.britannica.com/33/4833-004-828A9A84/Flag-United-States-of-America.jpg", 3, "United States", 341223461L },
                    { 4, "Ankara", 1, "TRL", "Turkey, situated at the crossroads of Europe and Asia, boasts a rich historical and cultural heritage. Its largest city, Istanbul, straddles two continents and is famous for landmarks such as the Hagia Sophia and the Blue Mosque, reflecting its Byzantine and Ottoman influences. Turkey's diverse landscapes range from the Mediterranean coastline to the rugged mountains of Eastern Anatolia. The country is known for its cuisine, which includes dishes like kebabs, baklava, and Turkish delight. Modern Turkey is a secular republic with a parliamentary democracy, though its political landscape has experienced periods of turbulence. It plays a significant role in regional geopolitics, serving as a bridge between Europe and the Middle East.", "https://cdn.britannica.com/82/4782-004-4119489D/Flag-Turkey.jpg", 13, "Turkey", 86116034L },
                    { 5, "Rome", 6, "EUR", "Italy, located in southern Europe, is renowned for its rich history, art, and culinary traditions. Its capital, Rome, is home to iconic landmarks such as the Colosseum, the Vatican City, and the Pantheon, reflecting its status as the center of the ancient Roman Empire and the Catholic Church. Italy is a treasure trove of art and architecture, with masterpieces by Michelangelo, Leonardo da Vinci, and Botticelli housed in museums and churches throughout the country. Its diverse regions offer a range of landscapes, from the picturesque hills of Tuscany to the stunning coastlines of the Amalfi Coast and Cinque Terre. Italian cuisine is celebrated worldwide, with dishes like pasta, pizza, gelato, and espresso representing just a fraction of its culinary delights. Additionally, Italy is known for its fashion industry, luxury car brands, and vibrant cultural festivals.", "https://img.goodfon.com/original/5000x3333/c/cf/italy-italia-flag-of-italy-italian-flag-flag.jpg", 15, "Italy", 58753507L },
                    { 6, "Mexico City", 3, "MXN", "Mexico, situated in North America, is renowned for its rich cultural heritage, vibrant traditions, and diverse landscapes. Its capital, Mexico City, is one of the largest urban centers in the world and is home to historic sites such as the ancient Aztec temple of Templo Mayor and the impressive murals of Diego Rivera. Mexico's culinary scene is celebrated globally, with dishes like tacos, tamales, and mole showcasing the country's flavorful and diverse cuisine. The country boasts stunning natural wonders, including the beaches of Cancun and the biodiversity-rich jungles of Chiapas. Mexico has a complex history shaped by indigenous civilizations, Spanish colonization, and a modern struggle for social and economic development. Despite challenges, Mexico's people are known for their warmth, hospitality, and cultural pride.", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_Mexico.jpg/1024px-Flag_of_Mexico.jpg", 2, "Mexico", 129388467L },
                    { 7, "London", 6, "GBP", "England, the largest constituent country of the United Kingdom, is renowned for its rich history, cultural heritage, and iconic landmarks. Its capital, London, is a global city known for landmarks such as the Tower of London, Westminster Abbey, and the Houses of Parliament. England's diverse landscapes encompass bustling cities, picturesque countryside, and stunning coastlines, with attractions like the Lake District, Stonehenge, and the White Cliffs of Dover. The country has made significant contributions to literature, art, and science, with figures like William Shakespeare, Charles Dickens, and Isaac Newton shaping its cultural landscape. England's monarchy, led by the House of Windsor, remains an enduring symbol of tradition and continuity. Additionally, England is renowned for its love of football (soccer), with the English Premier League being one of the most-watched and competitive football leagues in the world.", "https://media.istockphoto.com/id/486407806/vector/union-jack.jpg?s=612x612&w=0&k=20&c=KPRndA_Czak9T0w_Eq3GnhRaNxERiEiw2cjZe5GBY-E=", 3, "England", 67961439L },
                    { 8, "Berlin", 3, "EUR", "Germany, located in central Europe, is known for its rich history, strong economy, and cultural contributions. Its capital, Berlin, is a dynamic city with a thriving arts scene, historical landmarks like the Brandenburg Gate, and vibrant nightlife. Germany has played a significant role in shaping European history, from the Holy Roman Empire to its more recent reunification after the fall of the Berlin Wall in 1989. The country is celebrated for its achievements in science, engineering, and philosophy, with figures like Albert Einstein, Johann Wolfgang von Goethe, and Ludwig van Beethoven among its cultural icons. Germany's economy is one of the largest in the world, driven by industries such as automotive manufacturing, engineering, and technology. Additionally, Germany is known for its festivals, including Oktoberfest in Munich and the Christmas markets held throughout the country during the holiday season.", "https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Flag_of_Germany.svg/2560px-Flag_of_Germany.svg.png", 4, "Germany", 83266096L },
                    { 9, "Athens", 3, "EUR", "Greece, situated in southeastern Europe, is renowned for its ancient civilization, stunning landscapes, and vibrant culture. Its capital, Athens, is home to iconic landmarks such as the Acropolis, Parthenon, and Temple of Olympian Zeus, showcasing its rich history as the birthplace of democracy and Western philosophy. Greece's coastline is dotted with picturesque islands like Santorini, Mykonos, and Crete, offering crystal-clear waters and charming villages. Greek cuisine is celebrated for its Mediterranean flavors, with dishes like moussaka, souvlaki, and tzatziki delighting food enthusiasts worldwide. The country's cultural legacy includes renowned poets like Homer and Nobel laureates such as Giorgos Seferis and Odysseas Elytis. Despite economic challenges in recent years, Greece remains a popular destination for travelers seeking history, beauty, and hospitality.", "https://upload.wikimedia.org/wikipedia/commons/0/0a/Flag_of_Greece.png", 10, "Greece", 10302720L },
                    { 10, "Vienna", 3, "EUR", "Austria, nestled in the heart of Europe, is renowned for its stunning Alpine landscapes, rich cultural heritage, and historical contributions. Its capital, Vienna, is famous for its imperial palaces, classical music, and vibrant coffeehouse culture. Austria's architectural treasures include landmarks such as Schönbrunn Palace, Hofburg Palace, and the iconic Stephansdom cathedral. The country has a long tradition of producing influential composers, including Mozart, Beethoven, and Strauss, making it a hub for classical music enthusiasts. Austria's Alpine regions offer opportunities for skiing, hiking, and scenic drives, attracting outdoor enthusiasts year-round. Additionally, Austrian cuisine is characterized by hearty dishes like schnitzel, strudel, and Sachertorte, accompanied by fine wines and beers. Austria's commitment to environmental sustainability and quality of life consistently ranks it among the world's most livable countries.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/2560px-Flag_of_Austria.svg.png", 4, "Austria", 8977139L },
                    { 11, "Sofia", 3, "BGN", "Bulgaria, located in southeastern Europe, is known for its diverse landscapes, rich history, and cultural heritage. Its capital, Sofia, is home to ancient landmarks such as the Alexander Nevsky Cathedral and the National Palace of Culture, reflecting its long history as a crossroads between East and West. Bulgaria's natural beauty includes the majestic peaks of the Balkan Mountains, the sandy beaches of the Black Sea coast, and picturesque countryside dotted with traditional villages. The country has a rich cultural heritage, with influences from Thracian, Greek, Roman, and Ottoman civilizations evident in its architecture, cuisine, and traditions. Bulgarian cuisine is hearty and flavorful, with dishes like banitsa (a pastry filled with cheese), kebapche (grilled minced meat), and shopska salad (a refreshing mix of tomatoes, cucumbers, peppers, and cheese). Despite economic challenges, Bulgaria is a country of resilience, offering visitors a blend of history, nature, and warm hospitality.", "https://t3.ftcdn.net/jpg/01/01/18/68/360_F_101186804_qHCSqaphnoDq21DiftORwwDrjEApaewH.jpg", 9, "Bulgaria", 6618615L },
                    { 12, "Moscow", 1, "RUB", "Russia, the largest country in the world by land area, is known for its vast landscapes, rich history, and cultural heritage. Its capital, Moscow, is a bustling metropolis with iconic landmarks such as the Kremlin, Red Square, and St. Basil's Cathedral. Russia's other major city, St. Petersburg, is renowned for its elegant palaces, world-class museums like the Hermitage, and the picturesque canals of the historic center. The country has a complex history, from the Tsarist era to the Soviet period, and has made significant contributions to literature, music, and science, with figures like Tolstoy, Tchaikovsky, and Mendeleev leaving a lasting legacy. Russia's natural beauty includes the rugged mountains of the Caucasus, the vast Siberian wilderness, and the pristine shores of Lake Baikal, the deepest lake in the world. Despite its challenges, Russia remains a global power with a rich cultural tapestry and a diverse population representing numerous ethnic groups and cultures.", "https://upload.wikimedia.org/wikipedia/en/thumb/f/f3/Flag_of_Russia.svg/640px-Flag_of_Russia.svg.png", 8, "Russia", 143957079L },
                    { 13, "Belgrade", 6, "RSD", "Serbia, located in southeastern Europe, is known for its rich history, cultural heritage, and warm hospitality. Its capital, Belgrade, is a vibrant city with a lively nightlife, historic architecture, and picturesque waterfronts along the Danube and Sava rivers. Serbia's history is deeply intertwined with the Byzantine, Ottoman, and Austro-Hungarian empires, reflected in its diverse architecture, cuisine, and traditions. The country boasts numerous medieval monasteries, such as Studenica and Žiča, which are UNESCO World Heritage Sites. Serbian cuisine is hearty and flavorful, with dishes like čevapi (grilled minced meat), sarma (stuffed cabbage rolls), and ajvar (a roasted red pepper spread) being popular staples. Despite challenges, Serbia is a country of resilience, offering visitors a blend of history, natural beauty, and cultural experiences.", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Flag_of_Serbia.svg/2560px-Flag_of_Serbia.svg.png", 14, "Serbia", 7113869L },
                    { 14, "Budapest", 6, "HUF", "Hungary, located in Central Europe, is known for its rich history, vibrant culture, and stunning architecture. Its capital, Budapest, is famous for its grandeur, with landmarks such as the majestic Parliament Building, the historic Buda Castle, and the iconic Chain Bridge spanning the Danube River. Hungary's thermal baths, including the famous Széchenyi and Gellért Baths, are popular attractions offering relaxation and rejuvenation. Hungarian cuisine is hearty and flavorful, with dishes like goulash, lángos (fried dough), and dobos torte (layered sponge cake) delighting food enthusiasts. The country's cultural scene is diverse, with a strong tradition in classical music, folk dance, and literature. Despite its relatively small size, Hungary has made significant contributions to science, technology, and mathematics throughout history.", "https://upload.wikimedia.org/wikipedia/commons/0/00/Flag_of_Hungary.png", 18, "Hungary", 9994993L },
                    { 15, "Bucharest", 6, "RON", "Romania, located in southeastern Europe, is known for its stunning landscapes, rich history, and diverse cultural heritage. Its capital, Bucharest, is a bustling city with a mix of architectural styles, including elegant Belle Époque buildings and imposing communist-era structures. Romania's countryside is dotted with picturesque villages, medieval castles, and the stunning Carpathian Mountains, home to wildlife and pristine natural beauty. The country has a rich cultural heritage, influenced by its Roman, Byzantine, Ottoman, and Hungarian roots, which is evident in its cuisine, music, and traditions. Romanian cuisine features hearty dishes like sarmale (stuffed cabbage rolls), mămăligă (polenta), and cozonac (sweet bread), often enjoyed with local wines and tuică, a traditional plum brandy. Romania is also known for its contributions to literature, with figures like Mircea Eliade and Emil Cioran gaining international recognition. Despite challenges, Romania offers visitors a unique blend of history, nature, and warm hospitality.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Romania.svg/1280px-Flag_of_Romania.svg.png", 17, "Romania", 19706234L },
                    { 16, "Beijing", 1, "CNY", "China, located in East Asia, is the world's most populous country and one of the oldest civilizations, with a history spanning over 5,000 years. Its capital, Beijing, is home to iconic landmarks such as the Great Wall, the Forbidden City, and the Temple of Heaven, reflecting its ancient imperial past. China's rapid economic growth has transformed it into a global powerhouse, with cities like Shanghai, Guangzhou, and Shenzhen serving as centers of commerce, innovation, and technology. The country's diverse landscapes range from the majestic mountains of Tibet to the bustling metropolises of the eastern seaboard and the picturesque countryside of regions like Guilin and Yunnan. Chinese cuisine is renowned worldwide for its variety, flavors, and regional specialties, with dishes like Peking duck, dim sum, and Sichuan hotpot enticing food enthusiasts. China's rich cultural heritage includes contributions to philosophy, literature, art, and martial arts, with figures like Confucius, Li Bai, and Bruce Lee leaving a lasting legacy. Despite its modernization, China maintains a deep reverence for its traditions and customs, making it a fascinating blend of old and new.", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/2560px-Flag_of_the_People%27s_Republic_of_China.svg.png", 1, "China", 1425337966L },
                    { 17, "New Delhi", 1, "INR", "India, located in South Asia, is a vibrant and diverse country known for its rich history, cultural heritage, and spiritual traditions. Its capital, New Delhi, is a bustling metropolis with a mix of ancient monuments like the Red Fort and modern skyscrapers. India is home to a multitude of religions, languages, and ethnicities, contributing to its colorful tapestry of cultures. The country's landmarks include the iconic Taj Mahal in Agra, the holy city of Varanasi on the banks of the Ganges River, and the ancient temples of Khajuraho and Hampi. Indian cuisine is celebrated worldwide for its spices, flavors, and regional variations, with dishes like curry, biryani, dosa, and samosa captivating food enthusiasts. India's contributions to science, mathematics, literature, and philosophy date back thousands of years, with figures like Aryabhata, Rabindranath Tagore, and Swami Vivekananda leaving a lasting impact. Despite its challenges, India's resilience, cultural richness, and economic growth make it a dynamic and fascinating country.", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/India-flag-a4.jpg/1280px-India-flag-a4.jpg", 6, "India", 1441719852L },
                    { 18, "Abu Dhabi", 1, "AED", "The United Arab Emirates (UAE) is a federation of seven emirates located in the Arabian Peninsula, known for its modern cities, luxurious lifestyle, and rich cultural heritage. Its most famous city, Dubai, is a global hub for business, tourism, and entertainment, renowned for its futuristic skyline, extravagant shopping malls, and iconic landmarks such as the Burj Khalifa, the world's tallest building. Abu Dhabi, the capital of the UAE, is home to cultural institutions like the Louvre Abu Dhabi and the Sheikh Zayed Grand Mosque, showcasing the country's commitment to arts and heritage. The UAE's economy is fueled by oil wealth but has diversified into sectors like finance, tourism, and real estate. Despite its rapid modernization, the UAE maintains its traditional values and customs, with Emirati culture characterized by hospitality, respect for tradition, and a strong sense of community. Additionally, the UAE is known for hosting international events like the Dubai Expo and Formula One Grand Prix, further solidifying its position as a global destination for business and leisure.", "https://media.istockphoto.com/id/472330093/vector/large-image-of-the-united-arab-emirates-flag.jpg?s=612x612&w=0&k=20&c=kUmMdjXjTQKJoijQEokPD6iLDSURrbp_6nT9MtNODTY=", 5, "United Arab Emirates", 9567209L },
                    { 19, "Cairo", 2, "EGP", "Egypt, situated in North Africa and the Middle East, is renowned for its ancient civilization, iconic monuments, and rich cultural heritage. Its capital, Cairo, is a bustling metropolis with a mix of modernity and historical treasures, including the Giza Pyramids, the Sphinx, and the Egyptian Museum, home to a vast collection of artifacts from pharaonic times. Egypt's Nile River, the longest in the world, has played a central role in the country's history and sustains much of its population through agriculture and tourism. The country's Red Sea coast is famous for its pristine beaches and world-class diving sites, attracting tourists from around the globe. Egyptian cuisine is flavorful and diverse, with dishes like koshari, falafel, and ful medames representing the country's culinary traditions. Egypt's cultural influence extends far beyond its borders, with its ancient wonders and mythology inspiring art, literature, and films worldwide. Despite challenges, Egypt remains a captivating destination for travelers seeking history, adventure, and timeless beauty.", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Egypt.svg/800px-Flag_of_Egypt.svg.png", 5, "Egypt", 113903534L },
                    { 20, "Brazil", 4, "BRL", "Brazil, located in South America, is the largest country in both area and population in the region, known for its stunning natural landscapes, vibrant culture, and diverse ecosystems. Its most famous city, Rio de Janeiro, is renowned for its iconic landmarks such as the Christ the Redeemer statue, Copacabana Beach, and the annual Carnival festival, one of the largest in the world. Brazil's Amazon Rainforest is the largest tropical rainforest on Earth and is home to an incredible array of plant and animal species. The country's cultural heritage is rich and varied, with influences from indigenous peoples, African slaves, and European settlers shaping its music, dance, and cuisine. Brazilian cuisine is a delicious fusion of flavors, with dishes like feijoada (a hearty stew), churrasco (barbecue), and brigadeiro (chocolate truffle) being popular favorites. Despite economic and social challenges, Brazil's warmth, energy, and natural beauty make it a fascinating destination for travelers from around the globe.", "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/2560px-Flag_of_Brazil.svg.png", 7, "Brazil", 219624301L },
                    { 21, "Tokyo", 1, "JPY", "Japan, an island nation located in East Asia, is known for its unique blend of ancient traditions and cutting-edge modernity. Its capital, Tokyo, is a bustling metropolis with towering skyscrapers, high-tech innovations, and vibrant street life. Japan's cultural heritage is rich and diverse, with landmarks such as Kyoto's temples and gardens, Hiroshima's Peace Memorial Park, and the iconic Mount Fuji symbolizing its spiritual and historical significance. Japanese cuisine, including sushi, tempura, and ramen, is celebrated worldwide for its freshness, quality, and meticulous preparation. The country is renowned for its contributions to technology, manufacturing, and pop culture, with brands like Sony, Toyota, and Nintendo shaping global trends. Japan's society is characterized by a strong sense of community, respect for tradition, and emphasis on harmony and order. Despite its densely populated cities, Japan boasts serene natural landscapes, including cherry blossom forests, hot springs, and scenic coastal regions. Overall, Japan offers visitors a captivating blend of tradition and innovation, making it a fascinating destination for exploration and discovery.", "https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Flag_of_Japan.svg/1200px-Flag_of_Japan.svg.png", 11, "Japan", 122844590L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}
