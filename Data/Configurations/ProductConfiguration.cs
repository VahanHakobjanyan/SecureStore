using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureStore.API.Data.Models;

namespace SecureStore.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Apple iPhone 15", Description = "Latest iPhone model with A17 chip", Price = 999.99m, Stock = 150 },
                new Product { Id = 2, Name = "Samsung Galaxy S24", Description = "Android smartphone with Snapdragon 8 Gen 3", Price = 899.99m, Stock = 200 },
                new Product { Id = 3, Name = "Sony WH-1000XM5", Description = "Noise-canceling wireless headphones", Price = 349.99m, Stock = 100 },
                new Product { Id = 4, Name = "Dell XPS 13", Description = "13-inch ultra-thin laptop with Intel Core i7", Price = 1499.99m, Stock = 50 },
                new Product { Id = 5, Name = "Nike Air Zoom Pegasus 39", Description = "Running shoes with responsive cushioning", Price = 119.99m, Stock = 120 },
                new Product { Id = 6, Name = "Apple MacBook Pro 16-inch", Description = "Powerful laptop with M2 Pro chip", Price = 2399.99m, Stock = 60 },
                new Product { Id = 7, Name = "Sony PlayStation 5", Description = "Next-gen gaming console with 4K gaming support", Price = 499.99m, Stock = 80 },
                new Product { Id = 8, Name = "Nintendo Switch OLED", Description = "Portable gaming console with 7-inch OLED screen", Price = 349.99m, Stock = 75 },
                new Product { Id = 9, Name = "GoPro HERO12 Black", Description = "Action camera with 5K video recording", Price = 399.99m, Stock = 130 },
                new Product { Id = 10, Name = "Amazon Echo Dot (5th Gen)", Description = "Smart speaker with Alexa", Price = 49.99m, Stock = 500 },
                new Product { Id = 11, Name = "Microsoft Surface Pro 9", Description = "2-in-1 laptop and tablet with Intel Core i7", Price = 1499.99m, Stock = 40 },
                new Product { Id = 12, Name = "Fitbit Charge 5", Description = "Fitness tracker with built-in GPS", Price = 149.99m, Stock = 200 },
                new Product { Id = 13, Name = "Apple Watch Series 8", Description = "Smartwatch with fitness tracking and heart rate monitor", Price = 399.99m, Stock = 100 },
                new Product { Id = 14, Name = "Bose QuietComfort 45", Description = "Noise-canceling headphones with superior sound", Price = 329.99m, Stock = 90 },
                new Product { Id = 15, Name = "Dyson V15 Detect", Description = "Cordless vacuum with laser illumination", Price = 699.99m, Stock = 30 },
                new Product { Id = 16, Name = "Samsung QLED 4K TV", Description = "65-inch QLED TV with Smart features", Price = 1299.99m, Stock = 70 },
                new Product { Id = 17, Name = "Bose SoundLink Revolve+", Description = "Portable Bluetooth speaker with 360° sound", Price = 299.99m, Stock = 150 },
                new Product { Id = 18, Name = "Canon EOS 90D", Description = "DSLR camera with 32.5MP sensor", Price = 1299.99m, Stock = 50 },
                new Product { Id = 19, Name = "Sony A7 III", Description = "Full-frame mirrorless camera with 24.2MP", Price = 1999.99m, Stock = 60 },
                new Product { Id = 20, Name = "KitchenAid Stand Mixer", Description = "Iconic stand mixer with 10 speeds and attachments", Price = 399.99m, Stock = 120 },
                new Product { Id = 21, Name = "Instant Pot Duo 7-in-1", Description = "Electric pressure cooker with multiple cooking options", Price = 89.99m, Stock = 300 },
                new Product { Id = 22, Name = "Google Pixel 8 Pro", Description = "Smartphone with Google's Tensor G3 chip", Price = 899.99m, Stock = 80 },
                new Product { Id = 23, Name = "Razer BlackWidow V3", Description = "Mechanical gaming keyboard with RGB backlighting", Price = 129.99m, Stock = 150 },
                new Product { Id = 24, Name = "Logitech G Pro X Superlight", Description = "Wireless gaming mouse with ultra-light design", Price = 149.99m, Stock = 200 },
                new Product { Id = 25, Name = "Herman Miller Aeron Chair", Description = "Ergonomic office chair with lumbar support", Price = 1395.00m, Stock = 50 }
                );
        }
    }
}
