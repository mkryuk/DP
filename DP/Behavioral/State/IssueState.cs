using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.State
{
    /// <summary>
    /// Defines an interface for encapsulating the behaviour 
    /// associated with a particular state of the context
    /// </summary>
    public class IssueState
    {
        public virtual void New(Issue issue)
        {
            NotAllowed("New");
        }       
        public virtual void Assign(string assignedTo, Issue issue)
        {
            NotAllowed("Assign");
        }
        public virtual void Solve(Issue issue)
        {
            NotAllowed("Solve");
        }
        public virtual void Feedback(string text, Issue issue)
        {
            NotAllowed("Feedback");
        }
        public virtual void Close(Issue issue)
        {
            NotAllowed("Close");
        }
        public virtual void Decline(Issue issue)
        {
            NotAllowed("Decline");
        }       

        private void NotAllowed(string name)
        {
            Console.WriteLine($"{name} operation is not allowed from {this.GetType().Name} state");
        }

    }
}
