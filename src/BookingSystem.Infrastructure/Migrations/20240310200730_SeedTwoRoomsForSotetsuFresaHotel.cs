using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedTwoRoomsForSotetsuFresaHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1039c978-af29-4fe1-8862-25fce1a32958", "AQAAAAEAACcQAAAAEBhEnHNcpO9mD8O+NTGwQREqRT7C2gzNrzW+S6xnR6zwcVjFC1uuwSm1miuo/8kDgQ==", "7edd9407-d336-45c9-9976-e1e63caa1248" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d416087f-b752-4064-8f12-1ef37af28762", "AQAAAAEAACcQAAAAED1UNRYsyNEzS/qiv/Bsco/aFaOgoBloPoanfu5aOTFl3yvVbLwQWQn3OW8mVgrj2A==", "2a6cef84-942d-4135-abe2-a2180551b9ec" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Count", "Hotel_Id", "IsActive", "IsReserved", "PricePerNight", "Type", "WiFi" },
                values: new object[,]
                {
                    { 45, 5, 17, true, false, 223m, 1, true },
                    { 46, 5, 17, true, false, 289m, 2, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "835ec55f-3be5-4a6a-8faf-d0d1ab9ec473", "AQAAAAEAACcQAAAAENLUkvqgxTfDH7UYbkKws9plpZfvov+0VF5I55+XpKhA/ZLdeMTXTLi2RY9pjfG9lA==", "791f20cd-be51-445c-8036-a62d69ed866f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b54495b-16eb-4052-a987-fa9772b053b6", "AQAAAAEAACcQAAAAEEhZMu8BDRnBMJtflRKQS3T87uV3NvQLsg3d4PW7fdEqDJk2mMYcKAyI3G1iVDrgVQ==", "fc017301-a7fa-43cf-a41e-3d3a6289d703" });
        }
    }
}
