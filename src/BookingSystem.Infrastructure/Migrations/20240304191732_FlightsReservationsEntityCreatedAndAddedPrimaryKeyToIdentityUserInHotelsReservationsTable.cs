using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class FlightsReservationsEntityCreatedAndAddedPrimaryKeyToIdentityUserInHotelsReservationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations");

            migrationBuilder.DropIndex(
                name: "IX_HotelsReservations_Hotel_Id",
                table: "HotelsReservations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HotelsReservations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations",
                columns: new[] { "Hotel_Id", "User_Id" });

            migrationBuilder.CreateTable(
                name: "FlightsReservations",
                columns: table => new
                {
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User's Identifier"),
                    Flight_Id = table.Column<int>(type: "int", nullable: false, comment: "Flight's Identifier"),
                    SeatNumber = table.Column<int>(type: "int", nullable: false, comment: "Flight's Reseravation's Seat Number"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Flight's Reservation Creation Time"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flight's Reservation Active Status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightsReservations", x => new { x.Flight_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_FlightsReservations_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightsReservations_Flights_Flight_Id",
                        column: x => x.Flight_Id,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "FlightReservations");

            migrationBuilder.CreateIndex(
                name: "IX_FlightsReservations_User_Id",
                table: "FlightsReservations",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightsReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "HotelsReservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "HotelReservation's Identifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelsReservations_Hotel_Id",
                table: "HotelsReservations",
                column: "Hotel_Id");
        }
    }
}
