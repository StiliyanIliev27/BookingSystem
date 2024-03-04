using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class RemovedCountriesLanguagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountriesLanguages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountriesLanguages",
                columns: table => new
                {
                    Country_Id = table.Column<int>(type: "int", nullable: false, comment: "Country's Identifier"),
                    Language_Id = table.Column<int>(type: "int", nullable: false, comment: "Language's Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountriesLanguages", x => new { x.Country_Id, x.Language_Id });
                    table.ForeignKey(
                        name: "FK_CountriesLanguages_Countries_Country_Id",
                        column: x => x.Country_Id,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountriesLanguages_Languages_Language_Id",
                        column: x => x.Language_Id,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "CountryLanguage");

            migrationBuilder.CreateIndex(
                name: "IX_CountriesLanguages_Language_Id",
                table: "CountriesLanguages",
                column: "Language_Id");
        }
    }
}
