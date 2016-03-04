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
    /// associated with Assigned state of the Context
    /// </summary>
    class Assigned : IssueState
    {
        public override void Solve(Issue issue)
        {
            issue.AddHistory($"Issue \"{issue.Text}\" Solved");
            issue.SetIssueState(new Solved());
        }

        public override void New(Issue issue)
        {
            issue.AddHistory($"Issue returned to New state");
            issue.SetIssueState(new Created());
        }
    }
}
