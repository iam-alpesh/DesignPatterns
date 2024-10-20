using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example2
{
    // The Director class controls the building process.
    public class Director
    {
        private IHouseBuilder _builder;

        public IHouseBuilder Builder
        {
            set { _builder = value; }
        }

        // Minimal viable house: e.g., a house with just bedrooms and bathrooms.
        public void BuildMinimalHouse()
        {
            _builder.BuildBedrooms();
            _builder.BuildBathrooms();
        }

        // Full-featured house: e.g., a house with all possible features.
        public void BuildLuxuryHouse()
        {
            _builder.BuildBedrooms();
            _builder.BuildBathrooms();
            _builder.BuildGarage();
            _builder.BuildSwimmingPool();
            _builder.BuildGarden();
            _builder.BuildFlooringMaterial();
        }
    }
}
