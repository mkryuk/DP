using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Composite
{
    public class Composite : INode
    {
        public string Name { get; set; }
        private List<INode> Nodes { get; set; } = new List<INode>();
        
        public void AddNode(INode node)
        {
            Nodes.Add(node);
        }

        public string GatherData()
        {
            var data = new StringBuilder();
            data.Append($"<{Name}>");
            foreach (var node in Nodes)
            {
                data.Append(node.GatherData());
            }
            data.Append($"</{Name}>");
            return data.ToString();
        }
    }
}
