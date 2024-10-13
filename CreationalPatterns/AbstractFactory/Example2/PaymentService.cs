using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example2
{
    public class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly ITransactionLogger _transactionLogger;
        private readonly INotificationService _notificationService;

        public PaymentService(IPaymentFactory factory)
        {
            _paymentProcessor = factory.CreatePaymentProcessor();
            _transactionLogger = factory.CreateTransactionLogger();
            _notificationService = factory.CreateNotificationService();
        }

        public void ExecutePayment(decimal amount)
        {
            _paymentProcessor.ProcessPayment(amount);
            _transactionLogger.LogTransaction(amount);
            _notificationService.SendNotification($"Payment of {amount:C} processed successfully.");
        }
    }

}
