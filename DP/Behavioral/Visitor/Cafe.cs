using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Visitor
{
    /// <summary>
    /// ConcreteElement
    /// Implements an Accept operation 
    /// </summary>
    public class Cafe : IAcceptor
    {
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }
        
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine($"Hello {visitor.GetType().Name} {visitor.Name} we're glad to see you");
            visitor.Visit(this);
            Console.WriteLine($"Please check it out");
            foreach (var room in Rooms)
            {
                visitor.Visit(room);
                if (visitor.AllDone)
                {
                    break;
                }
            }            
        }
    }
}
