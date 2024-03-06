namespace BookingSystem.Infrastructure.Data.Configurations.FlightConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
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

            var data = new Seeder();

            builder
                .HasData(new Flight[]
                {
                    data.SofiaParis,
                    data.SofiaIstanbul,
                    data.SofiaMadrid,
                    data.SofiaRome,
                    data.ParisSofia,
                    data.IstanbulSofia,
                    data.MadridSofia,
                    data.RomeSofia,
                    data.ParisIstanbul,
                    data.IstanbulParis,
                    data.ParisMadrid,
                    data.MadridParis,
                    data.ParisRome,
                    data.RomeParis,
                    data.IstanbulMadrid,
                    data.MadridIstanbul,
                    data.IstanbulRome,
                    data.RomeIstanbul
                });
        }
    }
}
