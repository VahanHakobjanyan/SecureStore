using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecureStore.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "alice.smith@securestore.com", "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f", "Alice" },
                    { 2, "bob.jones@securestore.com", "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f", "Bob" },
                    { 3, "charlie.brown@securestore.com", "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f", "Charlie" },
                    { 4, "diana.green@securestore.com", "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f", "Diana" },
                    { 5, "eva.white@securestore.com", "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f", "Eva" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
