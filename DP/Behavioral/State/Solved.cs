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
    /// associated with Solved state of the Context
    /// </summary>
    class Solved : IssueState
    {
        public override void Feedback(string text, Issue issue)
        {
            issue.Feedback = text;
            issue.AddHistory("Feedback added");
            issue.SetIssueState(new Feedback());
        }

        public override void Close(Issue issue)
        {
            issue.AddHistory("Issue closed");
            issue.SetIssueState(new Closed());
        }
    }
}
