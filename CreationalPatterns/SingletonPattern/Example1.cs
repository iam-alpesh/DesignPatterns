using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.SingletonPattern.Example1
{
    class ConfigurationManager
    {
        private ConfigurationManager() { }

        private static ConfigurationManager _instance;
        private static readonly object _lock = new object();

        public string ConfigurationValue { get; set; }

        public static ConfigurationManager GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                        _instance.ConfigurationValue = value;
                    }
                }
            }
            return _instance;
        }

        public void ShowConfiguration()
        {
            Console.WriteLine("Current Configuration: " + ConfigurationValue);
        }
    }

    public class Client
    {
        public void Main()
        {            

            Thread process1 = new Thread(() =>
            {
                TestConfigurationManager("Database=SQLServer");
            });
            Thread process2 = new Thread(() =>
            {
                TestConfigurationManager("Database=PostgreSQL");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestConfigurationManager(string value)
        {
            ConfigurationManager configManager = ConfigurationManager.GetInstance(value);
            configManager.ShowConfiguration();
        }
    }
}
