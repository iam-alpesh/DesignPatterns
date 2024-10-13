using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example1
{
    public class MySqlConnection : IDatabaseConnection
    {
        public void Open()
        {
            Console.WriteLine("Opening MySQL connection.");
        }

        public void Close()
        {
            Console.WriteLine("Closing MySQL connection.");
        }
    }
}
