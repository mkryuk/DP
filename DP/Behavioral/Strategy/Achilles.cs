using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Strategy
{
    /// <summary>
    /// Context
    /// Configured with a ConcreteStrategy object.
    /// Maintains a reference to a Strategy object.
    /// May define an interface that lets Strategy access its data.
    /// </summary>
    class Achilles
    {
        private IStrategy Strategy { get; set; }

        public Achilles(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            Strategy = strategy;
        }
       
        public void StartBattle()
        {
            Strategy.ImplementStrategy();
        }
    }
}
