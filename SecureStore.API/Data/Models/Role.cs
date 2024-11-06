using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required]
        public string Description { get; set; }

        public Role(string rolename, string description, int roleid)
        {
            RoleName = rolename;
            Description = description;
            RoleId = roleid;
        }

        public Role() { }
    }
}
