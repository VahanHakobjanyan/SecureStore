﻿using System.ComponentModel.DataAnnotations;

namespace SecureStore.API.Data.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int UnitPrice { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}