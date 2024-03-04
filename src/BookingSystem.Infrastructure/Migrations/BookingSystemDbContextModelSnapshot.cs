﻿// <auto-generated />
using System;
using BookingSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingSystem.Infrastructure.Migrations
{
    [DbContext(typeof(BookingSystemDbContext))]
    partial class BookingSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Flights.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Airline's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Airline's Image URL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Airline's Name");

                    b.Property<string>("WebSiteUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Airline's WebSite URL");

                    b.HasKey("Id");

                    b.ToTable("Airlines");

                    b.HasComment("Airline");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Flights.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Airport's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("City_Id")
                        .HasColumnType("int")
                        .HasComment("Airport's City's Identifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Airport's Name");

                    b.HasKey("Id");

                    b.HasIndex("City_Id");

                    b.ToTable("Airports");

                    b.HasComment("Airport");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Flights.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Flight's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Airline_Id")
                        .HasColumnType("int")
                        .HasComment("Flight's Airline's Identifier");

                    b.Property<int>("ArrivalAirport_Id")
                        .HasColumnType("int")
                        .HasComment("Flight's ArrivalAirport's Identifier");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2")
                        .HasComment("Flight's Arrival Time");

                    b.Property<int>("CabinClass")
                        .HasColumnType("int")
                        .HasComment("Flight's Cabin Class");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Flight's Reservation Created Time");

                    b.Property<int>("DepartureAirport_Id")
                        .HasColumnType("int")
                        .HasComment("Flight's DepartureAirport's Identifier");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2")
                        .HasComment("Flight's Departure Time");

                    b.Property<int>("FlightDuration")
                        .HasColumnType("int")
                        .HasComment("Flight Duration in minutes");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Flight's Active Status");

                    b.Property<decimal>("TicketPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Flight's Ticket Price");

                    b.HasKey("Id");

                    b.HasIndex("Airline_Id");

                    b.HasIndex("ArrivalAirport_Id");

                    b.HasIndex("DepartureAirport_Id");

                    b.ToTable("Flights");

                    b.HasComment("Flight");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Flights.FlightReservation", b =>
                {
                    b.Property<int>("Flight_Id")
                        .HasColumnType("int")
                        .HasComment("Flight's Identifier");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User's Identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Flight's Reservation Creation Time");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Flight's Reservation Active Status");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int")
                        .HasComment("Flight's Reseravation's Seat Number");

                    b.HasKey("Flight_Id", "User_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("FlightsReservations");

                    b.HasComment("FlightReservations");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Hotels.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Hotel's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasComment("Hotel's Address");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2")
                        .HasComment("Hotel's Check In");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2")
                        .HasComment("Hotel's Check Out");

                    b.Property<int>("City_Id")
                        .HasColumnType("int")
                        .HasComment("Hotel's City's Identifier");

                    b.Property<string>("Details")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Hotel's Details");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Hotel's Active Status");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Hotel's Name");

                    b.Property<bool?>("Parking")
                        .HasColumnType("bit")
                        .HasComment("Hotel's Parking Availability");

                    b.Property<bool?>("Pets")
                        .HasColumnType("bit")
                        .HasComment("Hotel's Pets Allowable");

                    b.Property<int>("StarRate")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasComment("Hotel's Star Rate");

                    b.HasKey("Id");

                    b.HasIndex("City_Id");

                    b.ToTable("Hotels");

                    b.HasComment("Hotel");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Hotels.HotelReservation", b =>
                {
                    b.Property<int>("Hotel_Id")
                        .HasColumnType("int")
                        .HasComment("Room's Hotel's Identifier");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("HotelReservation's User's Identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("HotelReservation's CreatedOn Time");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasComment("HotelReservation's End Date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("HotelReservation's Active Status");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("HotelReservation's Total Price");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasComment("HotelReservation's Start Date");

                    b.HasKey("Hotel_Id", "User_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("HotelsReservations");

                    b.HasComment("Hotel Reservation");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Hotels.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Room's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Hotel_Id")
                        .HasColumnType("int")
                        .HasComment("Room's Hotel's Identifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Room's Active Status");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit")
                        .HasComment("Room's Reservation Status");

                    b.Property<decimal>("PricePerNight")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Room's Price Per Night");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasComment("Room's Type");

                    b.Property<bool?>("WiFi")
                        .HasColumnType("bit")
                        .HasComment("Room's Wi-Fi Availability");

                    b.HasKey("Id");

                    b.HasIndex("Hotel_Id");

                    b.ToTable("Rooms");

                    b.HasComment("Room");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Landmarks.Landmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Landmark's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasComment("Landmark's Address");

                    b.Property<int>("City_Id")
                        .HasColumnType("int")
                        .HasComment("Landmark's City's Identifier");

                    b.Property<string>("Details")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Landmark's Details");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Landmark's active status");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Landmark's Name");

                    b.Property<decimal>("TicketPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Landmark's Ticket Price");

                    b.HasKey("Id");

                    b.HasIndex("City_Id");

                    b.ToTable("Landmarks");

                    b.HasComment("Landmark");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Location.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("City's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("City's Area");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("Country_Id")
                        .HasColumnType("int")
                        .HasComment("City's Country's Identifier");

                    b.Property<string>("Details")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("City's Details");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("City's Name");

                    b.Property<long>("Population")
                        .HasColumnType("bigint")
                        .HasComment("City's Population");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasComment("City");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Location.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Continent's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Continent's Name");

                    b.HasKey("Id");

                    b.ToTable("Continents");

                    b.HasComment("Continent");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Location.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Country's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Capital")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Country's Capital");

                    b.Property<int>("Continent_Id")
                        .HasColumnType("int")
                        .HasComment("Country's Continent's Identifier");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Country's Currency Code");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Contry's Details");

                    b.Property<string>("FlagImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Country's Image Url");

                    b.Property<int>("Language_Id")
                        .HasColumnType("int")
                        .HasComment("Country's Official Language Identifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Country's Name");

                    b.Property<long>("Population")
                        .HasColumnType("bigint")
                        .HasComment("Country's Population");

                    b.HasKey("Id");

                    b.HasIndex("Continent_Id");

                    b.HasIndex("Language_Id");

                    b.ToTable("Countries");

                    b.HasComment("Country");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Location.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Language's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Language's Name");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasComment("Language");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Roles.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Administrator's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User's Identifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Flights.Airport", b =>
                {
                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Location.City", "City")
                        .WithMany()
                        .HasForeignKey("City_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Flights.Flight", b =>
                {
                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Flights.Airline", "Airline")
                        .WithMany()
                        .HasForeignKey("Airline_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Flights.Airport", "ArrivalAirport")
                        .WithMany()
                        .HasForeignKey("ArrivalAirport_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Flights.Airport", "DepartureAirport")
                        .WithMany()
                        .HasForeignKey("DepartureAirport_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airline");

                    b.Navigation("ArrivalAirport");

                    b.Navigation("DepartureAirport");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Flights.FlightReservation", b =>
                {
                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Flights.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("Flight_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Hotels.Hotel", b =>
                {
                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Location.City", "City")
                        .WithMany()
                        .HasForeignKey("City_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Hotels.HotelReservation", b =>
                {
                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Hotels.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("Hotel_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Hotels.Room", b =>
                {
                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Hotels.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("Hotel_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Landmarks.Landmark", b =>
                {
                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Location.City", "City")
                        .WithMany()
                        .HasForeignKey("City_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Location.City", b =>
                {
                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Location.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Location.Country", b =>
                {
                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Location.Continent", "Continent")
                        .WithMany()
                        .HasForeignKey("Continent_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingSystem.Infrastructure.Data.Models.Location.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Language_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Continent");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("BookingSystem.Infrastructure.Data.Models.Roles.Administrator", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
