using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Adapter
{
    class Adapter : IDatabase
    {
        private readonly SpecificDatabase _adaptee;
        public Adapter(SpecificDatabase adaptee)
        {
            Console.WriteLine("Wrap specific database api into adapter");
            _adaptee = adaptee;
        }
        public void Request()
        {
            Console.WriteLine("Convert request to specific request");
            _adaptee.SpecificRequest();
        }
    }
}
