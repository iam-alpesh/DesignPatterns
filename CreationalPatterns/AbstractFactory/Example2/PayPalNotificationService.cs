using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example2
{
    public class PayPalNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending PayPal notification: {message}");
            // Implementation details...
        }
    }
}
