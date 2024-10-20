using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example3
{
    public class Director
    {
        private ICarBuilder _builder;

        public ICarBuilder Builder
        {
            set { _builder = value; }
        }

        // Build a basic car with essential components
        public void BuildBasicCar()
        {
            _builder.BuildEngine();
            _builder.BuildSeats();
        }

        // Build a luxury car with all features
        public void BuildLuxuryCar()
        {
            _builder.BuildEngine();
            _builder.BuildSeats();
            _builder.BuildGPS();
            _builder.BuildAirbags();
        }
    }

}
