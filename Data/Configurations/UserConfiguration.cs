using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureStore.API.Data.Models;

namespace SecureStore.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, UserName = "Alice", Email = "alice.smith@securestore.com", Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f" },
                new User { Id = 2, UserName = "Bob", Email = "bob.jones@securestore.com", Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f" },
                new User { Id = 3, UserName = "Charlie", Email = "charlie.brown@securestore.com", Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f" },
                new User { Id = 4, UserName = "Diana", Email = "diana.green@securestore.com", Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f" },
                new User { Id = 5, UserName = "Eva", Email = "eva.white@securestore.com", Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f" }
                );
        }
    }
}
