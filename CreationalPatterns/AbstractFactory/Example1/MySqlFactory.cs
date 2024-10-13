using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example1
{
    public class MySqlFactory : IDatabaseFactory
    {
        public IDatabaseConnection CreateConnection()
        {
            return new MySqlConnection();
        }

        public IDatabaseCommand CreateCommand()
        {
            return new MySqlCommand();
        }
    }

}
