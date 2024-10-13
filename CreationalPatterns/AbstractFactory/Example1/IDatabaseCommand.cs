using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Example1
{
    public interface IDatabaseCommand
    {
        void Execute(string query);
    }

}
