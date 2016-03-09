using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.TemplateMethod
{
    public class UsingTemplateMethod
    {
        public static void Run()
        {
            var formatter = new JsonMessageFormatter()
            {
                From = "sender",
                To = "recipient",
                Title = "Test title",
                Message = "This is a test message"            
            };            

            Console.WriteLine(formatter.GetResult());
        }
    }
}
