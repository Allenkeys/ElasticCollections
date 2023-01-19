using System;
using System.Collections.Generic;
using System.Text;

namespace ElasticCollections.DATA.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int OrderCount { get; set; }

        /*public Product(string name, int quantity, int orderCount)
        {
            Name = name;
            Quantity = quantity;
            OrderCount = orderCount;
        }

        public Product() { }*/

    }
}
