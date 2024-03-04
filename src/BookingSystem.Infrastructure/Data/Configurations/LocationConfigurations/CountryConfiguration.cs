namespace BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            throw new NotImplementedException();
        }
    }
}
