using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedLandmarks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "Address", "City_Id", "Details", "IsActive", "Name", "TicketPrice" },
                values: new object[,]
                {
                    { 1, "Champ de Mars, 5 Av. Anatole France, 75007 Paris", 1, "Completed in 1889, this colossal landmark, although initially hated by many Parisians, is now a famous symbol of French civic pride.", true, "Eiffel Tower", 40m },
                    { 2, "99 Rue de Rivoli, 75001 Paris France", 1, "The Louvre Museum, located in Paris, is the world's largest art museum and a historic monument in France. It houses thousands of works of art, including the renowned Mona Lisa and the Venus de Milo, spanning from ancient civilizations to the 19th century.", true, "Louvre Museum", 46.46m },
                    { 3, "Calle de Bailen s/n, 28071 Madrid Spain", 2, "Luxurious, over-the-top rococo palace with over 2,000 opulently gilded rooms.", true, "Royal Palace Of Madrid", 43.14m },
                    { 4, "Calle Gerona 4, 28012 Madrid Spain", 2, "Huge plaza packed with cafes, bars and tourists.", true, "Plaza Mayor", 0.0m },
                    { 5, "59th to 110th Street Manhattan Borough, NY 10022", 4, "For more than 150 years, visitors have flocked to Central Park's 843 green acres in the heart of Manhattan. Since 1980, the Park has been managed by the Central Park Conservancy, in partnership with the public. Central Park is open 6 am to 1 am daily. Visit the official website of Central Park to learn more about Park happenings and activities and to learn how you to help Central Park!", true, "Central Park", 0.0m },
                    { 6, "20 W 34th St., New York, NY 10001", 4, "The Empire State Building is the World's Most Famous Building. It rises 1,454 ft from ground to antenna & features the only 360 degree open-air vantage point of Midtown. The 86th & 102nd Fl Observatories are open daily, see esbnyc.com for hours.", true, "Empire State Building", 47.91m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
