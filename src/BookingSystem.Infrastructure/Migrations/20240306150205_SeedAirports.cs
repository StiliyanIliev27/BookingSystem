using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedAirports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "City_Id", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Paris Charles de Gaulle Airport" },
                    { 3, 3, "John F. Kennedy International Airport" },
                    { 4, 4, "Istanbul International Airport" },
                    { 5, 5, "Leonardo da Vinci–Fiumicino Airport" },
                    { 6, 6, "Sofia International Airport" },
                    { 7, 7, "Haneda Airport" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
