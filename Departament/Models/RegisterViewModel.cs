using System.ComponentModel.DataAnnotations;

namespace Departament.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password don't mutch")]
        [DataType(DataType.Password)]
        [Display(Name = "Password don't mutch")]
        public string PasswordConfirm { get; set; }
    }
}
