namespace BookingSystem.Infrastructure.Data.Configurations.FlightConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class AirlineConfiguration : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            var data = new Seeder();

            builder
                .HasData(new Airline[]
                {
                    data.BulgariaAir,
                    data.TurkishAirlines,
                    data.Lufthansa,
                    data.WizzAir,
                    data.Ryanair
                });
        }
    }
}
