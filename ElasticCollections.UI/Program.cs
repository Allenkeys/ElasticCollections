using System.Dynamic;
using ElasticCollections.Domain;

namespace ElasticCollections.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DomainBL dbl = new();
            dbl.Display();
            dbl.Display("Name", "Price", "OrderCount");
        }
    }
}