using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Visitor
{
    /// <summary>
    /// Defines an Accept operation 
    /// that takes a visitor as an argument
    /// </summary>
    public interface IAcceptor
    {        
        void Accept(IVisitor visitor);
    }
}
