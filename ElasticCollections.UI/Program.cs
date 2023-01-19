using System.Dynamic;
using ElasticCollections.Domain;

namespace ElasticCollections.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase();
            db.Display();
        }
    }
}