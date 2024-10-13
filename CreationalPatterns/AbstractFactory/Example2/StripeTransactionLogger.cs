using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example2
{
    public class StripeTransactionLogger : ITransactionLogger
    {
        public void LogTransaction(decimal amount)
        {
            Console.WriteLine($"Logging Stripe transaction of {amount:C}.");
            // Implementation details...
        }
    }
}
