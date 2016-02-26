using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Iterator
{
    /// <summary>
    /// Abstract Iterator
    /// </summary>
    public abstract class Iterator
    {
        public abstract object Current();
        public abstract object Next();
        public abstract bool HasNext();
        public abstract bool IsDone();
        public abstract void Reset();
    }
}
