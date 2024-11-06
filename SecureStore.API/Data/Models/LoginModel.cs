using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public LoginModel(string email, string password) 
        {
            Email = email;
            Password = password;
        }
    }
}
