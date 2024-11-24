using SecureStore.API.Data.Models;
using SecureStore.Data.DTOs;

namespace SecureStore.API.Services
{
    public interface IUserService
    {
        Task<User> Register(RegisterModel model);
        Task<User> AuthenticateUserAsync(string email, string password);
    }
}
