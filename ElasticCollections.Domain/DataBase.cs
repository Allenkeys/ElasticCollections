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

            dynamic product2 = new ExpandoObject();
            product2.Id = 2;
            product2.Name = "Ergonomic Chair";
            product2.Quantity = 25;

            dynamic product3 = new ExpandoObject();
            product3.Id = 3;
            product3.Name = "Plywood Table";
            product3.Quantity = 30;


            _products.Add(product1);
            _products.Add(product2);
            _products.Add(product3);
        }

        public void Display()
        {
            ProductGenerator();
            foreach (dynamic item in _products)
            {
                Console.WriteLine($"{item.Id}: {item.Name} : {item.Quantity}");
            }
        }

    }

}