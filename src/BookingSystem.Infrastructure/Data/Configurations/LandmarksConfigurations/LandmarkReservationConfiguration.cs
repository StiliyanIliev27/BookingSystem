namespace BookingSystem.Infrastructure.Data.Configurations.LandmarksConfigurations
{
    using BookingSystem.Infrastructure.Data.Models.Landmarks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class LandmarkReservationConfiguration : IEntityTypeConfiguration<LandmarkReservation>
    {
        public void Configure(EntityTypeBuilder<LandmarkReservation> builder)
        {
            builder
                .Property(lr => lr.TotalPrice)
                .HasPrecision(18, 2);
        }
    }
}
