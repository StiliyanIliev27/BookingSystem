using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class UpdatedPricesForRomeHotelsRomms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2ce22ab-a9b4-4871-b888-33f4d10ac362", "AQAAAAEAACcQAAAAENy5iHPxwDMArFwBQa66W6mjtDxdnwPgvGEHpe7A4p5yGIf1+eFjFnt7aTxgugIcpw==", "e9d79a38-4be4-4653-bf17-7da3aec90259" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00610829-ee51-4079-bd7a-0e633dccb39f", "AQAAAAEAACcQAAAAENFUFu6oy795n6VHeOAtmxuYZPsxy2bmJZrr2rpygH5lXAyqO/5yHu+lZmyRe+cV1w==", "182ded85-2f29-4d8c-bd7c-008f94d614c7" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "PricePerNight",
                value: 123m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "PricePerNight",
                value: 163m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "PricePerNight",
                value: 182m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "PricePerNight",
                value: 198m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "PricePerNight",
                value: 178m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "PricePerNight",
                value: 217m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "PricePerNight",
                value: 218m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "PricePerNight",
                value: 128m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "PricePerNight",
                value: 140m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "PricePerNight",
                value: 153m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57c407e4-01ac-4432-b64a-c27fb012f07e", "AQAAAAEAACcQAAAAEDgDmavaL9L1mahdNX27m0FQ4IlFTLLnXrTKzlXyCDfbneHQMpcUIX4QRAF9kAakDg==", "6a357852-9b40-493e-96ae-7ff5d1f5b663" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "382ab236-a898-4bbe-bb39-00c594ea6588", "AQAAAAEAACcQAAAAEG1SYVsbkd/HEfmlTEa0q2WFLtVlPzO+In0zmJf0a5FhKme7TIdFaBmUcy2kEukSuQ==", "03ac544b-7b30-42ba-89e1-a6c69ef0ddab" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "PricePerNight",
                value: 282m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "PricePerNight",
                value: 319m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "PricePerNight",
                value: 356m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "PricePerNight",
                value: 388m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "PricePerNight",
                value: 349m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "PricePerNight",
                value: 426m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "PricePerNight",
                value: 428m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "PricePerNight",
                value: 251m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "PricePerNight",
                value: 275m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "PricePerNight",
                value: 300m);
        }
    }
}
