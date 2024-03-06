
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedFlights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85e732aa-c9e4-40d8-aebe-cc416d3c175b", "AQAAAAEAACcQAAAAEKSOBTn8pkD5Abg4FUP1P3JwXcrkpyj/oe9xZBVuLYBejcM8UzN8sIFARmbRIi5gOw==", "b4879022-435a-473e-81e2-4819143fcf33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "735ca431-acaa-47db-985f-2790bf689987", "AQAAAAEAACcQAAAAEFG6HQbI84dRKmxdl/35hG7SaAxrsmjl8YGxQxZ8/0Sq6D40fo0G/HxsE37A3xtH2w==", "0aa589ca-36f9-4a22-8f21-79d68df72d3a" });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Airline_Id", "ArrivalAirport_Id", "ArrivalTime", "CabinClass", "CreatedOn", "DepartureAirport_Id", "DepartureTime", "FlightDuration", "IsActive", "TicketPrice" },
                values: new object[,]
                {
                    { 1, 4, 1, new DateTime(2024, 3, 6, 20, 25, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 3, 6, 18, 15, 0, 0, DateTimeKind.Unspecified), 190, true, 75m },
                    { 2, 3, 4, new DateTime(2024, 3, 6, 18, 25, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 3, 6, 15, 55, 0, 0, DateTimeKind.Unspecified), 90, true, 131m },
                    { 3, 4, 2, new DateTime(2024, 3, 6, 9, 35, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 3, 6, 6, 40, 0, 0, DateTimeKind.Unspecified), 235, true, 91m },
                    { 4, 2, 5, new DateTime(2024, 3, 6, 11, 5, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 3, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), 110, true, 99m },
                    { 5, 4, 6, new DateTime(2024, 3, 6, 0, 50, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 3, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), 170, true, 75m },
                    { 6, 3, 6, new DateTime(2024, 3, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 3, 6, 8, 45, 0, 0, DateTimeKind.Unspecified), 75, true, 131m },
                    { 7, 4, 6, new DateTime(2024, 3, 6, 18, 10, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 6, 13, 45, 0, 0, DateTimeKind.Unspecified), 205, true, 91m },
                    { 8, 2, 6, new DateTime(2024, 3, 6, 17, 40, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 3, 6, 14, 45, 0, 0, DateTimeKind.Unspecified), 120, true, 99m },
                    { 9, 3, 4, new DateTime(2024, 3, 6, 16, 55, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 3, 6, 11, 20, 0, 0, DateTimeKind.Unspecified), 210, true, 116m },
                    { 10, 3, 1, new DateTime(2024, 3, 6, 17, 20, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 3, 6, 15, 35, 0, 0, DateTimeKind.Unspecified), 225, true, 116m },
                    { 11, 5, 2, new DateTime(2024, 3, 6, 11, 15, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 3, 6, 9, 5, 0, 0, DateTimeKind.Unspecified), 130, true, 65m },
                    { 12, 5, 1, new DateTime(2024, 3, 6, 17, 5, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 6, 14, 55, 0, 0, DateTimeKind.Unspecified), 130, true, 65m },
                    { 13, 5, 5, new DateTime(2024, 3, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 3, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), 120, true, 45m },
                    { 14, 5, 1, new DateTime(2024, 3, 6, 8, 45, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 3, 6, 6, 30, 0, 0, DateTimeKind.Unspecified), 135, true, 45m },
                    { 15, 3, 2, new DateTime(2024, 3, 6, 10, 20, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 3, 6, 7, 55, 0, 0, DateTimeKind.Unspecified), 265, true, 250m },
                    { 16, 3, 4, new DateTime(2024, 3, 6, 21, 10, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 6, 14, 55, 0, 0, DateTimeKind.Unspecified), 255, true, 250m },
                    { 17, 3, 5, new DateTime(2024, 3, 6, 9, 55, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 3, 6, 9, 15, 0, 0, DateTimeKind.Unspecified), 140, true, 150m },
                    { 18, 3, 4, new DateTime(2024, 3, 6, 0, 30, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 3, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), 130, true, 150m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5655339-8e0c-43d1-a3f8-770ba459996b", "AQAAAAEAACcQAAAAEAPDNInraOKCMlY8kQLKHVJ73IXYmROLNBt+92fb0PioV9dq0dzOjcHrYYcnJe3ZQw==", "b742af15-533e-455b-a35f-2bee04af5df7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0b7266d-d98d-41ed-b10f-802449291cda", "AQAAAAEAACcQAAAAEB1OCsgCKB1koyelSsHYygIj9ULVHsMgZn/ywT4snHezmj4N4bA1zkiUHNsLVVl8VA==", "3c770f69-dd3d-4727-933f-4ce4bd156768" });
        }
    }
}
