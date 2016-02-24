using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Composite
{
    public class Leaf : INode
    {
        public string Name { get; set; }
        public string Data { get; set; }

        public void AddNode(INode node)
        {
            Console.WriteLine("cannot add to leaf");
        }

        public string GatherData()
        {
            return $"<{Name}>{Data}</{Name}>";
        }
    }
}
