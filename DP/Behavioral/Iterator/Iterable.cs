using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Iterator
{
    /// <summary>
    /// Abstract Iterable
    /// </summary>
    public abstract class Iterable
    {
        public abstract Iterator GetIterator();
        public abstract int Count();
    }
}
