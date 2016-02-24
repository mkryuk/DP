using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Decorator
{
    public abstract class Decorator : Component
    {
        protected Component DecoratedComponent { get; set; }

        protected Decorator(Component component)
        {
            DecoratedComponent = component;
        }

        public override void WhoAmI()
        {
            DecoratedComponent.WhoAmI();
        }

    }
}
