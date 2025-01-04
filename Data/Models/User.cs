namespace SecureStore.API.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<UserRole> UserRoles { get; set; }
        public List<Order> Orders { get; set; }
        public Cart Cart { get; set; }

        public User(string username, string email, string password)
        {
            UserName = username;
            Email = email;
            Password = password;
        }

        public User() { }
    }
}
