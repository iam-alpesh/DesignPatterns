using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example1
{
    public class DataRepository
    {
        private readonly IDatabaseConnection _connection;
        private readonly IDatabaseCommand _command;

        public DataRepository(IDatabaseFactory factory)
        {
            _connection = factory.CreateConnection();
            _command = factory.CreateCommand();
        }

        public void GetData()
        {
            _connection.Open();
            _command.Execute("SELECT * FROM Users");
            _connection.Close();
        }
    }
}
