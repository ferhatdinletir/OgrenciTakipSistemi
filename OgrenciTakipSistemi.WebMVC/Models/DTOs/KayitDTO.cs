using System.ComponentModel.DataAnnotations;

namespace OgrenciTakipSistemi.WebMVC.Models.DTOs
{
    public class KayitDTO
    {
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter RePassword!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords Do Not Match")]
        public string RePassword { get; set; }
        //-----------------------------------------------------------------------
    }
}
