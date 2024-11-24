using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureStore.API.Repositories;
using SecureStore.Data.DTOs;

namespace SecureStore.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ProductRepository _productRepository;
        public AdminController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductModel model)
        {
            var productToAdd = await _productRepository.AddProduct(model);
            if (productToAdd != null)
                return Ok("Product Successfully added");

            return BadRequest("Product doesnt exists or wrong product");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var productToGet = await _productRepository.GetProduct(id);
            if (productToGet != null)
                return Ok(productToGet);

            return NotFound($"Product with ID {id} doesn`t exist");
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();
            if (products.Count == 0)
                return NotFound("No products found in database");

            return Ok(products);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductModel model)
        {
            if (model == null)
                return BadRequest("Wrong model");

            var updatedProduct = await _productRepository.UpdateProduct(id, model);

            if (updatedProduct != null)
                return Ok(updatedProduct);
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (await _productRepository.DeleteProduct(id))
                return Ok($"Product with ID {id} successfully deleted");

            return NotFound($"No product with ID {id} was found");
        }
    }
}
