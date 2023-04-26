using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password Required")]
        [MinLength(9,ErrorMessage ="Password Must have 9 charater")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password Not Matched")]
        public string ConfirmPassword { get; set; }

        
    }
}
