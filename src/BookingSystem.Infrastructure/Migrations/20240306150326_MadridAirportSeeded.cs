using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class MadridAirportSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "City_Id", "Name" },
                values: new object[] { 2, 2, "Madrid–Barajas Airport" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a9c0f00-bd65-4b6c-b8f2-1f72b327d10b", "AQAAAAEAACcQAAAAENiErA9BfS3ozCKLiIGtGMCkWVfx8/8hMEg3YpgC+tO3FNKW3YmpfNY7HRbdMlKjzA==", "eec2d664-6239-4759-87b5-195b55da672e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6379a8bc-0687-43b0-a734-527ff937a759", "AQAAAAEAACcQAAAAEPlqOXs/rx9w82aFGuh1Jp16kN7HoGGVisxnPuuhyZy61qTaeO1uk2AyqiysIwIaeg==", "5903ceff-9361-46a8-9ebc-92a9012211f7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca624f94-5426-475c-8ec7-eebe8b0a6de2", "AQAAAAEAACcQAAAAECrqqvGJscL9m04TQkOzNs723ws0d5VsEICP2t4iVZGE0LfWvIhh7C3vRxDTrmcfPQ==", "46e756e9-63f0-4b5d-b65f-06ed863c571e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31d00b9b-f374-4e31-abbb-5d0e00b06b2e", "AQAAAAEAACcQAAAAEAVd2IzQfnAr4avzfDQvjlH6j3i4SNtn7K6vrL/3WkBMLrFquvczeE4g2HCNseo0nw==", "ce836b4f-71fb-4a4f-b0cd-d5281fad4362" });
        }
    }
}
