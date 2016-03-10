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
    /// for concrete type of visitor
    /// </summary>
    public class Room : IAcceptor
    {
        public string Name { get; set; }
        private int _seats;
        public int Seats
        {
            get { return _seats; }
            set
            {
                _seats = value;
                SeatsLeft = value;
            }
        }
        public int SeatsLeft { get; set; }       
                
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
