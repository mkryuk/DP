using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.FactoryMethod
{
    class UsingFactoryMethod
    {
        public static void Run()
        {
            var fm = new ToyFactory();
            IProduct toy = fm.GetToy(GetRandomType());
            Console.WriteLine($"We've created {toy.Name}");
        }

        public static ToyType GetRandomType()
        {
            var rand = new Random().Next(2);
            return rand == 0 ? ToyType.Car : ToyType.Soldier;
        }
    }
}
