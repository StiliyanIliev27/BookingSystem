namespace BookingSystem.Infrastructure.Data.Configurations.HotelConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
