using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeededMoreHotelsAndTheirRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61717fa4-8a7b-4774-889d-2685812dbe13", "AQAAAAEAACcQAAAAEDHY248VTq7tvPoUflLoDoP09XiC8ceVCuHApjaswt4xZ2WbxSNtS1NtpvaSWGiHCw==", "462aba7b-dff9-45fd-957b-db77b6ba2f3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdb74127-2c4f-400d-a582-442f9c2b0bdf", "AQAAAAEAACcQAAAAECwYmj1YYlvKrhfUtpIE848J8EzVeO0o/jWo6JCNayAo3nt7e/URb2wa91tMkjgWwQ==", "ecfae1fc-518f-49d1-969b-84765d5095ce" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckIn", "CheckOut", "City_Id", "Details", "IsActive", "Name", "Parking", "Pets", "StarRate" },
                values: new object[,]
                {
                    { 13, "Güvenlik Caddesi, Fatih, 34130", new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, "Located in Istanbul, Emin Palace offers 3-star accommodations with a terrace and a restaurant. The property is around 1.1 miles from Suleymaniye Mosque, 1.5 miles from Blue Mosque and 1.7 miles from Basilica Cistern. The property has a 24-hour front desk, airport transportation, room service and free WiFi throughout the property.", true, "Emin Palace", false, false, 3 },
                    { 14, "Güvenlik Caddesi, Fatih, 34130", new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, "Featuring a welcoming terrace, Hotel Zurich Istanbul Old City is close to Istanbul’s vibrant shopping district and 15 minutes’ walk from Grand Bazaar. It also offers a health center. Hagia Sophia, Blue Mosque and other major attractions are in 30 minutes' walk distance.", true, "Hotel Zurich Istanbul Old Citye", false, false, 4 },
                    { 15, "Alemdar, Marmara Region, Prof. Kazım İsmail Gürkan Cd. NO: 3, 34110", new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, "Popular points of interest near Florina Hotel include Basilica Cistern, Column of Constantine and Blue Mosque. The nearest airport is Istanbul, 28 miles from the hotel, and the property offers a paid airport shuttle service.", true, "Florina Hotel", false, false, 4 },
                    { 16, "140-0002 Tokyo-to, 4-12-8, higashishinagawa", new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 7, "In a prime location in the Shinagawa Ward district of Tokyo, Loisir Hotel Shinagawa Seaside is located a few steps from Shinagawa Seaside Forest Oval Garden, a 9-minute walk from Sinagawa Sentaikoujin Temple and half a mile from Seiun Inari Shrine. This 4-star hotel offers a 24-hour front desk. Free WiFi is available and private parking can be arranged at an extra charge.", true, "Loisir Hotel Shinagawa Seaside", true, false, 4 },
                    { 17, "108-0023 Tokyo-to, Minato-ku Shibaura 3-14-21", new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 7, "A 5-minute walk from JR Tamachi Train Station and Mita Subway Station, Sotetsu Fresa Inn Tokyo Tamachi offers simple modern accommodations with free wired internet access. Guests can request relaxing massages for an extra cost and store luggage for free at the 24-hour front desk. Tokyo Tamachi Sotetsu Fresa Inn is a 20-minute walk from Shiba Park and a 10-minute train ride from JR Shinagawa Train Station. The Imperial Palace is a 15-minute drive away.", true, "Sotetsu Fresa Inn Tokyo Tamachi", false, false, 3 },
                    { 18, "100-0005 Tokyo-to, Chiyoda-ku, Marunouchi 1-8-2", new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 7, "Oakwood Premier Tokyo is a luxury serviced apartment with hotel-like services, located at just a 2-minute walk from JR Tokyo Station’s Yaesu North Exit. Located on the 6-19th floors of a 19-story building, this property is designed to offer a getaway in the center of Tokyo. There is a 24-hour front desk on site.", true, "Oakwood Premier Tokyo", true, false, 5 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Count", "Hotel_Id", "IsActive", "IsReserved", "PricePerNight", "Type", "WiFi" },
                values: new object[,]
                {
                    { 32, 5, 13, true, false, 95m, 1, true },
                    { 33, 5, 13, true, false, 108m, 2, true },
                    { 34, 5, 13, true, false, 209m, 3, true },
                    { 35, 5, 14, true, false, 260m, 1, true },
                    { 36, 5, 14, true, false, 207m, 2, true },
                    { 37, 5, 14, true, false, 327m, 3, true },
                    { 38, 5, 14, true, false, 350m, 4, true },
                    { 39, 5, 15, true, false, 133m, 1, true },
                    { 40, 5, 15, true, false, 155m, 2, true },
                    { 41, 5, 15, true, false, 200m, 3, true },
                    { 42, 5, 15, true, false, 329m, 4, true },
                    { 43, 5, 16, true, false, 135m, 1, true },
                    { 44, 5, 16, true, false, 198m, 2, true },
                    { 47, 5, 18, true, false, 378m, 1, true },
                    { 48, 5, 18, true, false, 460m, 2, true },
                    { 49, 5, 18, true, false, 853m, 2, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "616db90a-c62d-4b68-9bf7-0cd710567478", "AQAAAAEAACcQAAAAEC+0QdRkL6xSwBZly8pQBt/GsFpSqketK42dWQqGNuqI/dpCMdgorJys0u/Gj8WJKQ==", "e2c37079-6b60-4594-babe-18fdbd26c917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43915757-9ea1-4403-8ca5-b45002138648", "AQAAAAEAACcQAAAAEHrs9zycG3iICr1nkXdWKjPBm6tEk7BQjTkKlz6e7nl1E3nvQ//Ds/pQD6KmIZQ8/w==", "ab38eb46-42e3-4202-bb13-31b62b71a56d" });
        }
    }
}
