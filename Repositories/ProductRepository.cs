using Microsoft.EntityFrameworkCore;
using SecureStore.API.Data;
using SecureStore.API.Data.Models;
using SecureStore.Data.DTOs;

namespace SecureStore.API.Repositories
{
    public class ProductRepository
    {
        private readonly SecureStoreApiDbContext _context;

        public ProductRepository(SecureStoreApiDbContext context)
        {
            _context = context;
        }

        public async Task<Product> AddProduct(ProductModel productModel)
        {
            if (productModel == null || await CheckForExistingProduct(productModel))
            {
                return null;
            }
            var productToAdd = new Product(productModel.Name, productModel.Description, productModel.Price, productModel.Stock);
            _context.Products.AddAsync(productToAdd);
            _context.SaveChangesAsync();
            return productToAdd;
        }

        public async Task<ICollection<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            if (await CheckForExistingProduct(id))
            {
                return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            }
            return null;
        }

        public async Task<Product> UpdateProduct(int id, ProductModel productModel)
        {
            var productToUpdate = await _context.Products.FindAsync(id);

            if (productToUpdate == null)
                return null;

            productToUpdate.Name = productModel.Name;
            productToUpdate.Description = productModel.Description;
            productToUpdate.Price = productModel.Price;
            productToUpdate.Stock = productModel.Stock;

            await _context.SaveChangesAsync();
            return productToUpdate;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var productToDelete = await _context.Products.FindAsync(id);

            if (productToDelete == null)
                return false;

            _context.Products.Remove(productToDelete);
            _context.SaveChangesAsync();

            return true;
        }

        private async Task<bool> CheckForExistingProduct(ProductModel productModel)
        {
            return await _context.Products.AnyAsync(p => p.Name == productModel.Name);
        }
        private async Task<bool> CheckForExistingProduct(int id)
        {
            return await _context.Products.AnyAsync(p => p.Id == id);
        }
    }
}
