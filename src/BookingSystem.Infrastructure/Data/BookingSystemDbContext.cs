namespace BookingSystem.Infrastructure.Data
{
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
    }
}
