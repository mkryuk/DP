using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Observer
{
    /// <summary>
    /// Observer interface 
    /// for objects that should be 
    /// notified for changes in a Subject
    /// </summary>
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
