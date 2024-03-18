using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedThreeHotelWithTheirRoomsInRome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57c407e4-01ac-4432-b64a-c27fb012f07e", "AQAAAAEAACcQAAAAEDgDmavaL9L1mahdNX27m0FQ4IlFTLLnXrTKzlXyCDfbneHQMpcUIX4QRAF9kAakDg==", "6a357852-9b40-493e-96ae-7ff5d1f5b663" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "382ab236-a898-4bbe-bb39-00c594ea6588", "AQAAAAEAACcQAAAAEG1SYVsbkd/HEfmlTEa0q2WFLtVlPzO+In0zmJf0a5FhKme7TIdFaBmUcy2kEukSuQ==", "03ac544b-7b30-42ba-89e1-a6c69ef0ddab" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckIn", "CheckOut", "City_Id", "Details", "ImageUrl", "IsActive", "Name", "Parking", "Pets", "StarRate" },
                values: new object[,]
                {
                    { 19, "Viale Pinturicchio 19, Villa Borghese Parioli, 00196", new DateTime(2024, 3, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Featuring air conditioning, Flaminio Holidays offers en suite rooms and an apartment in Rome. Ponte Milvio is 300 metres from the property. Free WiFi is provided throughout the property.There is a tram stop linking to Piazza del Popolo right in front of the property. Foro Italico - Rome is 700 metres from Flaminio Holidays.", "https://cf.bstatic.com/xdata/images/hotel/max1280x900/466841541.jpg?k=cb07cb3e10ddcbc2b29fdf20f30cb7f3e756e9cffa6bd9e5c8854a57e6c8984d&o=&hp=1", true, "Flaminio Holidays", false, false, 3 },
                    { 20, "243 Via Nazionale, Central Station, 00184", new DateTime(2024, 3, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 6, 0, 0, 0, DateTimeKind.Unspecified), 5, "Ideally situated in the Central Station district of Rome, Alius and Freerome Hotel is situated 800 metres from Santa Maria Maggiore, 1 km from Cavour Metro Station and 700 metres from Quirinal Hill. With free WiFi, this 2-star hotel offers a tour desk. The property is 1.1 km from the city centre and 200 metres from Repubblica - Teatro dell'Opera Metro Station.", "https://cf.bstatic.com/xdata/images/hotel/max1280x900/355779789.jpg?k=e854ebae86fae75b72fff8469f9783cac0428f94ff76313dffe0dc6018cc64b1&o=&hp=1", true, "Alius and Freerome Hotel", true, false, 2 },
                    { 21, "102 Via Principe Amedeo, Central Station, 00185", new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 5, "Right in the heart of Rome, situated within a short distance of Vittorio Emanuele Metro Station and Santa Maria Maggiore, AD MAIORA SUITE offers free WiFi, air conditioning and household amenities such as a fridge and coffee machine. This recently renovated apartment is located 1.1 km from Cavour Metro Station and 500 metres from Rome Termini Metro Station. The property is non-smoking and is located 400 metres from Rome Termini Train Station.", "https://cf.bstatic.com/xdata/images/hotel/max1280x900/472491611.jpg?k=d6136cf78533b12276bd7ff21f0a59f5a0d83dcda6b0d2e6d163986f39104f19&o=&hp=1", true, "Ad maiora suite", false, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Count", "Hotel_Id", "IsActive", "PricePerNight", "Type", "WiFi" },
                values: new object[,]
                {
                    { 50, 5, 19, true, 282m, 1, true },
                    { 51, 5, 19, true, 319m, 2, true },
                    { 52, 5, 19, true, 356m, 3, true },
                    { 53, 5, 19, true, 388m, 4, true },
                    { 54, 5, 20, true, 349m, 2, true },
                    { 55, 5, 20, true, 426m, 3, true },
                    { 56, 5, 20, true, 428m, 4, true },
                    { 57, 5, 21, true, 251m, 2, true },
                    { 58, 5, 21, true, 275m, 3, true },
                    { 59, 5, 21, true, 300m, 4, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0607b919-ef21-457a-8d47-89107f199975", "AQAAAAEAACcQAAAAEB7MCGmBh4H4JH5+y4iNRmupAYIcUrGZFfj/Ou/iSLq5sz+ZYhlg4pHrPu7gLGxrlQ==", "94a6b8bb-a434-4d71-ae32-a680ee282162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d8c695-9f31-4900-969c-9386e2f4140b", "AQAAAAEAACcQAAAAED0mLOh7x9PmECZpIB1b1NK0yTwHEsu0QA9/lK+sNbyBKaP9eC+em9BONjCBCs3dTA==", "5897a60e-c08c-42e6-bd57-8028e2649402" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
