using Microsoft.AspNetCore.Mvc;
using SecureStore.API.Data;

namespace SecureStore.API.Controllers
{
    [Route("Api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly SecureStoreApiDbContext _context;

        public OrdersController(SecureStoreApiDbContext context)
        {
            _context = context;
        }
    }
}
