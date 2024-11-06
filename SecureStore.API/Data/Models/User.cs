using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public User(string _username, string email, string password) 
        {
            UserName = _username;
            Email = email;
            Password = password;
        }

        public User() { }

        public List<Role> Roles { get; set; }
        public List<Order> Orders { get; set; }
        public Cart Cart { get; set; }
    }
}
