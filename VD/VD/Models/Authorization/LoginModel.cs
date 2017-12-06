using System.ComponentModel.DataAnnotations;

namespace VD.Models.Authorization
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
