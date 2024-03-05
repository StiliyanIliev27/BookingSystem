namespace BookingSystem.Infrastructure.Data.Configurations.UsersConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var data = new Seeder();

            builder
                .HasData(new IdentityUser[]
                {
                    data.GuestUser,
                    data.AdministratorUser
                });
        }
    }
}
