using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example3
{
    public class ConcreteCarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public ConcreteCarBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._car = new Car();
        }

        public void BuildEngine()
        {
            _car.Add("Engine");
            _car.HasEngine = true;
        }

        public void BuildSeats()
        {
            _car.Add("Seats");
            _car.HasSeats = true;
        }

        public void BuildGPS()
        {
            _car.Add("GPS");
            _car.HasGPS = true;
        }

        public void BuildAirbags()
        {
            _car.Add("Airbags");
            _car.HasAirbags = true;
        }

        // Validation inside the GetCar method to ensure valid configurations
        public Car GetCar()
        {
            if (!_car.HasEngine)
            {
                throw new InvalidOperationException("A car must have an engine.");
            }

            if (!_car.HasSeats)
            {
                throw new InvalidOperationException("A car must have seats.");
            }

            // Return the built car
            Car result = this._car;
            this.Reset();  // Reset for the next car
            return result;
        }
    }
}
