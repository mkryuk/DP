using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Proxy
{
    public class WebServer : IWeb
    {
        private readonly Dictionary<string, string> _data = new Dictionary<string, string>();
        public string Get(string url)
        {
            Console.WriteLine($"WEBSERVER Get => {url}");
            return _data[url];
        }

        public void Post(string url, string data)
        {
            Console.WriteLine($"WEBSERVER Post {url} => {data}");
            _data[url] = data;
        }
    }
}
