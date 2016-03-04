using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.State
{
    /// <summary>
    /// ConcreteState subclass
    /// Implements a behaviour 
    /// associated with Closed state of the Context
    /// </summary>
    public class Closed : IssueState
    {
        // We cannot move anyway from closed
    }
}
