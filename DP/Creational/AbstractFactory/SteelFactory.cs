using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.AbstractFactory
{
    class SteelFactory : IAbstractFactory
    {
        public SteelFactory()
        {
            Console.WriteLine("We've created steel factory");
        }
        public IProduct GetSoldier()
        {
            Console.WriteLine("return steel soldier");
            return new SteelSoldier();
        }

        public IProduct GetCar()
        {
            Console.WriteLine("return steel car");
            return new SteelCar();
        }
    }
}
