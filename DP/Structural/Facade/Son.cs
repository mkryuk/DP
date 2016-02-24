using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Facade
{
    public class Son
    {
        public string Name { get; set; }
        public void Foster()
        {
            Console.WriteLine($"You've foster a good sone, his name is {Name}");
        }
    }
}
