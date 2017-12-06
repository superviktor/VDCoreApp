using System.ComponentModel.DataAnnotations;

namespace VD.Models.Authorization
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Email field is empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password field is empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password is incorrect")]
        public string ConfirmPassword { get; set; }
    }
}
