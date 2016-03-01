using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Memento
{
    /// <summary>
    /// Creates a memento containing a snapshot ot its current internal state
    /// Uses the memento to restore its internal state
    /// </summary>
    public abstract class Originator
    {
        public abstract void RestoreState(Memento memento);
        public abstract Memento SaveState();
    }
}
