using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class ChangedHotelReservationIdentifierWithGuidInsteadString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "HotelsReservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "Hotel Reservation Identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Hotel Reservation Identifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a82d8990-2f09-4f7b-9c5b-7e25acd8d2da", "AQAAAAEAACcQAAAAEBewKxUcojQgD9IuUiXJyOnMh7NcTGLAkBm0+McnV1aussWiN+OlYQrdDQmYoHyaMw==", "eb04954c-66d1-4a49-9b68-94fca60281ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16082130-64d6-4e61-ac66-e944acff9afd", "AQAAAAEAACcQAAAAEGICbZCUF3Xm+jPfbMVmuwxislR+yPJE9XTec28Hfjh7T3F9nBz6p0jf0mtiSim38Q==", "277c6961-1ace-4d81-8665-e38f26586f56" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "HotelsReservations",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Hotel Reservation Identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Hotel Reservation Identifier");

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
    }
}
