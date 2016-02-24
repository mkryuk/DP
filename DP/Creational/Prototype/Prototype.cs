using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Prototype
{
    public abstract class Prototype
    {
        public virtual Prototype Clone()
        {
            Console.WriteLine("clone Prototype object");
            return (Prototype) this.MemberwiseClone();
        }
    }
}
