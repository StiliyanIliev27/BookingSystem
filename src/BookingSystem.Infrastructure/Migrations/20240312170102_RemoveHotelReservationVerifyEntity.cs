using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class RemoveHotelReservationVerifyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelsReservationsVerifies");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "985a4e0d-3460-4e81-8284-35edd08858e4", "AQAAAAEAACcQAAAAEMRmCETTUIHEve45caDY6Ad8sUbi78gJv/oV0iA1aceTkUIZ993DMa/RtCXXcdz4CA==", "38abe867-1708-43af-aab2-223aa6326bd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42d7be80-985f-4c40-ac18-a508349d70f4", "AQAAAAEAACcQAAAAEG1Rx3WQEWtNiBUT1swbz0mCIES2FYx9QFl1aKMxzNhSzh9CeKd4Dj6pYV/cmTwLJg==", "44a28441-3606-4c2e-ac5d-e0de5bdff639" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelsReservationsVerifies",
                columns: table => new
                {
                    Hotel_Id = table.Column<int>(type: "int", nullable: false, comment: "Room's Hotel's Identifier"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "HotelReservation's User's Identifier"),
                    Room_Id = table.Column<int>(type: "int", nullable: false, comment: "HotelReservation's Room Identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's CreatedOn Time"),
                    DurationDays = table.Column<int>(type: "int", nullable: false, comment: "Reservation duration days"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's End Date"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Hotel's Reserver's First Name"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "HotelReservation's Active Status"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Hotel's Reserver's Last Name"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "HotelReservation's Total Price"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's Start Date")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelsReservationsVerifies", x => new { x.Hotel_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_HotelsReservationsVerifies_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelsReservationsVerifies_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelsReservationsVerifies_Rooms_Room_Id",
                        column: x => x.Room_Id,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Hotel Reservation Verify");

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

            migrationBuilder.CreateIndex(
                name: "IX_HotelsReservationsVerifies_Room_Id",
                table: "HotelsReservationsVerifies",
                column: "Room_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelsReservationsVerifies_User_Id",
                table: "HotelsReservationsVerifies",
                column: "User_Id");
        }
    }
}
