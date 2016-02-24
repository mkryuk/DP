using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Flyweight
{
    public class Gnome : Unit
    {
        public Gnome() 
        {
            Name = "Gnome";
            Avatar = Image.FromFile("../../Structural/Flyweight/gnome.jpg");
        }

        public Gnome(Flyweight flyweight)
        {
            Name = "Gnome";
            Avatar = flyweight.LoadGnomeImage();
        }
    }
}
