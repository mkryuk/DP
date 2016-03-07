using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Strategy
{
    /// <summary>
    /// ConcreteStrategy
    /// Implements the algorithm using the Strategy interface.
    /// </summary>
    class RunAwayStrategy : IStrategy
    {
        public void ImplementStrategy()
        {
            Console.WriteLine("We are spartans! \n" +
                              "But we are smart spartans!! \n" +
                              "And now it's time to run away!!!");
        }
    }
}
