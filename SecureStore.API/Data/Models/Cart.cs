using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        public List<CartItem> CartItems { get; set; }
    }
}
