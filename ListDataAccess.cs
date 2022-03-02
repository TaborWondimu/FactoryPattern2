using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    public class ListDataAccess : IDataAccess
    {

        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Car" , Price = 350},
            new Product() { Name = "Stick", Price = 300},
            new Product() {Name = "PC", Price = 800},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from list database");
           foreach (var product in Products)
            {
                Console.WriteLine($" Product is: {product.Name}, Price is: ${product.Price}");
            }
            return Products;
        }

        public void SaveData()
        {
        Console.WriteLine("I am saving data to a list database");
        }
    }
}
