namespace BookingSystem.Infrastructure.Data.Configurations.LocationConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using BookingSystem.Infrastructure.Data.Models.Location;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            var data = new Seeder();

            builder.HasData(new Country[]
            {
                data.France,
                data.Spain,
                data.UnitedStates,
                data.Turkey,
                data.Italy,
                data.Mexico,
                data.England,
                data.Germany,
                data.Greece,
                data.Austria,
                data.Bulgaria,
                data.Russia,
                data.Serbia,
                data.Hungary,
                data.Romania,
                data.China,
                data.India,
                data.UnitedArabEmirates,
                data.Egypt,
                data.Brazil,
                data.Japan
            });
        }
    }
}
