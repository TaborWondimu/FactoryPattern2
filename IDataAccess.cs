using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
  public interface IDataAccess
    {
        List<Product> LoadData(); // stubbed out methods
        public void SaveData(); // stubbed out method
    }
}
