using System;
using System.ComponentModel.DataAnnotations;

namespace ShoppingWebApp.ViewModels
{
    public class LoginModel
    {
        [Required]
        [UIHint("email")]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }
    }
}
