using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example1
{
    public class Client
    {
        public void Main()
        {
            // Example: Get database type from configuration
            Console.WriteLine("Enter database type (SqlServer/MySql): ");
            string dbType = Console.ReadLine();

            try
            {
                IDatabaseFactory factory = DatabaseFactoryProducer.GetFactory(dbType);
                DataRepository repository = new DataRepository(factory);
                repository.GetData();
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void Hello()
        {
            Console.WriteLine("Hello");

        }
    }
}
