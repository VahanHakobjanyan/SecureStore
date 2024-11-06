using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int Quantity { get; set; }
        
        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}
