using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class UpdateBulgariaContinentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8afa1a24-ebf5-49b0-8a2b-28f26e3b53aa", "AQAAAAEAACcQAAAAEBUITvnirJc6wns9Az2Ju8rYzaGs5U9fm8yGFD7TzyLmSiPVRUP9TV+mBv/j2LJ7tw==", "05b75266-f78c-4264-ade3-0f83ff6d7598" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eccfad1b-97b8-43e4-9e64-812620c38ccd", "AQAAAAEAACcQAAAAENMAkPGODt0E9+RbYFdiDm8Ul9pNCc+HMuvPbRB0WnL3ylWuNA9qPysQeWyo2kArtA==", "8de24a8e-f8e3-4995-8f1e-d381eb05ae66" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Continent_Id",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "666ca546-aeb3-4805-bc90-f65b6ff62871", "AQAAAAEAACcQAAAAEMPGQ/ib2+1WR7FxuMrUeb1SFH08xgOk+4Nd4+Ng7yW6CldLIqPp4ed1mCL7zEkqMQ==", "357e7034-bdcb-49be-baec-8bbbd050aa2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36e8fdd7-a361-4431-94f5-fe0053b37e29", "AQAAAAEAACcQAAAAEGKX4zvN1h4SCwOCHdDe1TfH5hcQ8C9I+ylaB1taxS3uGRjdNalVpNDUaef51qFNmQ==", "506c11af-e9cb-4738-8023-c1cf75eb6f65" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Continent_Id",
                value: 3);
        }
    }
}
