using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class CreatedLandmarkReservationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LandmarksReservations",
                columns: table => new
                {
                    Landmark_Id = table.Column<int>(type: "int", nullable: false, comment: "Landmark's Identifier"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "LandmarkReservation's User's Identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "LandmarkReservation's CreatedOn Time"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "LandmarkReservation's Active Status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandmarksReservations", x => new { x.Landmark_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_LandmarksReservations_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandmarksReservations_Landmarks_Landmark_Id",
                        column: x => x.Landmark_Id,
                        principalTable: "Landmarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Landmark Reservation");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "616db90a-c62d-4b68-9bf7-0cd710567478", "AQAAAAEAACcQAAAAEC+0QdRkL6xSwBZly8pQBt/GsFpSqketK42dWQqGNuqI/dpCMdgorJys0u/Gj8WJKQ==", "e2c37079-6b60-4594-babe-18fdbd26c917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43915757-9ea1-4403-8ca5-b45002138648", "AQAAAAEAACcQAAAAEHrs9zycG3iICr1nkXdWKjPBm6tEk7BQjTkKlz6e7nl1E3nvQ//Ds/pQD6KmIZQ8/w==", "ab38eb46-42e3-4202-bb13-31b62b71a56d" });

            migrationBuilder.CreateIndex(
                name: "IX_LandmarksReservations_User_Id",
                table: "LandmarksReservations",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandmarksReservations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f3a396c-e878-4094-b4be-4dc1494a7431", "AQAAAAEAACcQAAAAECtabNFgEt0k0vNOEoWjTUGGo6EhSwrmx8/3EQM+R5JWTUrIcE08B3qrwOS3sjOTeA==", "3dceb0fd-95ca-405d-bfa8-ca702dedd891" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ea23174-2662-43ff-8832-fcb7fc942bd7", "AQAAAAEAACcQAAAAEIaj0azliW//mszpdrGwnBDPomDsrKO3gPcRSxCe73EUpr9ApAulHirPXc8h4n0xTw==", "8cbd94e4-1d45-4a7b-879b-107ada252ebc" });
        }
    }
}
