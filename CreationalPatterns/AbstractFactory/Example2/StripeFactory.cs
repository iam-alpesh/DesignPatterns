using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example2
{
    public class StripeFactory : IPaymentFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new StripePaymentProcessor();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new StripeTransactionLogger();
        }

        public INotificationService CreateNotificationService()
        {
            return new StripeNotificationService();
        }
    }

}
