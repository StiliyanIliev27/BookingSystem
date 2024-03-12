using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedIdToHotelReservationVerify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "HotelsReservationsVerifies");

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
        }
    }
}
