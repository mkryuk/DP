using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Prototype
{
    public class ComplexType : Prototype
    {
        public string Name { get; set; }
        public List<string> Data { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine("Data: ");
            Data.ForEach(Console.WriteLine);
        }

        // override this method for complex type
        public override Prototype Clone()
        {
            Console.WriteLine("clone ComplexType object");
            var copy = (ComplexType)base.Clone();
            copy.Data = new List<string>(copy.Data);
            return copy;
        }
    }
}
