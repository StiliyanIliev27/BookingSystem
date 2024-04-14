namespace Microsoft.Extensions.DependencyInjection
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.User;
    using BookingSystem.Core.Services;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<ICityService, CityService>();    
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ILandmarkService, LandmarkService>();
            services.AddScoped<IFlightService, FlightService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<BookingSystemDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddScoped<IRepository, Repository>();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<BookingSystemDbContext>();

            return services;
        }
    }
}
