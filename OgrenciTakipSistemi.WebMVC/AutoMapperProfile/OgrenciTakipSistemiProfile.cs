using AutoMapper;
using OgrenciTakipSistemi.Entities.Authentication;
using OgrenciTakipSistemi.Entities.Concrete;
using OgrenciTakipSistemi.WebMVC.Models.DTOs;

namespace OgrenciTakipSistemi.WebMVC.AutoMapperProfile
{
    public class OgrenciTakipSistemiProfile:Profile
    {
        public OgrenciTakipSistemiProfile()
        {
            CreateMap<GirisDTO, AppUser>();
            CreateMap<KayitDTO, AppUser>();
        }
    }
}
