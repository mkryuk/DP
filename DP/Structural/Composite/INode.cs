using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Composite
{
    public interface INode
    {
        void AddNode(INode node);
        //void RemoveNode(INode node);
        //void GetChild();
        string GatherData();
    }
}
