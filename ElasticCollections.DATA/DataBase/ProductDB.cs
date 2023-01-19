using System.Collections.Generic;
using ElasticCollections.DATA.Models;

namespace ElasticCollections.DATA.DataBase
{
    internal class ProductDB
    {
        public IList<Product> Products { get; } = new List<Product>
        {
             new Product
             {
                 Id = 1,
                 Name = "Dell XPS",
                 Quantity = 20,
                 Price = 1000.99,
                 Category = "PCs",
                 OrderCount = 5
             },
             new Product
             {
                 Id = 2,
                 Name = "Hp ProBook",
                 Quantity = 25,
                 Price = 500.99,
                 Category = "PCs",
                 OrderCount = 6
             },
             new Product
             {
                 Id = 3,
                 Name = "Ergonomic Chair",
                 Quantity = 100,
                 Price = 200.99,
                 Category = "Chairs",
                 OrderCount = 10
             },
             new Product
             {
                 Id = 4,
                 Name = "Massager",
                 Quantity = 20,
                 Price = 2100.99,
                 Category = "Chairs",
                 OrderCount = 25
             },
             new Product
             {
                 Id = 5,
                 Name = "Plywood Table",
                 Quantity = 55,
                 Price = 520.99,
                 Category = "Tables",
                 OrderCount = 8
             },
             new Product
             {
                 Id = 6 ,
                 Name = "Adjustable Table",
                 Quantity = 20,
                 Price = 1200.99,
                 Category = "Tables",
                 OrderCount = 7
             },

        };

    }
}
