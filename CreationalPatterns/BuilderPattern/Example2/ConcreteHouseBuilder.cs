using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example2
{
    // The Concrete Builder class implements the IHouseBuilder interface and provides
    // specific implementations for building parts of the house.
    public class ConcreteHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public ConcreteHouseBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._house = new House();
        }

        // Implementations of the building steps
        public void BuildBedrooms()
        {
            this._house.Add("4 Bedrooms");
            _house.BedroomCount = 4;  // Add specific tracking of the count of bedrooms
        }

        public void BuildBathrooms()
        {
            this._house.Add("3 Bathrooms");
            _house.BathroomCount = 3; // Add specific tracking of the count of bathrooms
        }

        public void BuildGarage()
        {
            this._house.Add("Garage");
            _house.HasGarage = true;
        }

        public void BuildSwimmingPool()
        {
            this._house.Add("Swimming Pool");
            _house.HasSwimmingPool = true;
        }

        public void BuildGarden()
        {
            this._house.Add("Garden");
            _house.HasGarden = true;
        }

        public void BuildFlooringMaterial()
        {
            this._house.Add("Wooden Flooring");
            _house.HasFlooringMaterial = true;
        }

        // Retrieve the constructed House object.
        public House GetHouse()
        {
            // Validation logic before returning the final product.
            if (_house.BedroomCount < 1)
            {
                throw new InvalidOperationException("A house must have at least one bedroom.");
            }

            if (_house.BathroomCount < 1)
            {
                throw new InvalidOperationException("A house must have at least one bathroom.");
            }

            if (_house.HasSwimmingPool && !_house.HasGarden)
            {
                throw new InvalidOperationException("A swimming pool can only be added if the house has a garden.");
            }

            if (!_house.HasFlooringMaterial)
            {
                throw new InvalidOperationException("A house must have flooring material set.");
            }

            // Return the valid house
            House result = this._house;
            this.Reset(); // Reset the builder to be reused for another house
            return result;
        }
    }
}
