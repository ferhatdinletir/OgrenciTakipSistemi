﻿using OgrenciTakipSistemi.Business.Abstract;
using OgrenciTakipSistemi.Business.Concrete;
using OgrenciTakipSistemi.DAL.Abstract;
using OgrenciTakipSistemi.DAL.Concrete;
using NuGet.Protocol.Plugins;

namespace OgrenciTakipSistemi.WebUI.Extensions
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

        public static string TurkceKarakterDuzelt(this string str)
        {
            List<char> listTR = new() { 'ı', 'İ', 'ğ', 'Ğ', 'ü', 'Ü', 'ş', 'Ş', 'ö', 'Ö', 'ç', 'Ç' };
            List<char> listEN = new() { 'i', 'I', 'g', 'G', 'u', 'U', 's', 'S', 'o', 'O', 'c', 'C' };
            for (int i = 0; i < listTR.Count; i++)
            {
                str = str.Replace(listTR[i], listEN[i]);
            }
            return str;
        }
    }
}