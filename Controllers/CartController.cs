using Microsoft.AspNetCore.Mvc;
using SecureStore.API.Data;

namespace SecureStore.API.Controllers
{
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly SecureStoreApiDbContext _context;

        public CartController(SecureStoreApiDbContext context)
        {
            _context = context;
        }
    }
}
