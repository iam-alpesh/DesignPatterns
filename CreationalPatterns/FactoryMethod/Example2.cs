using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Example2
{
    public interface IOrder
    {
        string ProcessOrder();
    }
    public class RestaurantOrder : IOrder
    {
        public string ProcessOrder()
        {
            return "Processing restaurant order.";
        }
    }

    public class GroceryOrder : IOrder
    {
        public string ProcessOrder()
        {
            return "Processing grocery order.";
        }
    }

    public class PharmacyOrder : IOrder
    {
        public string ProcessOrder()
        {
            return "Processing pharmacy order.";
        }
    }
    public abstract class OrderFactory
    {
        public abstract IOrder CreateOrder();

        public string SomeOperation()
        {
            var order = CreateOrder();
            return "OrderFactory: The factory has created an order: " + order.ProcessOrder();
        }
    }

    public class RestaurantOrderFactory : OrderFactory
    {
        public override IOrder CreateOrder()
        {
            return new RestaurantOrder();
        }
    }

    public class GroceryOrderFactory : OrderFactory
    {
        public override IOrder CreateOrder()
        {
            return new GroceryOrder();
        }
    }

    public class PharmacyOrderFactory : OrderFactory
    {
        public override IOrder CreateOrder()
        {
            return new PharmacyOrder();
        }
    }
    public class Client
    {
        public void Main()
        {
            OrderFactory factory;

            // Assume we get the type of order from user input or configuration.
            factory = new RestaurantOrderFactory();
            Console.WriteLine(factory.SomeOperation());

            factory = new GroceryOrderFactory();
            Console.WriteLine(factory.SomeOperation());

            factory = new PharmacyOrderFactory();
            Console.WriteLine(factory.SomeOperation());
        }
    }


}
