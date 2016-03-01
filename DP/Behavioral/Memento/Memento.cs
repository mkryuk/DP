using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Memento
{
    /// <summary>
    /// Abstract Memento
    /// Stores abstract state of the Originator object
    /// </summary>
    public abstract class Memento
    {
        protected object State { get; set; }

        public virtual object GetState()
        {
            return State;
        }

        public virtual void SetState(object state)
        {
            State = state;
        }
    }
}
