using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.SingletonPattern
{
    public sealed class Logger
    {
        // Private static instance of the class
        private static Logger _instance = null;

        // Object for locking to ensure thread safety
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation from outside
        private Logger()
        {
            Console.WriteLine("Logger Initialized.");
        }

        // Public static method to get the instance
        public static Logger Instance
        {
            get
            {
                // Ensure only one instance is created in a thread-safe way
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        // Example logging method
        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }

    public class Client
    {
        public void Main()
        {
            // Getting the single instance of Logger and using it to log messages
            Logger.Instance.Log("This is a log message.");
            Logger.Instance.Log("Another log message.");
        }
    }
}
