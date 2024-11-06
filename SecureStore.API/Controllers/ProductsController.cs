using Microsoft.AspNetCore.Mvc;
using SecureStore.API.Data;
using SecureStore.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace SecureStore.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly SecureStoreApiDbContext _context;

        public ProductsController(SecureStoreApiDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public async Task<ICollection<Product>> RetrieveAll()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
