namespace SecureStore.Data.DTOs
{
    public class RegisterModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
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
