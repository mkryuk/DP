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
    /// associated with Feedback state of the Context
    /// </summary>
    public class Feedback : IssueState
    {
        public override void Close(Issue issue)
        {
            issue.AddHistory("Issue closed");
            issue.SetIssueState(new Closed());
        }

        public override void Assign(string assignedTo, Issue issue)
        {
            issue.AddHistory($"Assigned to {assignedTo}");
            issue.SetIssueState(new Assigned());
        }
    }
}
