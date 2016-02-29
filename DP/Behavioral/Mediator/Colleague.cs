using System;

namespace DP.Behavioral.Mediator
{
    public enum Group
    {
        Alpha,
        Beta
    }

    /// <summary>
    /// Colleague class
    /// Each Colleague class knows its Mediator object
    /// Each Colleague communicates with its Mediator
    /// </summary>
    public class Colleague
    {
        public Mediator Mediator { get; set; }
        public Group GroupName { get; set; }
        public string Name { get; set; }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sent \"{message}\"");
            Mediator.Send(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} received \"{message}\"");
        }
    }
}