using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DP.Behavioral.Observer
{
    class UsingObserver
    {
        public static void Run()
        {
            // Create concrete observers
            var observers = new List<IObserver>
            {
                new Seller {DesiredRate = 9 },
                new Seller {DesiredRate = 10 },
                new Buyer {DesiredRate =  7},
                new Buyer {DesiredRate = 8 }
            };

            // Create Concrete subject
            var bank = new Bank();
            // Attach all observers to the subject
            observers.ForEach(o => bank.Attach(o));

            for (var i = 0; i < 10; i++)
            {
                // change the state of the subject
                bank.XRateChanged();
                Thread.Sleep(1000);
            }
        }
    }
}
