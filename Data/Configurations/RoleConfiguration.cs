using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureStore.API.Data.Models;

namespace SecureStore.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role { Id = 1, RoleName = "Admin", Description = "Administrator with full privileges" },
                new Role { Id = 2, RoleName = "User", Description = "Regular user with limited privileges" }
                );
        }
    }
}
