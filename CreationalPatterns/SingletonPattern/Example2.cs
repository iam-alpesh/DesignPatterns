using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.SingletonPattern.Example2
{
    class Logger
    {
        // Private constructor to prevent direct instantiation
        private Logger() { }

        // Private static instance of the Logger
        private static Logger _instance;

        // Lock object to ensure thread safety
        private static readonly object _lock = new object();

        // Public method to get the instance of the Logger
        public static Logger GetInstance()
        {
            // Check if the instance is null before acquiring the lock
            if (_instance == null)
            {
                lock (_lock)
                {
                    // Double-check to prevent race conditions
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        // Log method to output messages to the console
        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }

    public class Client
    {
        public void Main()
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see messages logged in the same format, then Singleton Logger was reused (yay!)",
                "If you see different instances, then multiple loggers were created (booo!!)",
                "RESULT:"
            );

            // Simulate multiple threads attempting to get a logger instance
            Thread process1 = new Thread(() =>
            {
                TestLogger("This is a message from Thread 1");
            });
            Thread process2 = new Thread(() =>
            {
                TestLogger("This is a message from Thread 2");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        // Test method to get the Logger instance and log a message
        public static void TestLogger(string message)
        {
            Logger logger = Logger.GetInstance();
            logger.Log(message);
        }
    }
}
