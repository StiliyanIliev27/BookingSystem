namespace BookingSystem.Infrastructure.Data.Configurations.HotelConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder
                .Property(r => r.PricePerNight)
                .HasPrecision(18, 2);

            var data = new Seeder();

            builder
                .HasData(new Room[]
                {
                    data.IbisParisRoomSingle,
                    data.IbisParisRoomDouble,
                    data.IbisParisRoomTriple,
                    data.IbisParisRoomApartment,
                    data.KraftHotelRoomSingle,
                    data.KraftHotelRoomDouble,
                    data.SaintMarcelRoomSingle,
                    data.SaintMarcelRoomDouble,
                    data.PestanaPlazaRoomSingle,
                    data.PestanaPlazaRoomDouble,
                    data.PestanaPlazaRoomTriple,
                    data.CataloniaPuertaRoomSingle,
                    data.CataloniaPuertaRoomDouble,
                    data.HostalCentralPalaceRoomDouble,
                    data.TimesSquareHotelRoomDouble,
                    data.TimesSquareHotelRoomTriple,
                    data.HiltonGardenRoomDouble,
                    data.HiltonGardenRoomTriple,
                    data.HiltonGardenRoomApartment,
                    data.PrinceKitanoRoomDouble,
                    data.PrinceKitanoRoomApartment,
                    data.HotelZOORoomSingle,
                    data.HotelZOORoomDouble,
                    data.HotelZOORoomTriple,
                    data.EurostarsSofiaRoomSingle,
                    data.EurostarsSofiaRoomDouble,
                    data.EurostarsSofiaRoomTriple,
                    data.EurostarsSofiaRoomApartment,
                    data.PremierSofiaRoomSingle,
                    data.PremierSofiaRoomDouble,
                    data.PremierSofiaRoomTriple,
                    data.EminPalaceRoomSingle,
                    data.EminPalaceRoomDouble, 
                    data.EminPalaceRoomTriple,
                    data.HotelZurichRoomSingle,
                    data.HotelZurichRoomDouble,
                    data.HotelZurichRoomTriple,
                    data.HotelZurichRoomApartment,
                    data.FlorinaHotelRoomSingle,
                    data.FlorinaHotelRoomDouble,
                    data.FlorinaHotelRoomTriple,
                    data.FlorinaHotelRoomApartment,
                    data.LoisirHotelRoomSingle,
                    data.LoisirHotelRoomDouble,
                    data.OakwoodPremierRoomSingle,
                    data.OakwoodPremierRoomDouble,
                    data.OakwoodPremierRoomApartment
                });
        }
    }
}
