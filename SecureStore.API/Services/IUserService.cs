using SecureStore.API.Data.Models;

namespace SecureStore.API.Services
{
    public interface IUserService
    {
        Task<User> Register(RegisterModel model);
        Task<User> AuthenticateUserAsync(string email, string password);
    }
}
