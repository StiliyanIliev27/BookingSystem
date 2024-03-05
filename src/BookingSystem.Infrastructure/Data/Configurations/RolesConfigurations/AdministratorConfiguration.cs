namespace BookingSystem.Infrastructure.Data.Configurations.RolesConfigurations
{
    using BookingSystem.Infrastructure.Data.DataSeeding;
    using BookingSystem.Infrastructure.Data.Models.Roles;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class AdministratorConfiguration : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            var data = new Seeder();

            builder
                .HasData(new Administrator[] { data.Administrator });
        }
    }
}
