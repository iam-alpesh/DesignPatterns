using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example2
{
    public interface IPaymentFactory
    {
        IPaymentProcessor CreatePaymentProcessor();
        ITransactionLogger CreateTransactionLogger();
        INotificationService CreateNotificationService();
    }
}
