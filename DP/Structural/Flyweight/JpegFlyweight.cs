using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Flyweight
{
    class JpegFlyweight : Flyweight
    {
        private Dictionary<Type, Image> _storage =  new Dictionary<Type, Image>();
        public override Image LoadOrkImage()
        {
            if (!_storage.ContainsKey(typeof(Ork)))
            {
                _storage.Add(typeof (Ork), Image.FromFile("../../Structural/Flyweight/ork.jpg"));
            }
            return _storage[typeof (Ork)];
        }

        public override Image LoadGnomeImage()
        {
            if (!_storage.ContainsKey(typeof(Ork)))
            {
                _storage.Add(typeof(Ork), Image.FromFile("../../Structural/Flyweight/gnome.jpg"));
            }
            return _storage[typeof(Ork)];
        }
    }
}
