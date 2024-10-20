using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example2
{
    public class Client
    {
        public void Main()
        {
            var director = new Director();
            var houseBuilder = new ConcreteHouseBuilder();
            director.Builder = houseBuilder;

            // Build a minimal house (Valid Configuration)
            try
            {
                Console.WriteLine("Building a minimal house:");
                director.BuildMinimalHouse();  // Only builds bedrooms and bathrooms
                Console.WriteLine(houseBuilder.GetHouse().ListParts());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Build a full-featured luxury house (Valid Configuration)
            try
            {
                Console.WriteLine("Building a luxury house:");
                director.BuildLuxuryHouse();
                Console.WriteLine(houseBuilder.GetHouse().ListParts());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Try to build an invalid house (Swimming pool without garden)
            try
            {
                Console.WriteLine("Building an invalid house (Pool without garden):");
                houseBuilder.BuildBedrooms();
                houseBuilder.BuildBathrooms();
                houseBuilder.BuildSwimmingPool(); // Invalid because there's no garden
                Console.WriteLine(houseBuilder.GetHouse().ListParts());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Try to build a house without setting flooring material (Invalid)
            try
            {
                Console.WriteLine("Building an invalid house (No flooring):");
                houseBuilder.BuildBedrooms();
                houseBuilder.BuildBathrooms();
                houseBuilder.BuildGarage();
                Console.WriteLine(houseBuilder.GetHouse().ListParts());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
