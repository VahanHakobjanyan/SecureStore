using Microsoft.AspNetCore.Mvc;
using SecureStore.API.Data;
using SecureStore.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using SecureStore.API.Services;

namespace SecureStore.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        //[Authorize]
        [HttpGet]
        public async Task<ICollection<Product>> RetrieveAll()
        {
           return await _productService.RetrieveAllProducts();
        }
    }
}
