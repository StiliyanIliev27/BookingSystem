using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddHotelReservationVerifyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelReservationVerifies",
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
                    table.PrimaryKey("PK_HotelReservationVerifies", x => new { x.Hotel_Id, x.User_Id });
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
                values: new object[] { "da2a3f3e-311e-4a9b-8b78-fc0096c700ed", "AQAAAAEAACcQAAAAEAvOtxScBiHK2DoKXi8flmO3I8vpuzKXYB2gvf1cOAO3kKm5mJy1B/1JH2RHKlm69g==", "4379c21c-04cb-49f5-b20e-85bf10ec04d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28cc69cd-1d27-43ef-bbfb-4632612329af", "AQAAAAEAACcQAAAAEG+YnpQc/8V7VRtQ33MsTjpqqQyl+e6Gwi3Ap2SIGUBPfQ1UcrYSyndjkOt4g4AMnA==", "a31837e9-e6cb-4b05-9357-9ad1ef63c09c" });

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationVerifies_Room_Id",
                table: "HotelReservationVerifies",
                column: "Room_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationVerifies_User_Id",
                table: "HotelReservationVerifies",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelReservationVerifies");

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
    }
}
