using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Decorator
{
    class Superman : Decorator
    {
        public Superman(Component component) : base(component)
        {
        }

        public override void WhoAmI()
        {
            base.WhoAmI();
            Console.WriteLine("and i am a Superman!!!");
        }
    }
}
