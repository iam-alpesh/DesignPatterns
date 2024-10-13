using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example1
{
  
    public class SqlServerConnection : IDatabaseConnection
    {
        public void Open()
        {
            Console.WriteLine("Opening SQL Server connection.");
        }

        public void Close()
        {
            Console.WriteLine("Closing SQL Server connection.");
        }
    }

}
