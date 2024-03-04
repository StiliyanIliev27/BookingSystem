namespace BookingSystem.Infrastructure.Data.Configurations.LandmarkConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Landmarks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class LandmarkConfiguration : IEntityTypeConfiguration<Landmark>
    {
        public void Configure(EntityTypeBuilder<Landmark> builder)
        {
            builder
                .Property(r => r.TicketPrice)
                .HasPrecision(18, 2);
        }
    }
}
