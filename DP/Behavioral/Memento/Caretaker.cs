using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Memento
{
    /// <summary>
    /// Responsible for memento's safekeeping
    /// Never operates on or examines the content of a memento
    /// </summary>
    class Caretaker
    {
        private Stack<Memento> States { get; } = new Stack<Memento>();

        public void SaveState(Memento memento)
        {
            States.Push(memento);
        }

        public Memento RestoreState()
        {
            return States.Pop();
        }
    }
}
