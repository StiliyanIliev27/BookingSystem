namespace BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            throw new NotImplementedException();
        }
    }
}
