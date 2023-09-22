using System.ComponentModel.DataAnnotations;

namespace OgrenciTakipSistemi.WebMVC.Models.DTOs
{
    public class LoginDTO
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Alani girilmek Zorundadir")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Şifre  girilmek Zorundadir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool? RememberMe { get; set; } = true;
    }
}
