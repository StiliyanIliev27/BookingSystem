using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AdminAndGuestUserNameSeedCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62d28ee6-5a44-4529-bb9d-91cb7ee61ce0",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "16012a6a-bbfe-4d6f-a614-787a2b95f170", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECZODdzyJJXnTqKGUAiMUuSfk7OPGy+BbcIkZiLZeFA89iSw09FgU9RnxyoeNqNm1A==", "4edbf007-4c08-4dad-b074-135e1720a7cc", "admin@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebf07620-6aa8-4fef-9170-461d816c12f6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d3f8a9bc-6a53-4883-ae3e-3ae6ef0d4750", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAEGOkycrxz4MeZjZjnimZstlm4+mundbS7hdmUJEIdM0Z7Z7sdphv9cmsMB5UTdHUrA==", "3f32d097-4574-4fd2-8110-3d3a2f9874c0", "guest@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62d28ee6-5a44-4529-bb9d-91cb7ee61ce0",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "755f7187-c44a-44fc-9d22-bf84c13e7df3", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEA2uk/tggWw/CEHJHWbMAV8VHS/hgJCQW+oa4NJcvceSFMWzXQREkirrsJUyl6frIA==", "0561017e-2ac3-437a-bcad-4c345463e147", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebf07620-6aa8-4fef-9170-461d816c12f6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "713b111e-42b4-43d7-8aea-2f009e8d47fc", "GUEST", "AQAAAAEAACcQAAAAEKnJHKjOQP6P1rIJLvID2e/Wa6Q57QMpYkcQJpmc4Ri//iki2SWEzQSZ4A4eaPGRHw==", "79dce757-36f5-4c67-bcce-b8ba60a0026d", "Guest" });
        }
    }
}
