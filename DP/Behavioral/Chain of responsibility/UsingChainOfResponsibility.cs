using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Chain_of_responsibility
{
    class UsingChainOfResponsibility
    {
        public static void Run()
        {
            var resources = new List<Resource>
            {
                new Resource {Type = ResourceType.Gold, Quantity = 2},
                new Resource {Type = ResourceType.Silver, Quantity = 1},
                new Resource {Type = ResourceType.Copper, Quantity = 4},
                new Resource {Type = ResourceType.Gold, Quantity = 5},
                new Resource {Type = ResourceType.Gold, Quantity = 1},
                new Resource {Type = ResourceType.Copper, Quantity = 2},
                new Resource {Type = ResourceType.Silver, Quantity = 7},
                new Resource {Type = ResourceType.Silver, Quantity = 5},
                new Resource {Type = ResourceType.Gold, Quantity = 1},
            };

            // Create all handlers
            var firstHandler = new GoldHandler();
            var secondHandler = new SilverHandler();
            var thirdHandler = new CopperHandler();

            // connect them into chain
            firstHandler.AddNext(secondHandler);
            secondHandler.AddNext(thirdHandler);

            // pass all resources via chain 
            // GoldHandler -> SilverHandler -> CopperHandler
            resources.ForEach(firstHandler.Handle);

            var handledGold = firstHandler.GetResult();
            var handledSilver = secondHandler.GetResult();
            var handledCopper = thirdHandler.GetResult();

            Console.WriteLine($"Gold: {handledGold.Quantity} points");
            Console.WriteLine($"Silver: {handledSilver.Quantity} points");
            Console.WriteLine($"Copper: {handledCopper.Quantity} points");
        }
    }
}
