using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class RemovedUserIdAndHotelIdPrimaryKeysAndSetItToId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "HotelsReservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Hotel Reservation Identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Hotel Reservation Identifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0607b919-ef21-457a-8d47-89107f199975", "AQAAAAEAACcQAAAAEB7MCGmBh4H4JH5+y4iNRmupAYIcUrGZFfj/Ou/iSLq5sz+ZYhlg4pHrPu7gLGxrlQ==", "94a6b8bb-a434-4d71-ae32-a680ee282162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d8c695-9f31-4900-969c-9386e2f4140b", "AQAAAAEAACcQAAAAED0mLOh7x9PmECZpIB1b1NK0yTwHEsu0QA9/lK+sNbyBKaP9eC+em9BONjCBCs3dTA==", "5897a60e-c08c-42e6-bd57-8028e2649402" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_HotelsReservations_Hotel_Id",
                table: "HotelsReservations",
                column: "Hotel_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations");

            migrationBuilder.DropIndex(
                name: "IX_HotelsReservations_Hotel_Id",
                table: "HotelsReservations");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "HotelsReservations",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Hotel Reservation Identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "Hotel Reservation Identifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations",
                columns: new[] { "Hotel_Id", "User_Id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08bde661-1018-4cc2-9245-8ae0ffcc3d47", "AQAAAAEAACcQAAAAEFO13bzbYFbDYEv8tYoxycsWsey6nDJk+Ub2knOJYJPmcWjAYWIB2X85kBWgxQg6YA==", "9b812e7a-6eaa-43ed-9e26-1758ebda1dc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "873defd7-08b6-4bef-a3b0-8d61a959a604", "AQAAAAEAACcQAAAAEP/sZtNWkuDRNR77TbB5soFOYS2W5wyMkiFEvnWXUumY8bks7LdFyjb6l4HJ+3Hezg==", "a498e3ba-4974-4103-a024-65a2cd8fc1ec" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 15, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 9, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 6, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 14, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 15, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 21, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 14, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
