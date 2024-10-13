using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example2
{
    public class PayPalFactory : IPaymentFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new PayPalPaymentProcessor();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new PayPalTransactionLogger();
        }

        public INotificationService CreateNotificationService()
        {
            return new PayPalNotificationService();
        }
    }

}
