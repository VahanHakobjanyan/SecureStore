using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureStore.API.Data.Models;

namespace SecureStore.API.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasOne(c => c.User)
                .WithOne(u => u.Cart)
                .HasForeignKey<Cart>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Cart { Id = 1, UserId = 1 },
            new Cart { Id = 2, UserId = 2 },
            new Cart { Id = 3, UserId = 3 },
            new Cart { Id = 4, UserId = 4 },
            new Cart { Id = 5, UserId = 5 }
            );
        }
    }
}
