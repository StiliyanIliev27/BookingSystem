namespace BookingSystem.Infrastructure.Data.Configurations.RolesConfigurations
{

    using BookingSystem.Infrastructure.Data.Models.Roles;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class AdministratorConfiguration : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            throw new NotImplementedException();
        }
    }
}
