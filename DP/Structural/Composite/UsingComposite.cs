using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Composite
{
    public class UsingComposite
    {
        public static void Run()
        {
            INode root = new Composite() {Name = "html"};
            var body = new Composite() {Name = "body"};
            var head = new Leaf() {Name = "head", Data = "Using composite"};
            root.AddNode(head);
            body.AddNode(new Leaf() {Name = "h1", Data = "This is using component sample"});
            root.AddNode(body);            
            Console.WriteLine(root.GatherData());

            //we cannot add node to leaf
            var leaf = new Leaf();
            leaf.AddNode(new Leaf());

        }
    }
}
