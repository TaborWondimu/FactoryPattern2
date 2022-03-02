using System;
namespace FactoryPattern2
{
   class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose the database");
            var response = Console.ReadLine();

            DataAccessFactory.GetDataAccessType(response);

            IDataAccess data = DataAccessFactory.GetDataAccessType(response);

            data.LoadData();
            data.SaveData();
           

        }
    }
}