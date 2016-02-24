using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Bridge
{
    class SteelArmorBuilder : IImplementor
    {
        public void BuildArmor()
        {
            Console.WriteLine("Steel armor built");
        }
    }
}
