using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Bridge
{
    public abstract class Abstraction
    {
        public IImplementor Implementor { get; set; }

        public virtual void Build()
        {
            Implementor.BuildArmor();
        }
    }
}
