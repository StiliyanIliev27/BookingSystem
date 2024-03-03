using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    public partial class InitialDatabaseCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Airline's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Airline's Name"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Airline's Image URL"),
                    WebSiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Airline's WebSite URL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.Id);
                },
                comment: "Airline");

            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Continent's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Continent's Name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.Id);
                },
                comment: "Continent");

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Language's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Language's Name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                },
                comment: "Language");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Country's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Country's Name"),
                    Capital = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Country's Capital"),
                    Population = table.Column<long>(type: "bigint", nullable: false, comment: "Country's Population"),
                    Continent_Id = table.Column<int>(type: "int", nullable: false, comment: "Country's Continent's Identifier"),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Contry's Details"),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Country's Currency Code"),
                    FlagImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Country's Image Url")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Continents_Continent_Id",
                        column: x => x.Continent_Id,
                        principalTable: "Continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Country");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "City's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "City's Name"),
                    Population = table.Column<long>(type: "bigint", nullable: false, comment: "City's Population"),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "City's Area"),
                    Details = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "City's Details"),
                    Country_Id = table.Column<int>(type: "int", nullable: false, comment: "City's Country's Identifier"),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "City");

            migrationBuilder.CreateTable(
                name: "CountriesLanguages",
                columns: table => new
                {
                    Country_Id = table.Column<int>(type: "int", nullable: false, comment: "Country's Identifier"),
                    Language_Id = table.Column<int>(type: "int", nullable: false, comment: "Language's Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountriesLanguages", x => new { x.Country_Id, x.Language_Id });
                    table.ForeignKey(
                        name: "FK_CountriesLanguages_Countries_Country_Id",
                        column: x => x.Country_Id,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountriesLanguages_Languages_Language_Id",
                        column: x => x.Language_Id,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "CountryLanguage");

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Airport's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Airport's Name"),
                    City_Id = table.Column<int>(type: "int", nullable: false, comment: "Airport's City's Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airports_Cities_City_Id",
                        column: x => x.City_Id,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Airport");

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Hotel's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Hotel's Name"),
                    Address = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "Hotel's Address"),
                    City_Id = table.Column<int>(type: "int", nullable: false, comment: "Hotel's City's Identifier"),
                    StarRate = table.Column<int>(type: "int", maxLength: 5, nullable: false, comment: "Hotel's Star Rate"),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Hotel's Details"),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Hotel's Check In"),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Hotel's Check Out"),
                    Parking = table.Column<bool>(type: "bit", nullable: true, comment: "Hotel's Parking Availability"),
                    Pets = table.Column<bool>(type: "bit", nullable: true, comment: "Hotel's Pets Allowable"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Hotel's Active Status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Cities_City_Id",
                        column: x => x.City_Id,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Hotel");

            migrationBuilder.CreateTable(
                name: "Landmarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Landmark's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Landmark's Name"),
                    Address = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "Landmark's Address"),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Landmark's Details"),
                    City_Id = table.Column<int>(type: "int", nullable: false, comment: "Landmark's City's Identifier"),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Landmark's Ticket Price"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Landmark's active status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landmarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landmarks_Cities_City_Id",
                        column: x => x.City_Id,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Landmark");

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Flight's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Airline_Id = table.Column<int>(type: "int", nullable: false, comment: "Flight's Airline's Identifier"),
                    DepartureAirport_Id = table.Column<int>(type: "int", nullable: false, comment: "Flight's DepartureAirport's Identifier"),
                    ArrivalAirport_Id = table.Column<int>(type: "int", nullable: false, comment: "Flight's ArrivalAirport's Identifier"),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Flight's Departure Time"),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Flight's Arrival Time"),
                    FlightDuration = table.Column<int>(type: "int", nullable: false, comment: "Flight Duration in minutes"),
                    CabinClass = table.Column<int>(type: "int", nullable: false, comment: "Flight's Cabin Class"),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Flight's Ticket Price"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Flight's User's Identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Flight's Reservation Created Time"),
                    SeatNumber = table.Column<int>(type: "int", nullable: false, comment: "Flight's Seat Number Place"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Flight's Active Status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_Airlines_Airline_Id",
                        column: x => x.Airline_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flights_Airports_ArrivalAirport_Id",
                        column: x => x.ArrivalAirport_Id,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flights_Airports_DepartureAirport_Id",
                        column: x => x.DepartureAirport_Id,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flights_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Flight");

            migrationBuilder.CreateTable(
                name: "HotelsReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "HotelReservation's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "HotelReservation's Total Price"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's Start Date"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's End Date"),
                    Hotel_Id = table.Column<int>(type: "int", nullable: false, comment: "Room's Hotel's Identifier"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "HotelReservation's User's Identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "HotelReservation's CreatedOn Time"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "HotelReservation's Active Status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelsReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelsReservations_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelsReservations_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Hotel Reservation");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Room's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false, comment: "Room's Type"),
                    Hotel_Id = table.Column<int>(type: "int", nullable: false, comment: "Room's Hotel's Identifier"),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Room's Price Per Night"),
                    WiFi = table.Column<bool>(type: "bit", nullable: true, comment: "Room's Wi-Fi Availability"),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false, comment: "Room's Reservation Status"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Room's Active Status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Room");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_City_Id",
                table: "Airports",
                column: "City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Continent_Id",
                table: "Countries",
                column: "Continent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CountriesLanguages_Language_Id",
                table: "CountriesLanguages",
                column: "Language_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_Airline_Id",
                table: "Flights",
                column: "Airline_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ArrivalAirport_Id",
                table: "Flights",
                column: "ArrivalAirport_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DepartureAirport_Id",
                table: "Flights",
                column: "DepartureAirport_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_User_Id",
                table: "Flights",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_City_Id",
                table: "Hotels",
                column: "City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelsReservations_Hotel_Id",
                table: "HotelsReservations",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelsReservations_User_Id",
                table: "HotelsReservations",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Landmarks_City_Id",
                table: "Landmarks",
                column: "City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Hotel_Id",
                table: "Rooms",
                column: "Hotel_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountriesLanguages");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "HotelsReservations");

            migrationBuilder.DropTable(
                name: "Landmarks");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Airlines");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Continents");
        }
    }
}
