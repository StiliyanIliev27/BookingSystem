namespace BookingSystem.Infrastructure.Data.Configurations.HotelConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            var data = new Seeder();

            builder
                .HasData(new Hotel[]
                {
                    data.IbisParis,
                    data.SaintMarcel,
                    data.KraftHotel,
                    data.PestanaPlaza,
                    data.CataloniaPuerta,
                    data.HostalCentralPalace,
                    data.PrinceKitano,
                    data.HiltonGarden,
                    data.TimesSquareHotel,
                    data.HotelZOO,
                    data.EurostarsSofia,
                    data.PremierSofia
                });
        }
    }
}
