using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedTotalChangedNameCounterColumnToFlightReservationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalChangedNameCount",
                table: "FlightsReservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Flight's Reservation's First and Last Name Changed Counter");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e23c4f12-109c-4679-b2a2-f98c715f63e1", "AQAAAAEAACcQAAAAEErobdKmblmzmkmwPv8yMqifRLBmbYCMlgohVeY6uWsChRJq1utzYZof2G4I85Hcpg==", "fd68fea8-a92a-4da8-a12d-56e7ab84ef51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "909f0cbe-9a83-4904-8685-80452f6ec54e", "AQAAAAEAACcQAAAAEPa4w1M5BV1CpLf/VF8CGlI4KcnyR2N17dMA0qCvMauI/X03VjBxWXn88/nQJnLM/Q==", "e32f77aa-d2fc-4f6a-b1fd-98f75575b1ff" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 1, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalChangedNameCount",
                table: "FlightsReservations");

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
        }
    }
}
