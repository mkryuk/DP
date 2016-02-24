using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.FactoryMethod
{
    public class ToyFactory : IFactoryMethod
    {
        public IProduct GetToy(ToyType type)
        {
            switch (type)
            {
                case ToyType.Car:
                    Console.WriteLine("create car");
                    return new Car { Name = "a car" };
                case ToyType.Soldier:
                    Console.WriteLine("create soldier");
                    return new Soldier { Name = "a soldier" };
                default:
                    Console.WriteLine("unsupported type");
                    break;
            }
            return null;
        }
    }
}
