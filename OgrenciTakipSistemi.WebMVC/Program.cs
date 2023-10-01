using Microsoft.EntityFrameworkCore;
using OgrenciTakipSistemi.DAL.Contexts;
using OgrenciTakipSistemi.WebMVC.Extensions;
using OgrenciTakipSistemi.WebMVC.AutoMapperProfile;
using Microsoft.AspNetCore.Identity;
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

            builder.Services.AddDbContext<SqlDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("OgrenciTakipSistemi")));

            #region Identity Configuration
            builder.Services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredLength = 3;

                options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.SignIn.RequireConfirmedAccount = false;
            }).AddEntityFrameworkStores<SqlDbContext>()
                .AddDefaultTokenProviders();
            #endregion

            builder.Services.OgrenciTakipSistemiService();

            #region AutoMapper
            builder.Services.AddAutoMapper(typeof(OgrenciTakipSistemiProfile));
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

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

            #region Map Controller Route
            app.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
            #endregion

            app.Run();
        }
    }
}