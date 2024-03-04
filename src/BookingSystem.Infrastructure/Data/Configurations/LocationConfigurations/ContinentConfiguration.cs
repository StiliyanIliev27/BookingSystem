namespace BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class ContinentConfiguration : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            throw new NotImplementedException();
        }
    }
}
