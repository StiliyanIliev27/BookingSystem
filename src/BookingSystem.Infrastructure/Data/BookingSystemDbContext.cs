namespace BookingSystem.Infrastructure.Data
{
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using BookingSystem.Infrastructure.Data.Models.Landmarks;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Context of the database
    /// </summary>
    public class BookingSystemDbContext : IdentityDbContext
    {
        /// <summary>
        /// Constructor of the context of the database
        /// </summary>
        /// <param name="options">Connection options</param>
        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Continents
        /// </summary>
        public DbSet<Continent> Continents { get; set; } = null!;

        /// <summary>
        /// Countries
        /// </summary>
        public DbSet<Country> Countries { get; set; } = null!;

        /// <summary>
        /// Languages
        /// </summary>
        public DbSet<Language> Languages { get; set; } = null!;

        /// <summary>
        /// CountriesLanguages
        /// </summary>
        public DbSet<CountryLanguage> CountriesLanguages { get; set; } = null!;
       
        /// <summary>
        /// Cities
        /// </summary>
        public DbSet<City> Cities { get; set; } = null!;

        /// <summary>
        /// Landmarks
        /// </summary>
        public DbSet<Landmark> Landmarks { get; set; } = null!;

        /// <summary>
        /// Hotels
        /// </summary>
        public DbSet<Hotel> Hotels { get; set; } = null!;

        /// <summary>
        /// Rooms
        /// </summary>
        public DbSet<Room> Rooms { get; set; } = null!;

        /// <summary>
        /// HotelsReservations
        /// </summary>
        public DbSet<HotelReservation> HotelsReservations { get; set; } = null!;
        
        /// <summary>
        /// Airlines
        /// </summary>
        public DbSet<Airline> Airlines { get; set; } = null!;

        /// <summary>
        /// Aiports
        /// </summary>
        public DbSet<Airport> Airports { get; set; } = null!;

        /// <summary>
        /// Flights
        /// </summary>
        public DbSet<Flight> Flights { get; set; } = null!;
    }
}
