using System.ComponentModel.DataAnnotations;

namespace AutomotiveApp.BlazorUI.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Email Wajib")]
        [EmailAddress(ErrorMessage = "Harus Email Valid")]
        [MinLength(6, ErrorMessage = "Minimal 6 karakter")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password Wajib")]
        public string Password { get; set; } = string.Empty;
    }
}
