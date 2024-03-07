using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedPremierHotelRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b51362bd-12ad-4a4a-912d-d5dbac7f71b5", "AQAAAAEAACcQAAAAEOpEO4cRZ5g0NPdfcYeEl+6/PjfkAECc+cHERgp/9U98GCIQ5tS90TwtxIR+KW7eKw==", "268b44f4-6b5b-4b36-a52e-59f3062f3960" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36dcd6b3-dff2-433f-b72e-9e2191b0c5a3", "AQAAAAEAACcQAAAAEHYg4SJzqty2pwk/EeRv0yj8HdmKkONhp4Bcc7kNPi49FMZbTkeP1IJ//85OcFvlJQ==", "f61204d6-4519-407f-a1dc-72dd44c0c348" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Hotel_Id", "IsActive", "IsReserved", "PricePerNight", "Type", "WiFi" },
                values: new object[,]
                {
                    { 29, 12, true, false, 112m, 1, true },
                    { 30, 12, true, false, 125m, 2, true },
                    { 31, 12, true, false, 190m, 3, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b416c00-8071-414b-b4fa-f4f8ccc7b0a4", "AQAAAAEAACcQAAAAEPkItLHLTi8I3985zp4pTprqbLHq8TOXPmWcBDjvVis2F6Uz5iT4YLtW0Xv44GLu2A==", "98dbdc77-f1bc-4a2c-bfa7-5f7f0eb0dfb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5b5d0a9-117b-4b41-b461-73579f532034", "AQAAAAEAACcQAAAAEHKx+Np5LJMxWZmGs9xT8jsV1xsFP8IvUDbFXk0rx/svdMAkpY3+sX9cOWZmVuRIQA==", "84e4d8d6-2388-4fb5-9e05-e9aeb174c11b" });
        }
    }
}
