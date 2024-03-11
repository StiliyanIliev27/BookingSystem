using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class CreateHotelReservationVerifyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelsReservationsVerifies",
                columns: table => new
                {
                    Hotel_Id = table.Column<int>(type: "int", nullable: false, comment: "Room's Hotel's Identifier"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "HotelReservation's User's Identifier"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Hotel's Reserver's First Name"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Hotel's Reserver's Last Name"),
                    Room_Id = table.Column<int>(type: "int", nullable: false, comment: "HotelReservation's Room Identifier"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "HotelReservation's Total Price"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's Start Date"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's End Date"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's CreatedOn Time"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "HotelReservation's Active Status")
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
                values: new object[] { "f128f165-6b6f-45e3-b321-d513ba64c97f", "AQAAAAEAACcQAAAAECpUqcnW7XIQQUgIN1MbcVUo0FddFXWOCe33LSeRkX+oETKcWAbw8fVODsLuBgANGA==", "b93080e1-44d9-415a-ab5c-d2405956b350" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ed316f4-fac2-423c-8dc5-24d13638560f", "AQAAAAEAACcQAAAAEDwACIgqL9IkewpSKojyU8wwDqKfOnvjxXWmZ7PQX6oxtxzHARLOabb0G2hwoqoDKQ==", "a2a28201-542c-46a7-afec-e5105d93e5a7" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 12, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_HotelsReservationsVerifies_Room_Id",
                table: "HotelsReservationsVerifies",
                column: "Room_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelsReservationsVerifies_User_Id",
                table: "HotelsReservationsVerifies",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelsReservationsVerifies");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e838ea-acc3-4197-9296-b251622bfa02", "AQAAAAEAACcQAAAAEFP/tWXMubNe0HpSmk6dwxwcmNTTjHZ03tH8GNZZl4kyMJsEF78eNyp1esWclygvyA==", "e7a131bc-be90-4e9a-b082-531a492bdc13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c9a0ff7-afbb-4cdb-98da-16b0b81a6e32", "AQAAAAEAACcQAAAAEJ7Of9mMP5e8SGXPoYsEL1hMy/xTOMUSapgLUBnY+wz23rswlhYeKmlGXh7gLpGwtQ==", "25905966-6c35-456d-be18-d904ca40a99a" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 11, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
