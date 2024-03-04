namespace BookingSystem.Infrastructure.Data.Configurations.FlightConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class FlightReservationConfiguration : IEntityTypeConfiguration<FlightReservation>
    {
        public void Configure(EntityTypeBuilder<FlightReservation> builder)
        {
            builder
                .HasKey(fr => new { fr.Flight_Id, fr.User_Id });
        }
    }
}
