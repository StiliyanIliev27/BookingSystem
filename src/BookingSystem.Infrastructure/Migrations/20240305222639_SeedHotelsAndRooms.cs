using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedHotelsAndRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckIn", "CheckOut", "City_Id", "Details", "IsActive", "Name", "Parking", "Pets", "StarRate" },
                values: new object[,]
                {
                    { 1, "11 Rue Du Texel, 14th arr., 75014", new DateTime(2024, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ideally set in the 14th arr. District of Paris, Ibis Paris Gare Montparnasse Catalogne is located 1.6 miles from Rodin Museum, 1.6 miles from Luxembourg Gardens and 2 miles from Orsay Museum. With a bar, the 3-star hotel has air-conditioned rooms with free WiFi, each with a private bathroom. Private parking is available on site.\r\n\r\nAt the hotel, rooms have a closet. The rooms include a desk and a flat-screen TV, and some accommodations at Ibis Paris Gare Montparnasse Catalogne have a balcony.\r\n\r\nA buffet, continental or American breakfast is available each morning at the property.\r\n\r\nSpeaking English, Spanish, French and Ukrainian at the 24-hour front desk, staff are ready to help around the clock.\r\n\r\nSainte Chapelle is 2 miles from the accommodation, while Paris Expo – Porte de Versailles is 2.1 miles from the property. The nearest airport is Paris - Orly Airport, 8.1 miles from Ibis Paris Gare Montparnasse Catalogne.", true, "Ibis Paris Gare Montparnasse Catalogne", true, true, 3 },
                    { 2, "43 Boulevard Saint-Marcel, 13th arr., 75013", new DateTime(2024, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, "You're eligible for a Genius discount at Hôtel Saint Marcel! To save at this property, all you have to do is sign in.\r\n\r\nFeaturing free Wi-Fi, Hôtel Saint Marcel offers accommodations in Paris, 1.2 mi from AccorHotels Arena. Guests can make use of the fitness area in the gym\r\n\r\nRooms feature a flat-screen TV with satellite channels. Certain rooms have a seating area where you can relax. For your comfort, you will find free toiletries and a hairdryer in the bathroom.\r\n\r\nYou will find a 24-hour front desk at the property.\r\n\r\nNoter Dame Cathedral is 1.2 mi from Hôtel Saint Marcel, while Opéra Bastille is 1.2 mi away. The nearest airport is Orly Airport, 7.5 mi from the property.", true, "Hôtel Saint Marcel", false, false, 3 },
                    { 3, "37, rue du Hameau, 15th arr., 75015", new DateTime(2024, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, "You're eligible for a Genius discount at Kraft Hotel! To save at this property, all you have to do is sign in.\r\n\r\nThis hotel is located opposite the main entrance of Dôme de Paris - Palais des Sports, near the lively Vaugirard area with its boutiques, cafés and lovely restaurants.\r\n\r\nThe ambiance of the Kraft Hotel suits perfectly the diversity of guests who come to stay: those who come to discover the treasures of Paris and those who come to attend a show, symposium, fair or exposition.\r\n\r\nGuestrooms are stylishly decorated and furnished to offer you high-quality comfort. They offer a private bathroom and a TV.\r\n\r\nThe Kraft Hotel is an ideal location for business or leisure. It is located near the local metro station which offers direct access into the heart of the capital.", true, "Kraft Hotel", false, false, 4 },
                    { 4, "Calle Imperial 8, Centro, 28012", new DateTime(2024, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "Less than 1 km from Mercado San Miguel and a 13-minute walk from Puerta de Toledo, the property offers a terrace and a bar. The accommodation provides a 24-hour front desk, spa and free WiFi is available.\r\n\r\nAt the hotel, every room comes with a desk and a flat-screen TV. The private bathroom is equipped with a shower, free toiletries and a hair dryer. The units at Pestana Plaza Mayor Madrid have air conditioning and a wardrobe.\r\n\r\nA buffet breakfast is available daily at the property.\r\n\r\nPestana Plaza Mayor Madrid is located in Plaza Mayor, while Thyssen-Bornemisza Museum is 1.1 km from the property. Adolfo Suarez Madrid-Barajas Airport is 13.8 km away.", true, "Pestana Plaza Mayor Madrid", true, false, 4 },
                    { 5, "Atocha, 23, Centro, 28012", new DateTime(2024, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "Catalonia Puerta del Sol is set in a magnificent 18th-century building in the historic centre of Madrid, a few minutes from Puerta del Sol. It offers free Wi-Fi throughout the hotel.\r\n\r\nThe hotel is just 50 metres from Puerta del Sol, Madrid's main square and from main tapas restaurants. You can walk to Madrid's famous Art Triangle in 15 minutes. Atocha Train Station is 1 km away.\r\n\r\nThe air-conditioned rooms feature parquet floors and smart décor. ach one has flat-screen satellite smart TV with Chromecast app, a private bathroom and a minibar.\r\n\r\nThe Puerta del Sol's restaurant serves a buffet breakfast each morning, and available until 12:00 at weekends. There is also a bar with a roofed terrace, El Patio, where you can get a snack or a drink. There is also a patio with crystal domes.\r\n\r\nAll hotel rooms have smart TVs, which are equipped with Chromecast app.", true, "Catalonia Puerta del Sol", true, true, 4 },
                    { 6, "Plaza de Oriente 2, 3º izquierda, Centro, 28013", new DateTime(2024, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "Centrally located overlooking the Royal Palace and Sabatini Gardens in Madrid’s Plaza de Oriente, this elegant guest house offers 24-hour reception and free WiFi.\r\n\r\nThe spacious rooms at Hostal Central Palace Madrid feature wooden floors and classic décor. They all feature a private bathroom with shower and a hairdryer and toiletries. Some rooms offer views of the Royal Palace, Almudena Cathedral and the Sabatini Gardens.\r\n\r\nThere are many shops, bars and restaurants are within a short walk.\r\n\r\nLuggage storage is offered. Staff at reception can provide information about what to see and do in Madrid. There are also various car parks within a short walk.\r\n\r\nHostal Central Palace Madrid is the only guest house located in the Plaza de Oriente square, opposite the Royal Palace. It is 200 metres from Opera Metro Station and 10 minutes’ walk from Puerta del Sol.", true, "Hostal Central Palace Madrid", false, false, 1 },
                    { 7, "66 Park Avenue, Murray Hill, New York, NY 10016", new DateTime(2024, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, "This Japanese-style hotel is located 500 metres from Grand Central Station and features a rotating repertoire of gallery pieces in the lobby. There are 2 on-site restaurants.\r\n\r\nKitano New York features rooms with flat-screen TVs, iPod docking stations and a work desk. Free Japanese green tea and dressing gowns and slippers are provided.\r\n\r\nHakubai Restaurant at the New York Kitano serves gourmet Japanese cuisine for lunch and dinner. Guests can also have American and European dishes at Jazz at The Kitano Restaurant. In the evening, the Bar Lounge serves a full selection of cocktails.\r\n\r\nAvailable services at the Kitano include car rental, a tour desk, foreign currency exchange and a gift shop. The hotel also features a fitness centre, laundry facilities and dry cleaning.\r\n\r\nThe Empire State Building is 645 metres from the Kitano Manhattan.", true, "The Prince Kitano New York", true, false, 4 },
                    { 8, "326 West 37th Street , Hell's Kitchen, New York, NY 10018", new DateTime(2024, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, "The Hilton Garden Inn New York Times Square South is located less than 1 km away from Jacob K. Javits Convention Centre and 1.3 km from Times Square. Complimentary WiFi is provided.\r\n\r\nAll rooms at this property are fitted with a flat-screen TV, coffee maker, microwave and mini-refrigerator. A desk with an ergonomic chair are also provided.\r\n\r\nGuests will have access to free coffee in the morning and a fitness centre. The 24-hour Garden Market will carry snacks and sundry items.\r\n\r\nLaGuardia Airport is 18.3 km from the property while JFK Airport is 27 km from Hilton Garden Inn New York Times Square South. The Empire State Building is 1.6 km away.", true, "Hilton Garden Inn New York Times Square South", true, true, 3 },
                    { 9, "125 West 45th Street, New York, NY 10036", new DateTime(2024, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, "Featuring 3-star accommodation, 45 Times Square Hotel is located in New York, 200 metres from Times Square and 500 metres from Radio City Music Hall. With free WiFi, this 3-star hotel offers a 24-hour front desk and a tour desk. The property is 600 metres from Bryant Park, and within 300 metres of the city centre.\r\n\r\nPopular points of interest near the hotel include Broadway Theatre, Rockefeller Center and New York Public Library. The nearest airport is LaGuardia Airport, 12 km from 45 Times Square Hotel.", true, "45 Times Square Hotel", false, false, 3 },
                    { 10, "6 Simeonovsko Shausse Blvd., Lozenets, 1700", new DateTime(2024, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, "Hotel ZOO Sofia is located In Sofia and next to a large green park, perfect for relaxation. Sopharma Business Towers are a 7-minute drive away, Inter Expo Center is a 10-minute drive away and the Grand Sports Hall Arena Armeec is 0.9 mi away.\r\n\r\nEnjoy a drink in the stylish bar and sample an assortment of cuisine in the elegant Bijou restaurant. The tastefully decorated, fully-equipped accommodations provide you with the air of tranquility.\r\n\r\nMake use of the free gym and free WiFi throughout the hotel. A secure parking is available against a surcharge.\r\n\r\nSofia City Zoo is only 656 feet from Hotel ZOO Sofia. Paradise Center, a vast shopping and entertainment center, is 1.6 mi away. Interpred business area is a 12-minute drive away.\r\n\r\nSofia Airport is a 15 minute drive away. Pickup from the Airport or Central Train Station pickup can be organized against a surcharge.", true, "Hotel ZOO Sofia - Secured Paid Parking", true, false, 4 },
                    { 11, "6 Stara Planina Str., 1000", new DateTime(2024, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, "Conveniently located in the center of Sofia, Eurostars Sofia City provides air-conditioned rooms with free WiFi and private parking. This 4-star hotel offers a 24-hour front desk and a business center. The property is non-smoking throughout and is located a 4-minute walk from Cathedral Saint Alexandar Nevski.\r\n\r\nRooms are complete with a private bathroom equipped with free toiletries, while certain rooms at the hotel also offer a balcony.\r\n\r\nEurostars Sofia City offers a buffet or continental breakfast.\r\n\r\nPopular points of interest near the accommodation include Banya Bashi Mosque, Sofia University St. Kliment Ohridski and Council of Ministers Building. The nearest airport is Sofia, 3.1 miles from Eurostars Sofia City, and the property offers a paid airport shuttle service.", true, "Eurostars Sofia City", true, false, 4 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Hotel_Id", "IsActive", "IsReserved", "PricePerNight", "Type", "WiFi" },
                values: new object[,]
                {
                    { 1, 1, true, false, 165m, 1, true },
                    { 2, 1, true, false, 302m, 2, true },
                    { 3, 1, true, false, 578m, 3, true },
                    { 4, 1, true, false, 630m, 4, true },
                    { 5, 3, true, false, 630m, 1, true },
                    { 6, 3, true, false, 470m, 2, true },
                    { 7, 3, true, false, 216m, 1, true },
                    { 8, 3, true, false, 157m, 2, true },
                    { 9, 4, true, false, 433m, 1, true },
                    { 10, 4, true, false, 488m, 2, true },
                    { 11, 4, true, false, 644m, 3, true },
                    { 12, 5, true, false, 201m, 1, true },
                    { 13, 5, true, false, 201m, 2, true },
                    { 14, 6, true, false, 197m, 2, true },
                    { 15, 9, true, false, 193m, 2, true },
                    { 16, 9, true, false, 244m, 3, true },
                    { 17, 8, true, false, 195m, 2, true },
                    { 18, 8, true, false, 238m, 3, true },
                    { 19, 8, true, false, 248m, 4, true },
                    { 20, 7, true, false, 314m, 2, true },
                    { 21, 7, true, false, 351m, 4, true },
                    { 22, 10, true, false, 70m, 1, true },
                    { 23, 10, true, false, 78m, 2, true },
                    { 24, 10, true, false, 104m, 3, true },
                    { 25, 11, true, false, 71m, 1, true },
                    { 26, 11, true, false, 80m, 2, true },
                    { 27, 11, true, false, 161m, 3, true },
                    { 28, 11, true, false, 173m, 4, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
