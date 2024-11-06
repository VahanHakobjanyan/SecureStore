using Microsoft.EntityFrameworkCore;
using SecureStore.API.Data.Models;

namespace SecureStore.API.Data
{
    public class SecureStoreApiDbContext : DbContext
    {
        public SecureStoreApiDbContext(DbContextOptions<SecureStoreApiDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithOne(u => u.Cart)
                .HasForeignKey<Cart>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Configure cascading delete (optional)

            // Configure one-to-many relationship between Cart and CartItem
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.Cart.Id)
                .OnDelete(DeleteBehavior.Cascade); // Configure cascading delete (optional)

            // Configure many-to-one relationship between CartItem and Product
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany()
                .HasForeignKey(ci => ci.Product.Id)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete of products when CartItems are deleted

            // Configure one-to-many relationship between Order and OrderItem
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // Configure cascading delete (optional)

            // Configure many-to-one relationship between OrderItem and Product
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete of products when OrderItems are deleted

            // Configure many-to-many relationship between User and Role (UserRoles join table)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Roles)
                .WithMany()
                .UsingEntity(j => j.ToTable("UserRoles"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
