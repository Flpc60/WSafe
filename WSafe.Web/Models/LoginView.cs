using System.ComponentModel.DataAnnotations;

namespace WSafe.Web.Models
{
    public class LoginView
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        public bool Rememberme { get; set; }

    }
}
