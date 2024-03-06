using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedLandmarkIstanbul : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5655339-8e0c-43d1-a3f8-770ba459996b", "AQAAAAEAACcQAAAAEAPDNInraOKCMlY8kQLKHVJ73IXYmROLNBt+92fb0PioV9dq0dzOjcHrYYcnJe3ZQw==", "b742af15-533e-455b-a35f-2bee04af5df7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0b7266d-d98d-41ed-b10f-802449291cda", "AQAAAAEAACcQAAAAEB1OCsgCKB1koyelSsHYygIj9ULVHsMgZn/ywT4snHezmj4N4bA1zkiUHNsLVVl8VA==", "3c770f69-dd3d-4727-933f-4ce4bd156768" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 6,
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
                values: new object[] { "2a9c0f00-bd65-4b6c-b8f2-1f72b327d10b", "AQAAAAEAACcQAAAAENiErA9BfS3ozCKLiIGtGMCkWVfx8/8hMEg3YpgC+tO3FNKW3YmpfNY7HRbdMlKjzA==", "eec2d664-6239-4759-87b5-195b55da672e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6379a8bc-0687-43b0-a734-527ff937a759", "AQAAAAEAACcQAAAAEPlqOXs/rx9w82aFGuh1Jp16kN7HoGGVisxnPuuhyZy61qTaeO1uk2AyqiysIwIaeg==", "5903ceff-9361-46a8-9ebc-92a9012211f7" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 6,
                column: "City_Id",
                value: 4);
        }
    }
}
