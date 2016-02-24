using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Flyweight
{
    public class Ork : Unit
    {
        public Ork()
        {
            Name = "Ork";
            Avatar = Image.FromFile("../../Structural/Flyweight/ork.jpg");
        }

        public Ork(Flyweight flyweight)
        {
            Name = "Ork";
            Avatar = flyweight.LoadOrkImage();
        }
    }
}
