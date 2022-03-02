using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Phone" , Price = 200},
            new Product() { Name = "regular fries", Price = 3},
            new Product() {Name = "Curly fries", Price = 8},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL database");
            foreach (var product in Products)
            {
                Console.WriteLine($" Product is: {product.Name}, Price is: ${product.Price}");
            }
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}
