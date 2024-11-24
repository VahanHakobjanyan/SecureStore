using SecureStore.API.Data.Models;
using SecureStore.API.Repositories;
using SecureStore.Data.DTOs;
using System.Runtime.InteropServices;

namespace SecureStore.API.Services
{
    public class ProductsService
    {
        private readonly ProductRepository _repository;

        public ProductsService(ProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddProduct()
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<Product>> RetrieveAllProducts()
        {
            return await _repository.GetAllProducts();
        }
    }
}
