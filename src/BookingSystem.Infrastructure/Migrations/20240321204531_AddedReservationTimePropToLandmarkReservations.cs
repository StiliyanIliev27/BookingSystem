using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedReservationTimePropToLandmarkReservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationDateTime",
                table: "LandmarksReservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationDate",
                table: "LandmarksReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "LandmarkReservation's Date");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationTime",
                table: "LandmarksReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "LandmarkReservation's Time");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58f3f413-16f5-475f-a681-bfa11b91f5ab", "AQAAAAEAACcQAAAAEIKl/9/mE/q5Qaq0h2oVwYVnOQyEeRP/DCPhCAZzj6DIy1cRlCv6UwGSf5Qa7Axagw==", "215fe7e9-d848-4d9c-adcf-a021c81860bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "832ed480-b184-4373-955a-0e4165ad3c29", "AQAAAAEAACcQAAAAELHc0fZKKIWhxTnnX5U1yLWQESZtWbcKHzxVdiZl4OC35dCBPPXIC01kkpVYfsPLFw==", "6ca19346-e6cb-47c9-b064-2b3b19a5548c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationDate",
                table: "LandmarksReservations");

            migrationBuilder.DropColumn(
                name: "ReservationTime",
                table: "LandmarksReservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationDateTime",
                table: "LandmarksReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "LandmarkReservation's DateTime");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ab9a6d4-b70c-4cd4-bf2a-633431f32e64", "AQAAAAEAACcQAAAAEHS6C9bNWuinui6hl8VK1NQTxvusHMB1Zc5TAVeCYU6HvSG5XK1jQW7PUbj1M6mHYA==", "89c13192-4ad2-4696-b724-a546c458b21e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8287506f-8d24-4d9c-beff-4c03fef18f9a", "AQAAAAEAACcQAAAAEA+GmbLcxUZzBv5mz8EdL4O0ZvzlpJvLTN+X+Ab5sqvEsrUbFZtlezFbLKEWG1RMzw==", "7975f2d8-3314-432a-9841-f68436bb98fc" });
        }
    }
}
