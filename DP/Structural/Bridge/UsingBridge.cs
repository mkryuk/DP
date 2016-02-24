using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Bridge
{
    public class UsingBridge
    {
        public static void Run()
        {
            Abstraction armorCreator = new ArmorCreator();
            Console.WriteLine("What kind of armor do you want to create");
            Console.WriteLine("1 > Adamant");
            Console.WriteLine("2 > Steel");
            var choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    armorCreator.Implementor = new AdamantArmorBuilder();
                    break;
                case "2":
                    armorCreator.Implementor = new SteelArmorBuilder();
                    break;
                default:
                    Console.WriteLine("wrong choise");
                    break;
            }
            armorCreator.Build();
        }
    }
}
