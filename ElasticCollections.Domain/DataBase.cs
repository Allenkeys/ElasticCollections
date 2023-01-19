using System.Dynamic;

namespace ElasticCollections.Domain
{
    public class DataBase
    {
        public List<ExpandoObject> _products = new List<ExpandoObject>();
        public void ProductGenerator()
        {
            dynamic product1 = new ExpandoObject();
            product1.Id = 1;
            product1.Name = "Dell XPS";
            product1.Quantity = 20;
            product1.Price = 1200.99;
            product1.Category = "PCs";
            product1.OrderCount = 35;

            dynamic product2 = new ExpandoObject();
            product2.Id = 2;
            product2.Name = "Ergonomic Chair";
            product2.Quantity = 25;
            product2.Price = 1100.99;
            product2.Category = "PCs";
            product2.OrderCount = 357;

            dynamic product3 = new ExpandoObject();
            product3.Id = 3;
            product3.Name = "Oakwood Table";
            product3.Quantity = 30;
            product3.Price = 4000.99;
            product3.Category = "PCs";
            product3.OrderCount = 368;


            _products.Add(product1);
            _products.Add(product2);
            _products.Add(product3);
        }

        public void Display()
        {
            _products.Clear();
            ProductGenerator();
            foreach (dynamic product in _products)
            {
                Console.WriteLine($"{product.Id}, {product.Name}, {product.Quantity}, ${product.Price}, {product.Category}, {product.OrderCount}");
            }
        }

        public void Display(string arg1, string arg2, string arg3)
        {
            _products.Clear();
            ProductGenerator();
            foreach (dynamic product in _products)
            {   
                foreach(var property in(IDictionary<string, object>)product)
                {
                    if(property.Key == arg1)
                    {
                        Console.Write($"\n{property.Value}, ");
                    }
                    if (property.Key == arg2)
                    {
                        Console.Write($"{property.Value}, ");
                    }
                    if (property.Key == arg3)
                    {
                        Console.Write($"{property.Value}, ");
                        Console.WriteLine();
                    }
                }
            }
            
        }

    }

}