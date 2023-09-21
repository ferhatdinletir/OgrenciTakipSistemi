using System.ComponentModel.DataAnnotations;

namespace OgrenciTakipSistemi.WebMVC.Models.DTOs
{
    public class KullaniciDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Girmek Zorundadir!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen Doğru E-Posta Formatıyla Giriniz")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Sifre  girilmek Zorundadir!")]
        [DataType(DataType.Password, ErrorMessage = "Lütfen Doğru Şifre Formatıyla Girininiz")]
        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}
