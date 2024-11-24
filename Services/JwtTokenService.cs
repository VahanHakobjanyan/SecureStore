using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SecureStore.API.Data;
using SecureStore.API.Data.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SecureStore.API.Services
{
    public class JwtTokenService
    {
        private readonly IConfiguration _configuration;
        private readonly SecureStoreApiDbContext _secureStoreApiDbContext;

        public JwtTokenService(IConfiguration configuration, SecureStoreApiDbContext secureStoreApiDbContext)
        {
            _configuration = configuration;
            _secureStoreApiDbContext = secureStoreApiDbContext;
        }

        public async Task<string> GenerateToken(int userId)
        {
            // Load the user with their roles and related role information
            var user = await _secureStoreApiDbContext.Users
                                      .Include(u => u.UserRoles)    // Include UserRoles
                                      .ThenInclude(ur => ur.Role)   // Include the related Role
                                      .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new UnauthorizedAccessException("User not found");
            }

            // Create claims list for the JWT
            var claims = new List<Claim>
    {
        new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new Claim(ClaimTypes.Email, user.Email)
    };

            // Check if the user has roles and add them to the claims
            if (user.UserRoles != null)
            {
                foreach (var userRole in user.UserRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, userRole.Role.RoleName));
                }
            }

            // Generate the JWT token
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(double.Parse(_configuration["JwtSettings:TokenLifetimeMinutes"])),
                signingCredentials: creds);

            // Return the JWT token as a string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
