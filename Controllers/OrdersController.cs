using Microsoft.AspNetCore.Mvc;
using SecureStore.API.Data;

namespace SecureStore.API.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly SecureStoreApiDbContext _context;

        public OrdersController(SecureStoreApiDbContext context)
        {
            _context = context;
        }
    }
}
