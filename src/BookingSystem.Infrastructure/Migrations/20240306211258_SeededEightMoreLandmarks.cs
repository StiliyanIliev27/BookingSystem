using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeededEightMoreLandmarks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f92e6db2-1e77-4a82-ab01-114b3f2f6704", "AQAAAAEAACcQAAAAEH+N2TvYz1+Bhisa4DmCMRAtmQ5h8QXtpCAdbwTq2L0VI2/4RQZehvjO1RZcxib9ZA==", "e07b2bf5-7022-418e-8114-ab45d327a737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca01d324-7e73-4371-9657-9596d501c476", "AQAAAAEAACcQAAAAEIvkv8cdYC4XV1AGTAuIsKdclFHOdmq8WKMVFwFxOYezG4HJz++fZNCm6FBuHkjm9g==", "ee668b0c-0dfe-4aa5-aaed-cf36c06c2dc1" });

            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "Address", "City_Id", "Details", "IsActive", "Name", "TicketPrice" },
                values: new object[,]
                {
                    { 7, "Sultan Ahmet, Ayasofya Meydanı No:1, Istanbul 34122 Türkiye", 4, "This architectural marvel displays 30 million gold tiles throughout its interior, and a wide, flat dome which was a bold engineering feat at the time it was constructed in the 6th century.", true, "Hagia Sophia Mosque", 0.0m },
                    { 8, "Alemdar Mahallesi, Yerebatan Caddesi, No:1/3, Istanbul 34410 TÃ¼rkiye", 4, "The Basilica Cistern, or Sunken Palace, in Istanbul's Sultanahmet district dates back to the 6th century. It's the largest surviving cistern from the Byzantine era, featuring over 330 marble and granite columns, including two famous Medusa heads. Recognizable from \"From Russia with Love,\" it's a must-visit spot along with Hagia Sophia and Topkapi Palace. Joining a tour can streamline your visit to these iconic Istanbul landmarks.", true, "Basilica Cistern", 0.0m },
                    { 9, "Piazza del Colosseo, 00184 Rome Italy", 5, "The ancient Flavian Amphitheater was built by the Flavian emperors in 70 C.E. as a gift to the Roman people. As the largest Roman theater ever built, it was designed to house over 50,000 people, and had played host to gladiator games, plays and even public executions.", true, "Colosseum", 38.86m },
                    { 10, "Piazza della Rotonda, 00186 Rome Italy", 5, "Dedicated to the seven planetary divinities and featuring an interior of gorgeous marble, the Pantheon is one of the most impressive monuments of Augustan Rome.", true, "Pantheon", 0.0m },
                    { 11, "Sofia Center, pl.Sveti Aleksandar Nevski, 1000 Sofia", 6, "Completed in 1912, St. Alexander Nevsky Patriarchal Cathedral Stauropigial Memorial-Church is an impressive landmark in Sofia. The church was built as a memorial to the 200,000 Russian soldiers who died in the Russo-Turkish Liberation War (1877-1878).", true, "St. Alexander Nevski Cathedral", 0.0m },
                    { 12, "pl.Sveta Nedelya, Sofia 1000 Bulgaria", 6, "The Cathedral of Sveta-Nedelya, also known as the Cathedral of the Holy Virgin, is an Orthodox church located in the center of Sofia, the capital of Bulgaria. It was completed in 1867 in a neo-Byzantine style. The cathedral has witnessed significant historical events, including a bomb attack in 1925 by a communist group that resulted in numerous casualties. Today, it remains an important religious and tourist destination, showcasing impressive architecture and a rich cultural heritage.", true, "Catedral de Sveta-Nedelya", 0.0m },
                    { 13, "4-chome 2-8, Shibakoen, Minato 105-0011 Tokyo Prefecture", 7, "Tokyo Tower, built in 1958, is a communications and observation tower located in the Shiba-koen district of Minato, Tokyo, Japan. Standing at a height of 332.9 meters, it held the title of Japan's tallest tower until the construction of the Tokyo Sky Tree, which now surpasses it in height.", true, "Tokyo Tower", 15.00m },
                    { 14, "2-3-1, Asakusa, Taito 111-0032 Tokyo Prefecture", 7, "According to legend, two brothers kept trying to return a statue of Kannon, the goddess of mercy, to the Sumida River only to have it returned to them the next day. This temple located in Tokyo's Asakusa district was built to honor her.", true, "Senso-ji Temple", 0.0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d1f0bdc-f9e5-4856-a127-fb84281d56ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85e732aa-c9e4-40d8-aebe-cc416d3c175b", "AQAAAAEAACcQAAAAEKSOBTn8pkD5Abg4FUP1P3JwXcrkpyj/oe9xZBVuLYBejcM8UzN8sIFARmbRIi5gOw==", "b4879022-435a-473e-81e2-4819143fcf33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9019544-ec91-4248-bfc4-9d8a4f13430b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "735ca431-acaa-47db-985f-2790bf689987", "AQAAAAEAACcQAAAAEFG6HQbI84dRKmxdl/35hG7SaAxrsmjl8YGxQxZ8/0Sq6D40fo0G/HxsE37A3xtH2w==", "0aa589ca-36f9-4a22-8f21-79d68df72d3a" });
        }
    }
}
