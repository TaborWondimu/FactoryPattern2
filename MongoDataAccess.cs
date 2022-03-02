using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Jack" , Price = 50},
            new Product() { Name = "HeadSet", Price = 30},
            new Product() {Name = "Milk", Price = 80},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from mongo database");
            foreach (var product in Products)
            {
                Console.WriteLine($" Product is: {product.Name}, Price is: ${product.Price}");
            }
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a mongo database");
        }
    }
}
