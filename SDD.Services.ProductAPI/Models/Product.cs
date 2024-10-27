﻿using System.ComponentModel.DataAnnotations;

namespace SDD.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Range(1, 1000)]
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }  = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
    }
}
