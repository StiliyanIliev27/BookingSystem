using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class LanguagePropAddedToCountryEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Language_Id",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Country's Official Language Identifier");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Language_Id",
                table: "Countries",
                column: "Language_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Languages_Language_Id",
                table: "Countries",
                column: "Language_Id",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Languages_Language_Id",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_Language_Id",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Language_Id",
                table: "Countries");
        }
    }
}
