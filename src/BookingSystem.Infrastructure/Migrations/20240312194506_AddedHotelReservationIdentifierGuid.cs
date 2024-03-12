using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedHotelReservationIdentifierGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "HotelsReservations",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Hotel Reservation Identifier",
                oldClrType: typeof(int),
                oldType: "int",
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
                values: new object[] { "26dc66f6-3b5f-4eed-b35c-f9b053e68868", "AQAAAAEAACcQAAAAEMMZo6rkn5cM/8FXp8+DnN4wlM/eNSYdWd4l7hArESuAcvaOm74lbFevdLmfQq+cVA==", "9bb5c270-355a-4a0f-8c32-1b3e94c5ea66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51dc5207-1c91-42ae-bdb6-7209541f75f6", "AQAAAAEAACcQAAAAEEzUFx6BmEf0czTqizK/73Znrg5nTmrWiUlINyepBwyDl5BpXqyoVuxvRKoP43GVuw==", "a16147d8-2a9f-40c4-bbe2-bad642e8bcd7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelsReservations",
                table: "HotelsReservations");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "HotelsReservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Hotel Reservation Identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Hotel Reservation Identifier");

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
    }
}
