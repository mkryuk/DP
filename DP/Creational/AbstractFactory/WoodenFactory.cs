using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.AbstractFactory
{
    class WoodenFactory : IAbstractFactory
    {
        public WoodenFactory()
        {
            Console.WriteLine("We've created wooden factory");
        }
        public IProduct GetSoldier()
        {
            Console.WriteLine("return wooden soldier");
            return new WoodenSoldier();
        }

        public IProduct GetCar()
        {
            Console.WriteLine("return wooden car");
            return new WoodenCar();
        }
    }
}
