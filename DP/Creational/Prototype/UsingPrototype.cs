using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Prototype
{
    class UsingPrototype
    {
        public static void Run()
        {
            var data = new ComplexType
            {
                Name = "Initial",
                Data = new List<string> {"one", "two", "three"}
            };
            var copy = (ComplexType)data.Clone();
            copy.Name = "Copy";
            copy.Data.Add("test");
            Console.WriteLine("original type");
            data.Print();
            copy.Print();
        }
    }
}
