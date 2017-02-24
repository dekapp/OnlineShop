﻿using System.Collections.Generic;

namespace OnlineShop.Models
{
    public enum Target
    {
        He,
        She,
        Kids
    }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public Target Target { get; set; }

        public string Category { get; set; }

        public string Type { get; set; }

        virtual public ICollection<ProductImage> ProductImages { get; set; }

        public Product()
        {
            ProductImages = new List<ProductImage>();
        }

    }
}