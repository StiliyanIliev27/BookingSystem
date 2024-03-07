namespace BookingSystem.Infrastructure.Data
{
    using BookingSystem.Infrastructure.Data.Configurations.FlightConfigurations;
    using BookingSystem.Infrastructure.Data.Configurations.HotelConfigurations;
    using BookingSystem.Infrastructure.Data.Configurations.LandmarkConfigurations;
    using BookingSystem.Infrastructure.Data.Configurations.LandmarksConfigurations;
    using BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations;
    using BookingSystem.Infrastructure.Data.Configurations.RolesConfigurations;
    using BookingSystem.Infrastructure.Data.Configurations.UsersConfigurations;
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using BookingSystem.Infrastructure.Data.Models.Landmarks;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using BookingSystem.Infrastructure.Data.Models.Roles;
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
        /// Cities
        /// </summary>
        public DbSet<City> Cities { get; set; } = null!;

        /// <summary>
        /// Landmarks
        /// </summary>
        public DbSet<Landmark> Landmarks { get; set; } = null!;

        /// <summary>
        /// LandmarksReservations
        /// </summary>
        public DbSet<LandmarkReservation> LandmarksReservations { get; set; } = null!;

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

        /// <summary>
        /// FlightsReservations
        /// </summary>
        public DbSet<FlightReservation> FlightsReservations { get; set; } = null!;

        /// <summary>
        /// Administrators
        /// </summary>
        public DbSet<Administrator> Administrators { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Locations configuration
            builder.ApplyConfiguration(new ContinentConfiguration());
            builder.ApplyConfiguration(new LanguageConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());   
            builder.ApplyConfiguration(new CityConfiguration());

            //Landmarks configuration
            builder.ApplyConfiguration(new LandmarkConfiguration());
            builder.ApplyConfiguration(new LandmarkReservationConfiguration());

            //Hotels configuration
            builder.ApplyConfiguration(new HotelConfiguration());
            builder.ApplyConfiguration(new RoomConfiguration());
            builder.ApplyConfiguration(new HotelReservationConfiguration());


            //Flights configuration
            builder.ApplyConfiguration(new FlightConfiguration());
            builder.ApplyConfiguration(new AirlineConfiguration());
            builder.ApplyConfiguration(new AirportConfiguration());
            builder.ApplyConfiguration(new FlightReservationConfiguration());

            //Roles configuration
            builder.ApplyConfiguration(new AdministratorConfiguration());

            //Users configuration
            builder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
