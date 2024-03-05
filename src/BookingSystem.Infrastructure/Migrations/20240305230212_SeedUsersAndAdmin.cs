using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedUsersAndAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8d1f0bdc-f9e5-4856-a127-fb84281d56ad", 0, "b9e66994-98f0-47f1-8b6f-3eaf04aa710f", "guest@gmail.com", false, false, null, "guest@gmail.com", "guest", "AQAAAAEAACcQAAAAEE37zw61jyCPjrYrW2Uo2gg8zBRChSPg73/QTLntTIs/tEvMNaf97ncUuMD9+7cR6w==", null, false, "da7219d0-35d5-4263-812c-8afc4af92b00", false, "Guest" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c9019544-ec91-4248-bfc4-9d8a4f13430b", 0, "27a252de-f3c6-4bb3-a110-c855e74e7037", "admin@gmail.com", false, false, null, "admin@gmail.com", "administrator", "AQAAAAEAACcQAAAAEIFely+a6UTI4GtV6MyzJoq4PJ6FTSxEeW8s5seUdmjfYbQ9flPJtu1zHh0JKwBe/w==", null, false, "513d21e8-45b7-47eb-a3e9-1eb6408da039", false, "Administrator" });

            migrationBuilder.InsertData(
                table: "Administrators",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, "c9019544-ec91-4248-bfc4-9d8a4f13430b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Administrators",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b");
        }
    }
}
