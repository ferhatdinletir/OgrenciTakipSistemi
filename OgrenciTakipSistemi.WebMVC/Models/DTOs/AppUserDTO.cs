using System.ComponentModel.DataAnnotations;

namespace OgrenciTakipSistemi.WebMVC.Models.DTOs
{
    public class AppUserDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Email!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please Enter Correct Email Format")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Password!")]
        [DataType(DataType.Password, ErrorMessage = "Please Enter Correct Password Format")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}

