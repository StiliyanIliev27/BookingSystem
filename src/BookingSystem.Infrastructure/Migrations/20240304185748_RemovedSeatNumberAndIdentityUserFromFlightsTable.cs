using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class RemovedSeatNumberAndIdentityUserFromFlightsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_AspNetUsers_User_Id",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_User_Id",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "SeatNumber",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "Flights");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatNumber",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Flight's Seat Number Place");

            migrationBuilder.AddColumn<string>(
                name: "User_Id",
                table: "Flights",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Flight's User's Identifier");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_User_Id",
                table: "Flights",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_AspNetUsers_User_Id",
                table: "Flights",
                column: "User_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
