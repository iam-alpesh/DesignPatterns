using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderPattern.Example3
{
    public class Car
    {
        private List<string> _parts = new List<string>();

        public bool HasEngine { get; set; }
        public bool HasSeats { get; set; }
        public bool HasGPS { get; set; }
        public bool HasAirbags { get; set; }

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            return "Car parts: " + string.Join(", ", _parts) + "\n";
        }
    }

}
