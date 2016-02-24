using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Facade
{
    public class House
    {
        public string Size { get; set; }
        public void Build()
        {
            Console.WriteLine($"You've built {Size} house");
        }
    }
}
