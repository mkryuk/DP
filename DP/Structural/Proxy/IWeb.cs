using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Proxy
{
    public interface IWeb
    {
        string Get(string url);
        void Post(string url, string data);
    }
}
