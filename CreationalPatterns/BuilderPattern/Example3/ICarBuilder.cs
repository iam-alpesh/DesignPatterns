using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example3
{
    public interface ICarBuilder
    {
        void BuildEngine();
        void BuildSeats();
        void BuildGPS();
        void BuildAirbags();
        Car GetCar();
    }

}
