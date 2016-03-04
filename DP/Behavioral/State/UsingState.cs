using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.State
{
    public class UsingState
    {
        public static void Run()
        {
            // Create new issue
            var issue = new Issue {Text = "It's a terrible bug here"};
            // Checkout current state
            Console.WriteLine(issue.GetState());
            // Try to close issue immidiately
            issue.Close();
            // Assign it to Max
            issue.Assign("Max");
            issue.Solve();
            issue.AddFeedback("I've fixed the bug");
            issue.Close();
            // Try to decline closed issue
            issue.Decline();
            Console.WriteLine(issue.GetState());

            Console.WriteLine("History:");
            issue.PrintHistory();

        }
    }
}
