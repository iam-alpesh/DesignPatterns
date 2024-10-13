using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example2
{
    public class StripeNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Stripe notification: {message}");
            // Implementation details...
        }
    }
}
