using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Observer
{
    /// <summary>
    /// Concrete Subject
    /// knows its observers
    /// stores state of interest to ConcreteObservers objects
    /// sends notification to its observers when its state changes
    /// </summary>
    public class Bank : ISubject
    {
        private List<IObserver> Observers { get; } = new List<IObserver>();
        private readonly Random _random = new Random();
        public decimal Rate { get; set; } = 9;

        public void XRateChanged()
        {
            // Rate changes randomly
            Rate += _random.Next(-2, 3);
            // Notify all observers
            Notify();
        }

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (Observers.Contains(observer))
            {
                Observers.Remove(observer);
            }
        }

        public void Notify()
        {            
            Console.WriteLine($"Rate changed!!! New rate is {Rate}");
            Observers.ForEach(item => item.Update(this));
        }
    }
}
