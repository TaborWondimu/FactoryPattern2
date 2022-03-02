using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    public class Product
    {
        public Product()
        {
            // default constructor
        }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
