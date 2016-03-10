using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Visitor
{
    /// <summary>
    /// Defines a Visit operation 
    /// that will visit Concrete element
    /// </summary>
    public interface IVisitor
    {
        string Name { get; set; }
        bool AllDone { get; set; }

        void Visit(Cafe cafe);
        void Visit(Room room);
    }
}
