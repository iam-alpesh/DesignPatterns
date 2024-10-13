using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example2
{
    public class Client
    {
        public void Main()
        {
            // Example: Get payment gateway type from configuration or user input
            Console.WriteLine("Enter payment gateway (PayPal/Stripe): ");
            string paymentGateway = Console.ReadLine();

            Console.WriteLine("Enter payment amount: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                Console.WriteLine("Invalid amount entered.");
                return;
            }

            try
            {
                IPaymentFactory factory = PaymentFactoryProducer.GetFactory(paymentGateway);
                PaymentService paymentService = new PaymentService(factory);
                paymentService.ExecutePayment(amount);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
