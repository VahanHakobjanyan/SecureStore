using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecureStore.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Latest iPhone model with A17 chip", "Apple iPhone 15", 999.99m, 150 },
                    { 2, "Android smartphone with Snapdragon 8 Gen 3", "Samsung Galaxy S24", 899.99m, 200 },
                    { 3, "Noise-canceling wireless headphones", "Sony WH-1000XM5", 349.99m, 100 },
                    { 4, "13-inch ultra-thin laptop with Intel Core i7", "Dell XPS 13", 1499.99m, 50 },
                    { 5, "Running shoes with responsive cushioning", "Nike Air Zoom Pegasus 39", 119.99m, 120 },
                    { 6, "Powerful laptop with M2 Pro chip", "Apple MacBook Pro 16-inch", 2399.99m, 60 },
                    { 7, "Next-gen gaming console with 4K gaming support", "Sony PlayStation 5", 499.99m, 80 },
                    { 8, "Portable gaming console with 7-inch OLED screen", "Nintendo Switch OLED", 349.99m, 75 },
                    { 9, "Action camera with 5K video recording", "GoPro HERO12 Black", 399.99m, 130 },
                    { 10, "Smart speaker with Alexa", "Amazon Echo Dot (5th Gen)", 49.99m, 500 },
                    { 11, "2-in-1 laptop and tablet with Intel Core i7", "Microsoft Surface Pro 9", 1499.99m, 40 },
                    { 12, "Fitness tracker with built-in GPS", "Fitbit Charge 5", 149.99m, 200 },
                    { 13, "Smartwatch with fitness tracking and heart rate monitor", "Apple Watch Series 8", 399.99m, 100 },
                    { 14, "Noise-canceling headphones with superior sound", "Bose QuietComfort 45", 329.99m, 90 },
                    { 15, "Cordless vacuum with laser illumination", "Dyson V15 Detect", 699.99m, 30 },
                    { 16, "65-inch QLED TV with Smart features", "Samsung QLED 4K TV", 1299.99m, 70 },
                    { 17, "Portable Bluetooth speaker with 360° sound", "Bose SoundLink Revolve+", 299.99m, 150 },
                    { 18, "DSLR camera with 32.5MP sensor", "Canon EOS 90D", 1299.99m, 50 },
                    { 19, "Full-frame mirrorless camera with 24.2MP", "Sony A7 III", 1999.99m, 60 },
                    { 20, "Iconic stand mixer with 10 speeds and attachments", "KitchenAid Stand Mixer", 399.99m, 120 },
                    { 21, "Electric pressure cooker with multiple cooking options", "Instant Pot Duo 7-in-1", 89.99m, 300 },
                    { 22, "Smartphone with Google's Tensor G3 chip", "Google Pixel 8 Pro", 899.99m, 80 },
                    { 23, "Mechanical gaming keyboard with RGB backlighting", "Razer BlackWidow V3", 129.99m, 150 },
                    { 24, "Wireless gaming mouse with ultra-light design", "Logitech G Pro X Superlight", 149.99m, 200 },
                    { 25, "Ergonomic office chair with lumbar support", "Herman Miller Aeron Chair", 1395.00m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
