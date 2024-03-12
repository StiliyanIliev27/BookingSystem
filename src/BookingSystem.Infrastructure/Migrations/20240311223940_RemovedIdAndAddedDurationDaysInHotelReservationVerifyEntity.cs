using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class RemovedIdAndAddedDurationDaysInHotelReservationVerifyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "HotelsReservationsVerifies");

            migrationBuilder.AddColumn<int>(
                name: "DurationDays",
                table: "HotelsReservationsVerifies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Reservation duration days");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d990a81-2b9d-4254-bb1e-a8e86c9c97fc", "AQAAAAEAACcQAAAAEGJLr/3F1MPWtLdIN9uueyiC9ciOimfqPdyDzrwd5sTK3cjm784oepc54+aczxdfZQ==", "82256b8e-ea0d-43f6-b822-6192da02aaec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c8bf81e-5efa-4c66-8f30-c989301e18d1", "AQAAAAEAACcQAAAAEF5kmW/b67L7kRhp8VlvAUtrx+1ruGWh65yFmymdNaiL65u/5IjDK40yOxHgAsPddA==", "22b31655-feb9-4902-8d22-279712e2f2ab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationDays",
                table: "HotelsReservationsVerifies");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "HotelsReservationsVerifies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Hotel Reservation Verify Identifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de1f149-53da-4525-8938-b0286d55e71f", "AQAAAAEAACcQAAAAEG67YGE8ptu3Iy6wbs4i5DTiLqlvLHfAlDLr6bO4F6kSxs+8+6HhY2yfCb756GtDzA==", "b13d4e36-c276-415d-b62b-aa4259765a6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "436480e4-9bf8-4599-9fd9-5d9874269f3a", "AQAAAAEAACcQAAAAECkBfOYisLPiQLcVAVCyHV5XLKs/qum+MePXhK4Rlvmu2hfCJDAl3vZZHbiiulpZFQ==", "857f56a9-0acc-41a1-aa7c-74a299dab9ac" });
        }
    }
}
