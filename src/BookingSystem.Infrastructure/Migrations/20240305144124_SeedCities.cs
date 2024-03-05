using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class SeedCities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Area", "Country_Id", "Details", "Name", "Population" },
                values: new object[,]
                {
                    { 1, "105,4 km²", 1, "Paris, the capital of France, is renowned for its romantic ambiance, iconic landmarks, and vibrant culture. Visitors flock to marvel at the Eiffel Tower, explore the world-class museums like the Louvre and Musée d'Orsay, and stroll along the charming streets of Montmartre or the picturesque banks of the Seine River. With its rich history, exquisite cuisine, and fashionable boutiques, Paris captivates travelers from around the world.", "Paris", 11277000L },
                    { 2, "8,028 km²", 2, "Madrid, the capital of Spain, is a vibrant metropolis known for its lively atmosphere, rich history, and cultural treasures. Visitors can explore world-class art museums such as the Prado and Reina Sofía, wander through historic neighborhoods like the Barrio de las Letras, and indulge in delicious tapas at bustling markets like Mercado de San Miguel. With its beautiful parks, grand boulevards, and dynamic nightlife, Madrid offers a captivating blend of tradition and modernity for travelers to enjoy.", "Madrid", 0L },
                    { 3, "783,8 km²", 3, "New York City, often referred to as the \"Big Apple,\" is a bustling metropolis known for its iconic skyline, diverse culture, and vibrant energy. Visitors can explore world-famous landmarks such as the Statue of Liberty, Times Square, and Central Park, or immerse themselves in the city's rich cultural scene by visiting museums like the Metropolitan Museum of Art or catching a Broadway show. With its endless array of dining options, shopping districts, and neighborhoods to explore, New York City offers an unforgettable experience for travelers from around the world.", "New York", 19034000L },
                    { 4, "5 461 km²", 4, "Istanbul, the largest city in Turkey, is a mesmerizing blend of cultures, history, and modernity. It straddles two continents, Europe and Asia, and is known for its stunning architectural wonders such as the Hagia Sophia, Blue Mosque, and Topkapi Palace. Visitors can wander through the bustling streets of the Grand Bazaar, cruise along the Bosphorus, or savor delicious Turkish cuisine in traditional meyhanes (taverns). With its rich history as the former capital of the Byzantine and Ottoman Empires, Istanbul offers a unique and unforgettable experience for travelers.", "Istanbul", 16047000L },
                    { 5, "1,285 km²", 5, "Rome, the capital city of Italy, is a timeless destination steeped in history, art, and culture. Known as the \"Eternal City,\" Rome is home to iconic landmarks such as the Colosseum, Roman Forum, and Vatican City, which houses St. Peter's Basilica and the Sistine Chapel. Visitors can wander through cobblestone streets lined with ancient ruins, marvel at Renaissance masterpieces in museums and churches, and indulge in authentic Italian cuisine at trattorias and gelaterias. With its blend of ancient wonders and modern delights, Rome offers an unforgettable experience for travelers seeking to immerse themselves in the heart of Italy's rich heritage.", "Rome", 4332000L },
                    { 6, "492 km²", 11, "Sofia, the capital city of Bulgaria, is a dynamic metropolis with a rich history and vibrant culture. Visitors can explore its diverse architectural heritage, including ancient Roman ruins, Byzantine churches, and Ottoman mosques, alongside modern landmarks like the National Palace of Culture and the Alexander Nevsky Cathedral. The city also offers charming parks, bustling markets, and a burgeoning culinary scene, making it a fascinating destination for travelers looking to discover the unique blend of influences that shape Bulgaria's capital.", "Sofia", 1288000L },
                    { 7, "2 194 km²", 21, "Tokyo, the capital of Japan, is a bustling metropolis where tradition meets innovation. Visitors can explore the city's iconic landmarks such as the historic Senso-ji Temple in Asakusa, the futuristic skyscrapers of Shinjuku, and the serene gardens of the Imperial Palace. With its vibrant neighborhoods, bustling street markets, and world-renowned cuisine ranging from sushi to ramen, Tokyo offers a captivating blend of old-world charm and modern excitement for travelers to experience and enjoy.", "Tokyo", 37115035L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
