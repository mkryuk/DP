using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Facade
{
    public class Tree
    {
        public string Kind { get; set; }
        public void Grow()
        {
            Console.WriteLine($"You've grew a {Kind} tree");
        }
    }
}
