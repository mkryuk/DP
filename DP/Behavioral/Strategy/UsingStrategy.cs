using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Strategy
{
    public class UsingStrategy
    {
        public static void Run()
        {
            // Create concrete instance of strategy
            var strategy = new RunAwayStrategy();
            // Configure context with 
            // concrete instance of strategy object
            var achilles = new Achilles(strategy);
            // uses concrete strategy
            achilles.StartBattle();
        }
    }
}
