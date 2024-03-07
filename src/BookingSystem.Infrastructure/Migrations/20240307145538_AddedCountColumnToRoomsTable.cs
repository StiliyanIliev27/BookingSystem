using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AddedCountColumnToRoomsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Room's Count");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f3a396c-e878-4094-b4be-4dc1494a7431", "AQAAAAEAACcQAAAAECtabNFgEt0k0vNOEoWjTUGGo6EhSwrmx8/3EQM+R5JWTUrIcE08B3qrwOS3sjOTeA==", "3dceb0fd-95ca-405d-bfa8-ca702dedd891" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ea23174-2662-43ff-8832-fcb7fc942bd7", "AQAAAAEAACcQAAAAEIaj0azliW//mszpdrGwnBDPomDsrKO3gPcRSxCe73EUpr9ApAulHirPXc8h4n0xTw==", "8cbd94e4-1d45-4a7b-879b-107ada252ebc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b51362bd-12ad-4a4a-912d-d5dbac7f71b5", "AQAAAAEAACcQAAAAEOpEO4cRZ5g0NPdfcYeEl+6/PjfkAECc+cHERgp/9U98GCIQ5tS90TwtxIR+KW7eKw==", "268b44f4-6b5b-4b36-a52e-59f3062f3960" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36dcd6b3-dff2-433f-b72e-9e2191b0c5a3", "AQAAAAEAACcQAAAAEHYg4SJzqty2pwk/EeRv0yj8HdmKkONhp4Bcc7kNPi49FMZbTkeP1IJ//85OcFvlJQ==", "f61204d6-4519-407f-a1dc-72dd44c0c348" });
        }
    }
}
