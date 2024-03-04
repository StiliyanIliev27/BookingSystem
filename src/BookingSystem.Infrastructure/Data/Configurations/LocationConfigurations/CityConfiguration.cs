namespace BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            throw new NotImplementedException();
        }
    }
}
