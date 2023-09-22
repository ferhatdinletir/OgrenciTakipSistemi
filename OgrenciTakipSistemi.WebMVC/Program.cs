using Microsoft.AspNetCore.Identity;
using OgrenciTakipSistemi.DAL.Contexts;
using OgrenciTakipSistemi.Entities.Authentication;

namespace OgrenciTakipSistemi.WebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           // var connectionString = builder.Configuration.GetConnectionString("Ogrenci Takip Sistemi");

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

            app.UseAuthentication();

            #region AdminArea Controller Route
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
            #endregion
        }
    }
}