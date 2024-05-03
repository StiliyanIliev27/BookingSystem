namespace BookingSystem
{
    using Microsoft.AspNetCore.Mvc;
    using BookingSystem.ModelBinders;
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);                    

            builder.Services.AddApplicationDbContext(builder.Configuration);
            builder.Services.AddApplicationIdentity(builder.Configuration);

            builder.Services.AddControllersWithViews(options =>
            {
                options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
            });

            builder.Services.AddApplicationServices();
            builder.Services.AddMemoryCache();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error/500");
                app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.EnableOnlineUsersCheck();
            app.RemoveExpiredReservatios();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Hotel Details",
                    pattern: "/Hotel/Details/{id}/{information}",
                    defaults: new { Controller = "Hotel", Action = "Details"}
                    );

                endpoints.MapControllerRoute(
                    name: "Flight Details",
                    pattern: "/Flight/Details/{id}/{information}",
                    defaults: new { Controller = "Flight", Action = "Details" }
                    );

                endpoints.MapControllerRoute(
                    name: "Landmark Details",
                    pattern: "/Landmark/Details/{id}/{information}",
                    defaults: new { Controller = "Landmark", Action = "Details" }
                    );

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });

            await app.CreateAdminRoleAsync();

            await app.RunAsync();
        }
    }
}