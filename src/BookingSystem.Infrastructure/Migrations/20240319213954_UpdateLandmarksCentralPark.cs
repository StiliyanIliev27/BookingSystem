using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class UpdateLandmarksCentralPark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a386c3a2-0ba1-4435-ba58-4a6e0f9fc003", "AQAAAAEAACcQAAAAENLA9QpbhHockd5gD3Fqv48Whsytg1Xx0qoBXAD/55KNGRty2mfPke8y78+n7XKtzQ==", "f683765e-33a4-4bb0-afb9-adef07bfda94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6575fc8a-7114-4eaa-8622-65f13ab0e169", "AQAAAAEAACcQAAAAED+gmt1tQBG4NLOTPptNp9AKr21NvQsXdZ3U+HbW3YBr4lEAThe+2bbNf1HEU/sUaQ==", "a3a3a74f-1cba-45f9-93ff-39b8adda0812" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 5,
                column: "City_Id",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a0c8e09-64fe-4086-b5b7-ada9d737efeb", "AQAAAAEAACcQAAAAEIRdUVF2yfas8RIia9aKmngIloF/RGtiHUk9ZG/2/aeCY6MUw6l0s8B5FVvra9Lwyg==", "41425048-80a1-46d6-8aa8-5d6774b489ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c003855-6a06-458c-982d-bafae074ef80", "AQAAAAEAACcQAAAAEIPnuHFJsf9OfOf7B3aWrELC1LxkBA1iY8c9HpcuqgWZats2RVSgNrMVdAp21HOOYA==", "57f66b43-1fbb-49c6-9df2-f1d7dbbbd74d" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 5,
                column: "City_Id",
                value: 4);
        }
    }
}
