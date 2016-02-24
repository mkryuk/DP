using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Adapter
{
    public class UsingAdapter
    {
        public static void Run()
        {
            IDatabase database = new Adapter(new SpecificDatabase());
            database.Request();
        }
    }
}
