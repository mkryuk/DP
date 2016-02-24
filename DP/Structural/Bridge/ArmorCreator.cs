using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Bridge
{
    class ArmorCreator : Abstraction
    {
        public override void Build()
        {
            Console.WriteLine("We are going to create some armor");
            Implementor.BuildArmor();
        }
    }
}
