using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Visitor
{
    public class Guest : IVisitor
    {
        public string Name { get; set; }
        public bool AllDone { get; set; }
        public void Visit(IAcceptor acceptor)
        {
            acceptor.Accept(this);
        }

        /// <summary>
        /// Implements concrete logic for visiting Cafe
        /// </summary>
        /// <param name="cafe"></param>
        public void Visit(Cafe cafe)
        {
            Console.WriteLine("Hi, do you have a free seat?");
        }

        /// <summary>
        /// Implements concrete logic for visiting Room
        /// </summary>
        /// <param name="room"></param>
        public void Visit(Room room)
        {
            if (room.SeatsLeft > 0)
            {
                Console.WriteLine($"I found a seat {room.SeatsLeft} in {room.Name} room");
                room.SeatsLeft--;
                AllDone = true;
            }
        }
    }
}
