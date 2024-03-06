namespace BookingSystem.Infrastructure.Data.Configurations.FlightConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class AirportConfiguration : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            var data = new Seeder();

            builder
                .HasData(new Airport[]
                {
                    data.IstanbulAirport,
                    data.ParisAirport,
                    data.NewYorkAirport,
                    data.SofiaAirport,
                    data.RomeAirport,
                    data.TokyoAirport,
                    data.MadridAirport,
                });
        }
    }
}
