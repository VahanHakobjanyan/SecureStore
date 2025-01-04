using Microsoft.EntityFrameworkCore;
using SecureStore.API.Data;
using SecureStore.API.Data.Models;
using System.Collections;
using SecureStore.Data.DTOs;

namespace SecureStore.Repositories
{
    public class CartRepository
    {
        private readonly SecureStoreApiDbContext _context;

        public CartRepository(SecureStoreApiDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetCardItemResponse>> GetCart(int userId)
        {
            var cartItems = await _context.CartItems
                .Where(ci => ci.CartId == userId)
                .Select(ci => new GetCardItemResponse
                {
                    ProductName = ci.Product.Name,
                    Quantity = ci.Quantity,
                    Price = ci.Quantity * ci.Product.Price
                })
                .ToListAsync();
            return cartItems;
        }

        public async Task<Cart> AddCartItem(int userId, CartItem newCartItem)
        {
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
                return null;

            var existingCartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == newCartItem.ProductId);

            if (existingCartItem == null)
            {
                newCartItem.CartId = cart.Id;
                cart.CartItems.Add(newCartItem);
            }
            else
            {
                existingCartItem.Quantity += newCartItem.Quantity;
            }

            await _context.SaveChangesAsync();

            return cart;
        }

        public async Task<CartItem> UpdateCartItem(int id, int quantity)
        {
            var cartItemToUpdate = await _context.CartItems.FindAsync(id);

            if (cartItemToUpdate == null || quantity <= 0)
                return null;

            cartItemToUpdate.Quantity = quantity;

            await _context.SaveChangesAsync();
            return cartItemToUpdate;
        }

        public async Task<CartItem> DeleteCartItem(int id)
        {
            var cartItemToDelete = await _context.CartItems.FindAsync(id);

            if (cartItemToDelete == null)
                return null;

            _context.CartItems.Remove(cartItemToDelete);
            await _context.SaveChangesAsync();
            return cartItemToDelete;
        }

        public async Task<Cart> ClearCart(int userId)
        {
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
                return null;

            _context.CartItems.RemoveRange(cart.CartItems);
            await _context.SaveChangesAsync();
            return cart;
        }
    }
}
