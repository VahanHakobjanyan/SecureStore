using Microsoft.EntityFrameworkCore;
using SecureStore.API.Data;
using SecureStore.API.Data.Models;

namespace SecureStore.API.Services
{
    public class ProductsService
    {
        private readonly SecureStoreApiDbContext _context;

        public async Task<ICollection<Product>> RetrieveAllProducts()
        {
            return await _context.Products.ToListAsync();
        } 
    }
}
