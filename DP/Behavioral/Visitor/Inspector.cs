using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Visitor
{    
    public class Inspector : IVisitor
    {
        public string Name { get; set; }
        public bool AllDone { get; set; }
            
        /// <summary>
        /// Implements concrete logic for visiting Cafe
        /// </summary>
        /// <param name="cafe"></param>
        public void Visit(Cafe cafe)
        {
            Console.WriteLine($"Hi, i'll check your rooms");
        }

        /// <summary>
        /// Implements concrete logic for visiting Room
        /// </summary>
        /// <param name="room"></param>
        public void Visit(Room room)
        {
            Console.WriteLine($"Check {room.Name} room");
        }
    }
}
