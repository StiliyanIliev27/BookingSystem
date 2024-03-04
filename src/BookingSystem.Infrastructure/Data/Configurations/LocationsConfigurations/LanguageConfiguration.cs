namespace BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            var data = new Seeder();

            builder.HasData(new Language[]
            {
                data.Chinese,
                data.Spanish,
                data.English,
                data.German,
                data.Arabic,
                data.Hindi,
                data.Portuguese,
                data.Russian,
                data.Bulgarian,
                data.Greek,
                data.Japanese,
                data.French,
                data.Turkish,
                data.Serbian,
                data.Italian,
                data.Korean,
                data.Romanian,
                data.Hungarian
            });
        }
    }
}
