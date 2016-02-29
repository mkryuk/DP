using System.Collections.Generic;
using System.Linq;

namespace DP.Behavioral.Mediator
{
    public class UsingMediator
    {
        public static void Run()
        {
            // Create concrete Mediator
            var mediator = new SameGroupCommunicator();

            // Create colleagues and connect them to Mediator
            var colleagues = new List<Colleague>
            {
                // Group Alpha
                new Colleague {Name = "Alex", GroupName = Group.Alpha, Mediator = mediator},
                new Colleague {Name = "Alexandr", GroupName = Group.Alpha, Mediator = mediator},
                new Colleague {Name = "Ann", GroupName = Group.Alpha, Mediator = mediator},

                //Group Beta
                new Colleague {Name = "Barbara", GroupName = Group.Beta, Mediator = mediator},
                new Colleague {Name = "Bill", GroupName = Group.Beta, Mediator = mediator},
                new Colleague {Name = "Borys", GroupName = Group.Beta, Mediator = mediator}
           };

            // Connect Mediator with colleagues
            colleagues.ForEach(item => mediator.AddColleague(item));

            // Send message to all colleagues in group Alpha
            colleagues.First(item => item.GroupName == Group.Alpha)
                .Send("Hello to all Alphas");

            // Send message to all colleagues in group Beta
            colleagues.First(item => item.GroupName == Group.Beta)
                .Send("Hello to all Betas");

        }
    }
}
