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
    /// associated with Created state of the Context
    /// </summary>
    public class Created : IssueState
    {
        public override void Decline(Issue issue)
        {
            issue.AddHistory("Issue declined");
            issue.SetIssueState(new Declined());
        }
        public override void Assign(string assignedTo, Issue issue)
        {
            issue.AssignedTo = assignedTo;
            issue.AddHistory($"Assigned to {issue.AssignedTo}");
            issue.SetIssueState(new Assigned());
        }
    }
}
