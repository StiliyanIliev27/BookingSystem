using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedFirstAndLastNameToLandmarksReservationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "LandmarksReservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Landmark Reservation's Reserver's First name");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "LandmarksReservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Landmark Reservation's Reserver's Last name");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "HotelsReservations",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Hotel Reservation's Reserver's Last Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Hotel's Reserver's Last Name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "HotelsReservations",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Hotel Reservation's Reserver's First Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Hotel's Reserver's First Name");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "LandmarksReservations");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "LandmarksReservations");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "HotelsReservations",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Hotel's Reserver's Last Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Hotel Reservation's Reserver's Last Name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "HotelsReservations",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Hotel's Reserver's First Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Hotel Reservation's Reserver's First Name");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "675ed835-5c1f-4fdb-848b-9cc400316eb6", "AQAAAAEAACcQAAAAEAcgIyDoO24cp2wjPKzrTnAfkWLJnF0p/Q6acsSy9tb6/s8X/aW721bTEiRoeX7Ueg==", "6b41f7f4-5e93-48c8-ab79-613f8d1f1777" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b2f4064-3029-46d6-a967-59fc204dcf93", "AQAAAAEAACcQAAAAEPXPREBO4pO7wdIThwKvgfHC49L0NgwTJlrArooTg5GLtWnZsYLkwM0gdpvGD/Qa4A==", "485a48ff-36dd-4d72-9612-8415f297f57b" });
        }
    }
}
