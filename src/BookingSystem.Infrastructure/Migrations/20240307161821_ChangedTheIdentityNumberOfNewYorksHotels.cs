using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class ChangedTheIdentityNumberOfNewYorksHotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e278603-04c8-461c-8eff-63bc116a8fe2", "AQAAAAEAACcQAAAAEPMrNj2Nu7rWheWGUoG5H/ay5et5lFe+mskE4d2jrFfkW38Ornmb0T66J2S1GJo2vw==", "f7264997-89be-4e80-b3fe-82faaca804e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c071d2-c3d3-4e2e-a4f5-5a26e0b25340", "AQAAAAEAACcQAAAAELSmPBJx6sx4EHdx1+09VCoqi/SsSVvtR/keO9FvG1MJ8oMgJfSDpRIVeHTeQ7I/Fg==", "a059a477-d34f-441d-bfbc-d2d5422d04e3" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                column: "City_Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                column: "City_Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                column: "City_Id",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61717fa4-8a7b-4774-889d-2685812dbe13", "AQAAAAEAACcQAAAAEDHY248VTq7tvPoUflLoDoP09XiC8ceVCuHApjaswt4xZ2WbxSNtS1NtpvaSWGiHCw==", "462aba7b-dff9-45fd-957b-db77b6ba2f3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdb74127-2c4f-400d-a582-442f9c2b0bdf", "AQAAAAEAACcQAAAAECwYmj1YYlvKrhfUtpIE848J8EzVeO0o/jWo6JCNayAo3nt7e/URb2wa91tMkjgWwQ==", "ecfae1fc-518f-49d1-969b-84765d5095ce" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                column: "City_Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                column: "City_Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                column: "City_Id",
                value: 4);
        }
    }
}
