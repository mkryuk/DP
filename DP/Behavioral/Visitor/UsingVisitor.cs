using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Visitor
{
    public class UsingVisitor
    {
        public static void Run()
        {
            var cafe = new Cafe
            {
                Name = "The best cafe ever",
                Rooms = new List<Room>
                {
                    new Room {Name = "Orange", Seats = 3 },
                    new Room {Name = "Green", Seats = 1 },
                    new Room {Name = "Blue", Seats = 2 }
                }
            };

            var visitors = new List<Guest>
            {
                new Guest { Name= "Isabell" },
                new Guest { Name= "Mark" },
                new Guest { Name= "Iris" },
                new Guest { Name= "Ann" },
                new Guest { Name= "John" },
                new Guest { Name= "Dany" },
                new Guest { Name= "Sean" }
            };

            var inspector = new Inspector { Name = "Freimuth" };

            // Cafe accepts visitors
            visitors.ForEach(cafe.Accept);

            // Cafe accepts inspector
            cafe.Accept(inspector);
        }
    }
}
