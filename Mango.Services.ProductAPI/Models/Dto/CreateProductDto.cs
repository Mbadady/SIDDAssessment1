﻿namespace SDD.Services.ProductAPI.Models.Dto
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
    }
}