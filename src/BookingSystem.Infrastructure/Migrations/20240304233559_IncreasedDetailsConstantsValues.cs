using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class IncreasedDetailsConstantsValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Landmarks",
                type: "nvarchar(700)",
                maxLength: 700,
                nullable: true,
                comment: "Landmark's Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "Landmark's Details");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Hotels",
                type: "nvarchar(700)",
                maxLength: 700,
                nullable: true,
                comment: "Hotel's Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "Hotel's Details");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Countries",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                comment: "Contry's Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Contry's Details");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Cities",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                comment: "City's Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "City's Details");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Landmarks",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                comment: "Landmark's Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(700)",
                oldMaxLength: 700,
                oldNullable: true,
                oldComment: "Landmark's Details");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Hotels",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                comment: "Hotel's Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(700)",
                oldMaxLength: 700,
                oldNullable: true,
                oldComment: "Hotel's Details");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Countries",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Contry's Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldComment: "Contry's Details");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Cities",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "City's Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "City's Details");
        }
    }
}
