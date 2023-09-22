using System.ComponentModel.DataAnnotations;

namespace OgrenciTakipSistemi.WebMVC.Areas.AdminArea.Models.DTOs
{
    public class LoginDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public bool RememberMe { get; set; }
    }
}
