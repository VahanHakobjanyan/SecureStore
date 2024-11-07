using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class RegisterModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public RegisterModel(string username, string email, string password) 
        {
            Username = username;
            Email = email;
            Password = password;
        }

        public RegisterModel() { }
    }
}
