using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example3
{
    public class Client
    {
        public void Main()
        {
            var director = new Director();
            var carBuilder = new ConcreteCarBuilder();
            director.Builder = carBuilder;

            // Build a basic car
            try
            {
                Console.WriteLine("Building a basic car:");
                director.BuildBasicCar();
                Console.WriteLine(carBuilder.GetCar().ListParts());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Build a luxury car
            try
            {
                Console.WriteLine("Building a luxury car:");
                director.BuildLuxuryCar();
                Console.WriteLine(carBuilder.GetCar().ListParts());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Build an invalid car (no seats)
            try
            {
                Console.WriteLine("Building an invalid car (no seats):");
                carBuilder.BuildEngine();  // Missing seats
                Console.WriteLine(carBuilder.GetCar().ListParts());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
