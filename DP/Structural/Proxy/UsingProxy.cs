using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Proxy
{
    public class UsingProxy
    {
        public static void Run()
        {
            IWeb webServer = new WebServer();
            IWeb webProxy = new WebProxy(webServer);
            //Add data to web server
            webServer.Post("google.com", "This is data from Google");
            webServer.Post("microsoft.com", "This is data from Microsoft");
            webServer.Post("news.ua", "This is news from news.ua");

            //Try to get data via proxy
            Console.WriteLine(webProxy.Get("google.com"));
            Console.WriteLine(webProxy.Get("microsoft.com"));
            Console.WriteLine(webProxy.Get("news.ua"));

            //Add data via proxy
            webProxy.Post("bbc.com", "This is data from bbc.com");

            //Get data via proxy
            Console.WriteLine(webProxy.Get("bbc.com"));

            //Modify data via web server
            webServer.Post("google.com", "CHANGED data from Google");

            //Try to get data via proxy (old cache)
            Console.WriteLine(webProxy.Get("google.com"));

            //Update cache in web proxy
            Console.WriteLine(((WebProxy)webProxy).Get("google.com", true));
        }
    }
}
