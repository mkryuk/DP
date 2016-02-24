using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Chain_of_responsibility
{
    class SilverHandler : Handler
    {
        public override void Handle(Resource resource)
        {
            //We can handle the resource 
            if (resource.Type == ResourceType.Silver)
            {
                Console.WriteLine($"We handled {resource.Quantity} points of {Enum.GetName(typeof(ResourceType), resource.Type)}");
                Result.Quantity += resource.Quantity;
                return;
            }
            //otherwise we pass it to the next handler
            NextHandler.Handle(resource);
        }
    }
}
