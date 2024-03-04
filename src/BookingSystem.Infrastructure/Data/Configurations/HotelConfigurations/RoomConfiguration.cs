namespace BookingSystem.Infrastructure.Data.Configurations.HotelConfigurations
{
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
        }
    }
}
