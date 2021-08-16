using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Departament.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
