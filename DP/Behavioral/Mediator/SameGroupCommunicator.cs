using System.Collections.Generic;
using System.Linq;

namespace DP.Behavioral.Mediator
{
    /// <summary>
    /// Concrete Mediator
    /// implements cooperative bahaviour 
    /// by coordinating Colleague object    
    /// Knows and maintains its colleagues
    /// </summary>
    public class SameGroupCommunicator : Mediator
    {
        public override void Send(string message, Colleague colleague)
        {
            // Send message to all colleagues, except sender, in the same group
            Colleagues
                // Exclude sender from message receivers
                .Except(new List<Colleague> { colleague })
                .Where(item => item.GroupName == colleague.GroupName).ToList()
                .ForEach(item => item.Receive(message));
        }
    }
}
