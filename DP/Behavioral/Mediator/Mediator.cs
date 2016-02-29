using System.Collections.Generic;

namespace DP.Behavioral.Mediator
{
    /// <summary>
    /// Abstract Mediator
    /// Defines an interface 
    /// for communicating with Colleague object
    /// </summary>
    public abstract class Mediator
    {
        protected List<Colleague> Colleagues { get; set; } = new List<Colleague>();

        public void AddColleague(Colleague colleague)
        {
            Colleagues.Add(colleague);
        }
        public abstract void Send(string message, Colleague colleague);
    }
}
