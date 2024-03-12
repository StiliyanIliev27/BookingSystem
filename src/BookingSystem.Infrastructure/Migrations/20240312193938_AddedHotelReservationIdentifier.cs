using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedHotelReservationIdentifier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelReservationVerifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "HotelsReservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Hotel Reservation Identifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations",
                columns: new[] { "Hotel_Id", "User_Id", "Id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3facb519-0984-43ca-ad53-7939d85ff4f8", "AQAAAAEAACcQAAAAEEfSvI0PDk679f5ra1Lv7aFoF0KcC3272yOJBX5ucDrymsqaHDp4G9VWF8m+ElGOtQ==", "26a4f2d3-7b36-4035-beae-8d611ef4b06b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bdc1823-fa93-4a0c-94f5-a0793902e489", "AQAAAAEAACcQAAAAEM79c0Su2LLplWOrMGNwXm5ZEfH1eVCZemOoF1OnSfRKdEdab0V6324RSiG5772xOg==", "f4e3f3a9-b095-471b-a491-72d7e075c94d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HotelsReservations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations",
                columns: new[] { "Hotel_Id", "User_Id" });

            migrationBuilder.CreateTable(
                name: "HotelReservationVerifies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Hotel Reservation Verify Identifier"),
                    Hotel_Id = table.Column<int>(type: "int", nullable: false, comment: "Room's Hotel's Identifier"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "HotelReservation's User's Identifier"),
                    Room_Id = table.Column<int>(type: "int", nullable: false, comment: "HotelReservation's Room Identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's CreatedOn Time"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's End Date"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Hotel's Reserver's First Name"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "HotelReservation's Active Status"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Hotel's Reserver's Last Name"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "HotelReservation's Total Price"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's Start Date")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelReservationVerifies", x => new { x.Id, x.Hotel_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_HotelReservationVerifies_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelReservationVerifies_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelReservationVerifies_Rooms_Room_Id",
                        column: x => x.Room_Id,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8b43b61-f0aa-4907-b993-09a16750036d", "AQAAAAEAACcQAAAAEH/IJMnu0Dihbeck85A71WtsBt1TyIBNNhgeZsqJaANr5fT13+XBMGy+fw3ISWF3sw==", "68f64ae1-2d9c-4575-b809-4c224202b6da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91f3d23e-123c-4aae-bcca-3db8bf7c1831", "AQAAAAEAACcQAAAAEE4fIaqKBLU6iZZumNCaMYCR732MRwNe+RxtF/YYfGUoJUdpjIcliZabL1gF7zAsGA==", "5de0f471-4527-40d9-9809-6e2127fce175" });

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationVerifies_Hotel_Id",
                table: "HotelReservationVerifies",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationVerifies_Room_Id",
                table: "HotelReservationVerifies",
                column: "Room_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationVerifies_User_Id",
                table: "HotelReservationVerifies",
                column: "User_Id");
        }
    }
}
