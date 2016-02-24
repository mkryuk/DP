using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Decorator
{
    public abstract class Component
    {
        public string Name { get; set; }
        public abstract void WhoAmI();
    }
}
