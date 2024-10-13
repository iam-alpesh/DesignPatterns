using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example1
{
    public static class DatabaseFactoryProducer
    {
        public static IDatabaseFactory GetFactory(string dbType)
        {
            switch (dbType.ToLower())
            {
                case "sqlserver":
                    return new SqlServerFactory();
                case "mysql":
                    return new MySqlFactory();
                default:
                    throw new NotSupportedException($"Database type '{dbType}' is not supported.");
            }
        }
    }
}
