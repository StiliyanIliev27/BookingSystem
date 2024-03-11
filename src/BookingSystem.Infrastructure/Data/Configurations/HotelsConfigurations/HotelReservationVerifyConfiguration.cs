using BookingSystem.Infrastructure.Data.Models.Hotels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingSystem.Infrastructure.Data.Configurations.HotelsConfigurations
{
    internal class HotelReservationVerifyConfiguration : IEntityTypeConfiguration<HotelReservationVerify>
    {
        public void Configure(EntityTypeBuilder<HotelReservationVerify> builder)
        {
            builder
                .HasKey(hr => new { hr.Hotel_Id, hr.User_Id });

            builder
                .Property(r => r.Price)
                .HasPrecision(18, 2);
        }
    }
}
