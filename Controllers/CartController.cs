using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureStore.API.Data.Models;
using SecureStore.Data.DTOs;
using SecureStore.Repositories;
using System.Security.Claims;

namespace SecureStore.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly CartRepository _cartRepository;

        public CartController(CartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCart()
        {
            var userIdClaim = User.FindFirst("UserId");
            if (userIdClaim == null)
            {
                return Unauthorized("User is not logged in");
            }
            var userId = int.Parse(userIdClaim.Value);
            var cart = await _cartRepository.GetCart(userId);

            if (cart == null)
                return BadRequest($"User with ID {userId} doesnt have cart");
            return Ok(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(AddCartItemRequest request)
        {
            var userIdClaim = User.FindFirst("UserId");
            if (userIdClaim == null)
            {
                return Unauthorized("User is not logged in");
            }
            var userId = int.Parse(userIdClaim.Value);
            var cartItem = new CartItem
            {
                ProductId = request.ProductId,
                Quantity = request.Quantity
            };
            await _cartRepository.AddCartItem(userId, cartItem);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateItem(int id, int quantity)
        {
            var userIdClaim = User.FindFirst("UserId");
            if (userIdClaim == null)
            {
                return Unauthorized("User is not logged in");
            }
            var userId = int.Parse(userIdClaim.Value);
            var updatedCartItem = await _cartRepository.UpdateCartItem(userId, id, quantity);
            if (updatedCartItem == null)
                return NotFound($"Cart item with ID {id} not found");
            return Ok(updatedCartItem);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var userIdClaim = User.FindFirst("UserId");
            if (userIdClaim == null)
            {
                return Unauthorized("User is not logged in");
            }
            var userId = int.Parse(userIdClaim.Value);
            var deletedCartItem = await _cartRepository.DeleteCartItem(userId, id);
            if (deletedCartItem == null)
                return NotFound($"Cart item with ID {id} not found");
            return Ok(deletedCartItem);
        }

        [HttpDelete]
        public async Task<IActionResult> ClearCart()
        {
            var userIdClaim = User.FindFirst("UserId");
            if (userIdClaim == null)
            {
                return Unauthorized("User is not logged in");
            }
            var userId = int.Parse(userIdClaim.Value);
            var allCardItems = await _cartRepository.ClearCart(userId);
            if (allCardItems == null)
                return NotFound("Cart is empty");
            return Ok(allCardItems);
        }
    }
}
