using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example2
{
    // The Builder interface specifies methods for creating the different parts of the House objects.
    public interface IHouseBuilder
    {
        void BuildBedrooms();
        void BuildBathrooms();
        void BuildGarage();
        void BuildSwimmingPool();
        void BuildGarden();
        void BuildFlooringMaterial();
    }
}
