using System.ComponentModel.DataAnnotations;

namespace OgrenciTakipSistemi.WebMVC.Models.DTOs
{
    public class GirisDTO
    {
         
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Gir!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Paralonı Gir!")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public bool RememberMe { get; set; }
    }
}

