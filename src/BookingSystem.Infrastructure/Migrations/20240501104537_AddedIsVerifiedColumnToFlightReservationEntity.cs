using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedIsVerifiedColumnToFlightReservationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "FlightsReservations",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "FlightReservation's Verify Status");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62d28ee6-5a44-4529-bb9d-91cb7ee61ce0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "765ae175-03c6-4a3f-9123-af834b3ec61a", "AQAAAAEAACcQAAAAEB7urHjnEJqQDxkpDuvhLjEQ6Fhhv4IZ54UcFHi6qzaOA+vtxuQ+vaCpyWNViFz/iQ==", "2b2487d4-0504-4530-9ca4-b4192b032880" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebf07620-6aa8-4fef-9170-461d816c12f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4d5d755-fa15-4e47-9cf4-b2c65b631c74", "AQAAAAEAACcQAAAAELWbVk9dd+WxFA3gZdnWch708jGtBSlMvFPps3yOZp+77qobdYvs3AFTltNVvyHnnw==", "a519cd57-cfe7-4f04-9525-0706f39cd998" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "FlightsReservations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62d28ee6-5a44-4529-bb9d-91cb7ee61ce0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5d39e6a-3c75-43c8-88a5-934d3cb9ea61", "AQAAAAEAACcQAAAAEFWEG9cJSlyYG5UcnRfysVj4/jnbdTfrcGLYFvEfp2k4iMHzycmymrz41HDlynw8bw==", "cc78449e-d76e-4387-8721-c4dc68591323" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebf07620-6aa8-4fef-9170-461d816c12f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58ecee87-ad0f-4b42-a61f-31a2963f6b3f", "AQAAAAEAACcQAAAAEMf0CIQb4qEukj8xwdB413rauD6SyMEi1fRl03Zpn0dVeQQvsCB514Dht28nvNHNRQ==", "36edbcc3-fb4a-45c2-a198-b8919185e60b" });
        }
    }
}
