namespace BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            var data = new Seeder();

            builder.HasData(new City[]
            {
                data.Paris,
                data.Madrid,
                data.NewYork,
                data.Istanbul,
                data.Rome,
                data.Sofia,
                data.Tokyo
            });
        }
    }
}
