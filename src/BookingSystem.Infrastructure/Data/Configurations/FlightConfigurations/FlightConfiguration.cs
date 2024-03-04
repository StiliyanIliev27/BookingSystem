namespace BookingSystem.Infrastructure.Data.Configurations.FlightConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder
                .Property(r => r.TicketPrice)
                .HasPrecision(18, 2);
        }
    }
}
