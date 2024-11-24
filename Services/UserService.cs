using Microsoft.EntityFrameworkCore;
using SecureStore.API.Data;
using SecureStore.API.Data.Models;
using SecureStore.Data.DTOs;
using System.Security.Cryptography;
using System.Text;

namespace SecureStore.API.Services
{
    public class UserService : IUserService
    {
        private readonly SecureStoreApiDbContext _context;

        public UserService(SecureStoreApiDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<User> Register(RegisterModel model)
        {
            if (await CheckForExistingUser(model.Email))
                return null;
            var newUser = new User(model.Username, model.Email, HashPassword(model.Password));
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task<User> AuthenticateUserAsync(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null || user.Password != HashPassword(password))
            {
                return null;
            }
            return user;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private async Task<bool> CheckForExistingUser(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);
        }
    }
}
