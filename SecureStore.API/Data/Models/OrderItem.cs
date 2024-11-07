using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; } // Foreign key for Order
        public Order Order { get; set; }

        [Required]
        public int ProductId { get; set; } // Foreign key for Product
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int UnitPrice { get; set; }

    }
}
