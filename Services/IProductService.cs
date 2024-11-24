using SecureStore.API.Data.Models;

namespace SecureStore.API.Services
{
    public interface IProductService
    {
        Task<ICollection<Product>> RetrieveAllProducts();
    }
}
