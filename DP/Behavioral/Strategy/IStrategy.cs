using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Strategy
{
    /// <summary>
    /// Declares an interface common to all supported strategies. 
    /// Context uses this interface to call the algorithm defined by a
    /// ConcreteStrategy.
    /// </summary>
    public interface IStrategy
    {
        void ImplementStrategy();
    }
}
