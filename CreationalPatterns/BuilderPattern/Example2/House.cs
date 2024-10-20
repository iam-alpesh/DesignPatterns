using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example2
{
    // The Product class, which in this case is a House, that can consist of multiple parts.
    public class House
    {
        private List<object> _parts = new List<object>();

        // Tracking state for validation
        public int BedroomCount { get; set; }
        public int BathroomCount { get; set; }
        public bool HasGarage { get; set; }
        public bool HasGarden { get; set; }
        public bool HasSwimmingPool { get; set; }
        public bool HasFlooringMaterial { get; set; }

        // Add parts to the house
        public void Add(string part)
        {
            this._parts.Add(part);
        }

        // List the house components
        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }
            str = str.TrimEnd(',', ' ');
            return "House parts: " + str + "\n";
        }
    }
}
