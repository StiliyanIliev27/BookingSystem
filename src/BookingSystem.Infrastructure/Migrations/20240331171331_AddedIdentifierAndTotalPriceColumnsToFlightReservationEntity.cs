using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedIdentifierAndTotalPriceColumnsToFlightReservationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightsReservations",
                table: "FlightsReservations");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "FlightsReservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Flight Reservation Identifier");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "FlightsReservations",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                comment: "Flight's Reseravation's Total Price");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightsReservations",
                table: "FlightsReservations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab39f134-364f-44a4-aa3b-7d648f9567ee", "AQAAAAEAACcQAAAAEFwkhlMyRUswmQDfTfyyeXGyKvSW5BhkQ/5jWJfTyT7iqmQUQyqxkbmzxxl61WdR4Q==", "215e2e28-5e92-4cd5-b52b-03bb2ca892e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95bc4796-60a3-4154-b257-719ea9f03789", "AQAAAAEAACcQAAAAEHZxjeE96Dm6cv7WYzJ8xjKIWjFABvf3ej2qpV4r2CN2IxYJ5mih7bnZynEXgokJ4w==", "62c2d4bd-bebd-4605-878a-1491193ed0b5" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_FlightsReservations_Flight_Id",
                table: "FlightsReservations",
                column: "Flight_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightsReservations",
                table: "FlightsReservations");

            migrationBuilder.DropIndex(
                name: "IX_FlightsReservations_Flight_Id",
                table: "FlightsReservations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FlightsReservations");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "FlightsReservations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightsReservations",
                table: "FlightsReservations",
                columns: new[] { "Flight_Id", "User_Id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87679802-676a-4a84-bc72-ba4da38a5c9a", "AQAAAAEAACcQAAAAELCxYoI8QZ23umkA6VBCmuHj0s0W7cScnboo7mThnNFVN2F4EUpoF6HB8iXCgIsKkA==", "44c62fa4-93a5-4c64-8e10-bdc3e8bcfdc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "577fc227-59d6-404a-9815-b67a430def1f", "AQAAAAEAACcQAAAAEFBlKCO6iysA+OOtePt35BHk01qC/FL561pRFwPTdDrFAKlTU3TSWl++cDWnxpkNvw==", "027b1d30-2951-45f8-a3ab-71d346237e1d" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 28, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
