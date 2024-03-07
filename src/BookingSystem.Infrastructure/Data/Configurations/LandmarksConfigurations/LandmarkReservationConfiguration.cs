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
                .HasKey(lr => new {lr.Landmark_Id, lr.User_Id});
        }
    }
}
