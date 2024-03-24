using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class RemovedCreatedOnFromFlightEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Flights");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be2fafa-fd4c-4474-851e-21c3f481ef30", "AQAAAAEAACcQAAAAEHG7ek3M4+Flid2IhBrZebCrauwMFfwUrlgwH7nOWRWzcgpVRS9zFoEp6CGR/FtYug==", "cf5187fa-09e7-4ccf-834a-f24620496988" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a80ccb9-643e-421f-b78d-2448facc4fdd", "AQAAAAEAACcQAAAAEMb9ZgQHu4tdOxZQwUU56ppw4Gdy/GVUfZcPraCu88TUwP2MWx/vxHJjKRLuey/dyg==", "23afb0b8-255f-4a8f-a9f6-9eb9a3dae453" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Flights",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Flight's Reservation Created Time");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f347265-afcd-4b03-8ea7-f51e36a2ada3", "AQAAAAEAACcQAAAAEOFKXQcQlDCgplWLdyDidgeRxG/mImxELLtq4KZPUmn0yMVV2Jp1vmKi0HulRVSMyg==", "f0bd9501-cbb4-4d32-bbab-2bed97e443a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84ffdd69-3e0b-4587-9156-eb5736bb0f55", "AQAAAAEAACcQAAAAEDq3F80S0BYsSXywsNiZDXaYIRVavTC+6baAkUX0YwptFNFFxg9SJZ+R1o89WpMEog==", "141caeb8-cb1c-4003-8c56-bdbff454c68f" });
        }
    }
}
