using Microsoft.AspNetCore.Mvc;
using SecureStore.API.Data.Models;
using Microsoft.AspNetCore.Authorization;
using SecureStore.API.Repositories;
using SecureStore.Data.DTOs;

namespace SecureStore.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository _productRepository;

        public ProductsController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [Authorize]
        [HttpGet]
        public async Task<ICollection<Product>> RetrieveAll()
        {
            return await _productRepository.GetAllProducts();
        }
    }
}
