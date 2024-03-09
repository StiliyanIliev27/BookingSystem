using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class InsertPopulationInMadrid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3383eb07-65c6-44cf-9524-2a71bcbf843c", "AQAAAAEAACcQAAAAEJlzezn4wq4wdvMNywn4iddX6hevaPQJ6MQ6btL1AAz3UEl2gymsxB04EvYSE+DGrw==", "7f859357-6c66-4c44-92b4-6faa1fd78c4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e36bb2a9-45b2-4e04-9ed2-645410a3b5c2", "AQAAAAEAACcQAAAAEC3BRaQak7hT38Xj3yvNgpQ1OBmhoVKUaGV4gTWB7d/Eg0/PcbpI+p3asyTELcbG4g==", "6448e5f6-662f-45d2-99ea-0814d393ade6" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Population",
                value: 6783000L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "163caf11-55a0-474a-8cc5-658a70528867", "AQAAAAEAACcQAAAAEOe3uUDSdMarbKlrF4selOPrUHdyzN+7lGhoBYqb86sbPzVi2Ouife4pTQ18iMcrUA==", "b97e0c44-b8eb-41c4-b40f-903f1c26d273" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84f269e1-6fff-455f-b11d-9b8a0fbcac38", "AQAAAAEAACcQAAAAEIqIzlBVI202clrQChNN8knw4Caq/F5g14YiuanrRcvmpZZIpX6UyOAyaI7HGoQnJw==", "84a44ad6-bf96-43f1-ae17-cb9169ecd0bf" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Population",
                value: 0L);
        }
    }
}
