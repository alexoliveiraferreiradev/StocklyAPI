﻿namespace StocklyAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public string Category { get; set; }
        public decimal Weight { get; set; }

    }
}
