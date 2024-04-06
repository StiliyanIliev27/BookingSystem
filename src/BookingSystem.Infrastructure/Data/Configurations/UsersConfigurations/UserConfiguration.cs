namespace BookingSystem.Infrastructure.Data.Configurations.UsersConfigurations
{
    using BookingSystem.Core.Models.User;
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var data = new Seeder();

            builder
                .HasData(new ApplicationUser[]
                {
                    data.GuestUser,
                    data.AdminUser
                });
        }
    }
}
