using System.Dynamic;

namespace ElasticCollections.Domain
{
    internal class DataBase
    {
        public static dynamic _products = new List<dynamic>();
        public static void ProductGenerator()
        {
            _products.Add(new ExpandoObject());
            _products[0].Id = 1;
            _products[0].Name = "Dell XPS";
            _products[0].Quantity = 20;
            _products[0].Price = 1200.99;
            _products[0].Category = "PCs";
            _products[0].OrderCount = 35;

            _products.Add(new ExpandoObject());
            _products[1].Id = 2;
            _products[1].Name = "Ergonomic Chair";
            _products[1].Quantity = 25;
            _products[1].Price = 1100.99;
            _products[1].Category = "PCs";
            _products[1].OrderCount = 357;

            _products.Add(new ExpandoObject());
            _products[2].Id = 3;
            _products[2].Name = "Oakwood Table";
            _products[2].Quantity = 30;
            _products[2].Price = 4000.99;
            _products[2].Category = "PCs";
            _products[2].OrderCount = 368;

        }

    }

}

