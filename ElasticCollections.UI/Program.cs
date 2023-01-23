using System.Dynamic;
using ElasticCollections.Domain;

namespace ElasticCollections.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DomainBL dbl = new();
            dbl.Display("Name", "Price", "Quantity");
            dbl.Display();
        }
    }
}