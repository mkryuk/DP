using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Iterator
{
    /// <summary>
    /// Concrete Iterable
    /// </summary>
    class ComplexObject : Iterable
    {
        public List<string> Items { get; set; } = new List<string>();
        public ComplexObject Child { get; set; }
        public override Iterator GetIterator()
        {
            return new ComplexObjectIterator(this);
        }

        public override int Count()
        {
            return Items.Count + Child?.Count() ?? Items.Count;
        }
    }
}
