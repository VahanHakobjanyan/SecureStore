namespace SecureStore.API.Data.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}
