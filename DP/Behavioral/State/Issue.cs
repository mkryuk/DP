using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.State
{
    /// <summary>
    /// Context.
    /// 
    /// Maintains an instance of a ConcreteState
    /// that defines the current state.
    /// All methods delegates requests 
    /// to the current State object.
    /// 
    /// Context is the primary interface for clients. 
    /// Clients can configure a context
    /// with State objects.
    /// Once a context is configured, its clients don't have
    /// to deal with the State objects directly.
    /// </summary>
    public class Issue
    {
        private IssueState State { get; set; }
        public string Text { get; set; }
        public string Feedback { get; set; }
        protected List<string> History { get; set; } = new List<string>();
        public string AssignedTo { get; set; }

        public Issue()
        {  
            // Set initial state to Created                      
            State = new Created();
            History.Add("Issue created");
        }

        public void Assign(string assignedTo)
        {
            State.Assign(assignedTo, this);
        }

        public void Solve()
        {
            State.Solve(this);
        }

        public void AddFeedback(string text)
        {
            State.Feedback(text, this);
        }

        public void Close()
        {
            State.Close(this);
        }

        public void Decline()
        {
            State.Decline(this);
        }

        public virtual void SetIssueState(IssueState state)
        {
            State = state;
        }

        public virtual string GetState()
        {
            return $"Current state: {State.GetType().Name}";
        }

        public virtual void AddHistory(string line)
        {
            History.Add(line);
        }

        public void PrintHistory()
        {
            History.ForEach(Console.WriteLine);
        }
    }
}
