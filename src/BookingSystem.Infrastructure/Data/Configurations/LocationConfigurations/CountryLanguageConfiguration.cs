namespace BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class CountryLanguageConfiguration : IEntityTypeConfiguration<CountryLanguage>
    {
        public void Configure(EntityTypeBuilder<CountryLanguage> builder)
        {
            builder
                .HasKey(cl => new { cl.Country_Id, cl.Language_Id });
        }
    }
}
