using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace OgrenciTakipSistemi.WebMVC.Models.DTOs
{
    public class UserCreateDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ad Alani Zorunludur")]
        public string Ad { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Soyad Alani Zorunludur")]
        public string Soyad { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Alani Zorunludur")]

        [DataType(DataType.EmailAddress, ErrorMessage = "Duzgun Mail adresi Giriniz")]
        public string? Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "TCNO Alani Zorunludur")]
        [MaxLength(11, ErrorMessage = "TcNo 11 Karakterden fazla Olmamalidir")]
        [MinLength(11, ErrorMessage = "TcNo 11 Karakterden az Olmamalidir")]

        public string? TcNO { get; set; }

        // public bool? Cinsiyet { get; set; }


       // public IEnumerable<SelectListItem>? Sehirler { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gsm Alani Zorunludur")]
        public string? Gsm { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Alani Zorunludur")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "RePassword Alani Zorunludur")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "Şifreler Uyuşmadi")]
        // public string Repassword { get; set; }
    }
}
