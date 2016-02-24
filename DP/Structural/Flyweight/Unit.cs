using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Flyweight
{
    public abstract class Unit
    {
        public string Name { get; set; }
        public Image Avatar { get; set; }
    }
}
