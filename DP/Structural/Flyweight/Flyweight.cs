using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Flyweight
{
    public abstract class Flyweight
    {
        //we can use it with factory method or abstract factory
        public abstract Image LoadOrkImage();
        public abstract Image LoadGnomeImage();
    }
}
