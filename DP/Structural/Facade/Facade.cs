using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Facade
{
    public class Facade
    {
        public void HaveANiceLife(string sonName, string buildSize, string treeKind)
        {
            var tree = new Tree() {Kind = treeKind};
            tree.Grow();

            var house = new House() {Size = buildSize};
            house.Build();

            var son = new Son() {Name = sonName};
            son.Foster();

            Console.WriteLine("You are absolutely happy!");
        }
    }
}
