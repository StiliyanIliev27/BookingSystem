using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddIdentifierToHotelReservationVerifyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelReservationVerifies",
                table: "HotelReservationVerifies");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "HotelReservationVerifies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Hotel Reservation Verify Identifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelReservationVerifies",
                table: "HotelReservationVerifies",
                columns: new[] { "Id", "Hotel_Id", "User_Id" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelReservationVerifies",
                table: "HotelReservationVerifies");

            migrationBuilder.DropIndex(
                name: "IX_HotelReservationVerifies_Hotel_Id",
                table: "HotelReservationVerifies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HotelReservationVerifies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelReservationVerifies",
                table: "HotelReservationVerifies",
                columns: new[] { "Hotel_Id", "User_Id" });

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
        }
    }
}
