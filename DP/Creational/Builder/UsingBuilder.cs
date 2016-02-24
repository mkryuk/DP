using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Builder
{
    public class UsingBuilder
    {
        public static void Run()
        {
            var director = new Director();
            Console.WriteLine("What kind of house do you want to create");
            Console.WriteLine("1 > Country");
            Console.WriteLine("2 > Modern");
            var choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    director.BuildHouse(new CountryHouseBuilder());
                    break;
                case "2":
                    director.BuildHouse(new ModernHouseBuilder());
                    break;
                default:
                    Console.WriteLine("wrong choise");
                    break;
            }
            var house = director.GetResult();
        }
    }
}
