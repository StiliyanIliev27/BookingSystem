namespace BookingSystem.Infrastructure.Data.Configurations.HotelConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class HotelReservationConfiguration : IEntityTypeConfiguration<HotelReservation>
    {
        public void Configure(EntityTypeBuilder<HotelReservation> builder)
        {
            builder
                .Property(r => r.Price)
                .HasPrecision(18, 2);
        }
    }
}
