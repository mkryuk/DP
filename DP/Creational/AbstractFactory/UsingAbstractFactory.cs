using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.AbstractFactory
{
    class UsingAbstractFactory
    {
        public static void Run()
        {
            IAbstractFactory af = null;
            Console.WriteLine("What kind of factory do you want to create");
            Console.WriteLine("1 > Wooden");
            Console.WriteLine("2 > Steel");
            var choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    af = new WoodenFactory();
                    break;
                case "2":
                    af = new SteelFactory();
                    break;
                default:
                    Console.WriteLine("wrong choise");
                    break;
            }
            if (af == null) return;
            var toy = af.GetCar();
            Console.WriteLine($"in result we have {toy.Name}");
        }
    }
}
