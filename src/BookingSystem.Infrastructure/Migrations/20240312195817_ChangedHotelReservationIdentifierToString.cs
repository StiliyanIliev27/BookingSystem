using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class ChangedHotelReservationIdentifierToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "57a40bef-ff17-4ee2-9f35-d9b48e3886b5", "AQAAAAEAACcQAAAAEIXd7vulUzacyGfNGPAGcLNB6dItkHwp7kKEW7y82DOerOeF2pfZzsL94FHp8tbHWQ==", "217ea223-7562-4b11-a822-690c9e4f0d62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b23325e-557a-4b3b-b6c7-afbb833d9803", "AQAAAAEAACcQAAAAEKAiyJVACjnJTlxnUJs5DS+C0XjI9u6Dau7UIgWfo3rdGMffN0dNLOptfSn1Utmk+Q==", "5a3a3275-0016-4ed8-b931-719d56fff3e0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
