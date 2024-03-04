namespace BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class ContinentConfiguration : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            var data = new Seeder();

            builder.HasData(new Continent[]
            {
                data.Asia,
                data.Africa,
                data.NorthAmerica,
                data.SouthAmerica,
                data.Antarctica,
                data.Europe,
                data.Australia
            });
        }
    }
}
