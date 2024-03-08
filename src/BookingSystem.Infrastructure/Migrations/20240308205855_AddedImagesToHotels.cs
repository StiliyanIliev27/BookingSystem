using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedImagesToHotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Hotel's Image Url");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d36afdb4-226b-4c2d-b9bc-e37450c4a6c0", "AQAAAAEAACcQAAAAEDQ7nClF4kSDI6Xd6UvAYTFfBFjST7gNXSiCa0XxWc6fycmd/ZFJJy/8Zq2LP9ZW/w==", "48d9be10-9c0c-4be0-99a7-0b2535f94a67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c693aaf0-d4a8-4597-a63f-3f17eaf9e020", "AQAAAAEAACcQAAAAEMlB04GuVUPVIJ4GPS3FQrtfjiNyMcBuYGglfgHWGvWPmXPebThN0T4roCeNPzGWTw==", "2fc32760-2f1f-4ff6-82b4-cd8b2ffb1fee" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/499913403.jpg?k=d3a1f17f9ee7ce9f7340141392196e7ef4f27861d44d818d32e9da03e06ad674&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/50496815.jpg?k=8e4c7075f4c48de078c1d584716f38ccfcf56f51ee455b01fb0abcefddc2c9bd&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/501485308.jpg?k=4db18f42e477c422e0c412d87df0aed2bf16a463342daad5d672731287488c54&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/255649687.jpg?k=84b89c322748a0e6479cd2d71263e56f2eb9771d4010cc30d3018488d7ccc671&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/159811810.jpg?k=f40061a37ae157fd42e62ece3bd402bca73e10528b6160719bb103c4ab69be25&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/33799890.jpg?k=1d94fedc1ccb9dd41e53fcefc908ecc8f09cba9919315b4d9a7bf6d3afa951be&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/505296139.jpg?k=7e84172ea344cde933840092c3a9f3c4099e70903084b0d91ce3db747901c49d&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/485847819.jpg?k=c8a7d6fe3756b65ddf1e88e4ece012a9e377f4da075e7f6c65d0064bee9dab61&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/442811339.jpg?k=e89ae66126c9c1239ea05e7a9b5f0423ed15739432d7649eb6e6b06109aba180&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/294238843.jpg?k=11770c2bb4bcf168f0b6d6bc6435bcd507a1447750d6418205993540c608e268&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/281027010.jpg?k=ada420d7944091b2d98b431b4239a0ca5f07da5239023b81ad27f17d5ca52a35&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/77419722.jpg?k=c00e5324b8b60246cc03dc25568672a7f3a4729c3b10598f5170bc09965838d3&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/306033163.jpg?k=b0e00a1da26349cd39fa387e6b76a82b94bef8b51630828e2afb6a98ec46164c&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/501751933.jpg?k=99a158e38f1640dcaa9a56b0906ecafa05e8fe6c524667bbe1600a7200afa521&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309103534.jpg?k=d788f9ac2c270a0f155a7214d9e94089d86288f6acb8aefd8e95010903e5b580&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/326305836.jpg?k=a4fddd97529943d3c8342a0cfe1110d14aeb57033494152dd86ce113f80afee9&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/124760078.jpg?k=5b64947a1714bd3adbdebd6bff329c9a7debd693c4f02bb201390dc3988d4b63&o=&hp=1" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut", "ImageUrl" },
                values: new object[] { new DateTime(2024, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/253998054.jpg?k=3b996abd68f812376d2bea8e57bb8f5918e25228677a88d17db49e444c521d91&o=&hp=1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Hotels");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e278603-04c8-461c-8eff-63bc116a8fe2", "AQAAAAEAACcQAAAAEPMrNj2Nu7rWheWGUoG5H/ay5et5lFe+mskE4d2jrFfkW38Ornmb0T66J2S1GJo2vw==", "f7264997-89be-4e80-b3fe-82faaca804e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c071d2-c3d3-4e2e-a4f5-5a26e0b25340", "AQAAAAEAACcQAAAAELSmPBJx6sx4EHdx1+09VCoqi/SsSVvtR/keO9FvG1MJ8oMgJfSDpRIVeHTeQ7I/Fg==", "a059a477-d34f-441d-bfbc-d2d5422d04e3" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
