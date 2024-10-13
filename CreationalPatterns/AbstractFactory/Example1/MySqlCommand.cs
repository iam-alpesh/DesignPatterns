using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example1
{
    public class MySqlCommand : IDatabaseCommand
    {
        public void Execute(string query)
        {
            Console.WriteLine($"Executing MySQL query: {query}");
        }
    }
}
