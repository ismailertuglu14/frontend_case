using System.ComponentModel.DataAnnotations;

namespace Shop.Core.DTOs.User
{
    public record struct SigninDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
