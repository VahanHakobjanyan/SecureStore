using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; } // Change UserId to int

        public User User { get; set; } // Navigation property to User

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
