using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Observer
{
    /// <summary>
    /// Concrete Observer
    /// maintains a reference to a 
    /// Concrete Subject object (Bank) in our case
    /// stores state that should stay consistent with the subject
    /// implements the IObserver updating interface 
    /// to keep its state consistent with the subject
    /// </summary>
    public class Buyer : IObserver
    {
        public decimal DesiredRate { get; set; }
        public void Update(ISubject subject)
        {
            var bank = subject as Bank;
            if ( bank?.Rate <= DesiredRate )
            {
                Console.WriteLine($"My desired rate is {DesiredRate} I BUY the currency");
            }
        }
    }
}
