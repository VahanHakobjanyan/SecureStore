using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int CartId { get; set; } // Add CartId for the foreign key

        [Required]
        public int ProductId { get; set; } // Add ProductId for the foreign key

        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}
