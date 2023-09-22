using OgrenciTakipSistemi.Business.Abstract;
using OgrenciTakipSistemi.Business.Concrete;
using OgrenciTakipSistemi.DAL.Abstract;
using OgrenciTakipSistemi.DAL.Concrete;
using NuGet.Protocol.Plugins;

namespace MyDukkan.WebUI.Extensions
{
    public static class AddOgrenciTakipSistemiService
    {

        public static IServiceCollection AddMyDukkanServices (this IServiceCollection services)
        {
            services.AddScoped<IDanismanManager, DanismanManager>();
            services.AddScoped<IDanismanRepository, DanismanRepository>();


            services.AddScoped<IOgrenciManager, OgrenciManager>();
            services.AddScoped<IOgrenciRepository, OgrenciRepository>();

            services.AddScoped<IBolumManager, BolumManager>();
            services.AddScoped<IBolumRepository, BolumRepository>();


            services.AddScoped<IBransManager, BransManager>();
            services.AddScoped<IBransRepository, BransRepository>();


            return services;
        }

        public static string TurkceKarakterDuzelt(this string str, string v)
        {
            str = str.Replace('ş', 's');
            return str;
        }
    }
}
