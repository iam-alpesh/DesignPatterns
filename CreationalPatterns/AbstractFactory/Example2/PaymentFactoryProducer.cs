using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example2
{
    public static class PaymentFactoryProducer
    {
        public static IPaymentFactory GetFactory(string paymentGateway)
        {
            switch (paymentGateway.ToLower())
            {
                case "paypal":
                    return new PayPalFactory();
                case "stripe":
                    return new StripeFactory();
                default:
                    throw new NotSupportedException($"Payment gateway '{paymentGateway}' is not supported.");
            }
        }
    }
}
