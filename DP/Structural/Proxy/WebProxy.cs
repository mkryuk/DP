using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Proxy
{
    public class WebProxy : IWeb
    {
        private Dictionary<string, string> _cache = new Dictionary<string, string>();
        private readonly IWeb _webServer;

        public WebProxy(IWeb webServer)
        {
            _webServer = webServer;
        }
        public string Get(string url)
        {
            Console.WriteLine($"PROXY Get => {url}");
            if (!_cache.ContainsKey(url))
            {
                _cache[url] = _webServer.Get(url);
            }
            //we can modify or add data here
            return _cache[url];
        }

        public string Get(string url, bool update)
        {
            if (update)
            {
                _cache[url] = _webServer.Get(url);
            }
            return Get(url);
        }

        public void Post(string url, string data)
        {
            Console.WriteLine($"PROXY Post => {url}");
            //we can modify or add posted data here
            _webServer.Post(url, data);
        }
    }
}
