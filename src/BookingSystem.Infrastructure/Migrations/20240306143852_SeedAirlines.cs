using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedAirlines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "ImageUrl", "Name", "WebSiteUrl" },
                values: new object[,]
                {
                    { 1, "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Lufthansa_Logo_%28Crane%29.svg/2052px-Lufthansa_Logo_%28Crane%29.svg.png", "Lufthansa", "https://www.lufthansa.com/" },
                    { 2, "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Bulgaria_Air_logo.svg/1280px-Bulgaria_Air_logo.svg.png", "Bulgaria Air", "https://www.air.bg/bg" },
                    { 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Turkish_Airlines_logo_2019_compact.svg/2560px-Turkish_Airlines_logo_2019_compact.svg.png", "Turkish Airlines", "https://www.turkishairlines.com/" },
                    { 4, "https://1000logos.net/wp-content/uploads/2020/04/Wizz-Air-logo.jpg", "Wizz Air", "https://wizzair.com/" },
                    { 5, "https://logos-world.net/wp-content/uploads/2020/03/Ryanair-Logo-2013-present.jpg", "Ryanair", "https://www.ryanair.com/" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7029c18d-a014-4aa6-81b3-ca9afb2a4c47", "AQAAAAEAACcQAAAAEIDX7Cs1aP5Hhkuk7QUArjlx525ZVWSRXhj/swSXrlt328Wqy4W37rc2nGafkK7BJg==", "bb29d56c-8988-4e7d-ae85-b51fb0f727b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f94526f-3e97-4ad7-b8e0-79a7d8e47b3b", "AQAAAAEAACcQAAAAEHtdhwR9yC99vjFQLvDKtvP22WmJtCYGyh0yHtJm68s3r7FnMwdU+FIz9uyllutQMw==", "2817df68-5e74-469f-b336-28f7dd6456e2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9e66994-98f0-47f1-8b6f-3eaf04aa710f", "AQAAAAEAACcQAAAAEE37zw61jyCPjrYrW2Uo2gg8zBRChSPg73/QTLntTIs/tEvMNaf97ncUuMD9+7cR6w==", "da7219d0-35d5-4263-812c-8afc4af92b00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27a252de-f3c6-4bb3-a110-c855e74e7037", "AQAAAAEAACcQAAAAEIFely+a6UTI4GtV6MyzJoq4PJ6FTSxEeW8s5seUdmjfYbQ9flPJtu1zHh0JKwBe/w==", "513d21e8-45b7-47eb-a3e9-1eb6408da039" });
        }
    }
}
