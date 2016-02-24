using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Decorator
{
    class Vampire : Decorator
    {
        public Vampire(Component component) : base(component)
        {
        }

        public override void WhoAmI()
        {
            base.WhoAmI();
            Console.WriteLine("but i'm a vampire also :)");
        }
    }
}
