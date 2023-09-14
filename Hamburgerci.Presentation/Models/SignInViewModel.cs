using System.ComponentModel.DataAnnotations;

namespace Hamburgerci.Presentation.Models
{
    public class SignInViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
