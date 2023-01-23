using System;
namespace ElasticCollections.Domain
{
    public class DomainBL
    {
        public void Display()
        {
            DataBase._products.Clear();
            DataBase.ProductGenerator();
            foreach (dynamic product in DataBase._products)
            {
                Console.WriteLine($"{product.Id}, {product.Name}, {product.Quantity}, ${product.Price}, {product.Category}, {product.OrderCount}");
                Console.WriteLine();
            }
        }

        public void Display(string arg1, string arg2, string arg3)
        {
            try
            {
                DataBase._products.Clear();
                DataBase.ProductGenerator();
                foreach (dynamic product in DataBase._products)
                {
                    Console.WriteLine($"{((IDictionary<string, object>)product)[arg1]}, " +
                        $"{((IDictionary<string, object>)product)[arg2]}, " +
                        $"{((IDictionary<string, object>)product)[arg3]}");
                    Console.WriteLine();
                }
            }
            catch(KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("Arguments cannot be null or empty");
            }
        }
    }
}
