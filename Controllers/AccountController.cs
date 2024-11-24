using Microsoft.AspNetCore.Mvc;
using SecureStore.API.Services;
using SecureStore.Data.DTOs;

namespace SecureStore.API.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly JwtTokenService _jwtTokenService;

        public AccountController(IUserService userService, JwtTokenService jwtTokenService)
        {
            _userService = userService;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            var newUser = await _userService.Register(model);
            if (newUser == null)
            {
                return Conflict("Email already registered");
            }

            return Ok(newUser);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _userService.AuthenticateUserAsync(model.Email, model.Password);
            if (user == null)
            {
                return Unauthorized("Invalid email or password");
            }

            var token = await _jwtTokenService.GenerateToken(user.Id);

            return Ok(new { message = "Login successful", token });
        }
    }
}
