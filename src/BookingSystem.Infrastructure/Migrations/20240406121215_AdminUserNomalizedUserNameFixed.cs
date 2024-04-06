using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class AdminUserNomalizedUserNameFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62d28ee6-5a44-4529-bb9d-91cb7ee61ce0",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67401756-b87b-42e7-badd-516d05ae10b6", "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEI/i/T0ieoQiJM/4fYmfjkrK8fwxBugCHGYjS+Ds6T6BIVwKS3lCI806dFJlCGmZcA==", "50393859-7479-43eb-9e98-76519a26276f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebf07620-6aa8-4fef-9170-461d816c12f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff30a5e4-d89c-4c02-be2b-47714e36925c", "AQAAAAEAACcQAAAAEJX54ibxGpdBEalZkt3Lp5Ma/y8BjsnyALZsnA1el39sdMzjUtClavk5IACYNIDf7w==", "9e281a16-1586-41f3-a909-921339a02ae0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62d28ee6-5a44-4529-bb9d-91cb7ee61ce0",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16012a6a-bbfe-4d6f-a614-787a2b95f170", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECZODdzyJJXnTqKGUAiMUuSfk7OPGy+BbcIkZiLZeFA89iSw09FgU9RnxyoeNqNm1A==", "4edbf007-4c08-4dad-b074-135e1720a7cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebf07620-6aa8-4fef-9170-461d816c12f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3f8a9bc-6a53-4883-ae3e-3ae6ef0d4750", "AQAAAAEAACcQAAAAEGOkycrxz4MeZjZjnimZstlm4+mundbS7hdmUJEIdM0Z7Z7sdphv9cmsMB5UTdHUrA==", "3f32d097-4574-4fd2-8110-3d3a2f9874c0" });
        }
    }
}
