using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Decorator
{
    class Human : Component
    {
        public override void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
