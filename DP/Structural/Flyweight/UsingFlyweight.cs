using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Flyweight
{
    public class UsingFlyweight
    {
        public static void Run()
        {
            var orks = new List<Ork>();
            var gnomes = new List<Gnome>();
            var flyweight = new JpegFlyweight();
            var first = GC.GetTotalMemory(true);            
            Console.WriteLine($"Used memory: {first} bytes");
            var sw = new Stopwatch();
            sw.Start();
            //create 1000 units without flyweight
            for (var i = 0; i < 2000; i++)
            {
                orks.Add(new Ork());
                gnomes.Add(new Gnome());
            }
            sw.Stop();
            var second = GC.GetTotalMemory(true);
            Console.WriteLine($"Used memory: {second} bytes, 1st 1000: {second - first} bytes in: {sw.ElapsedMilliseconds} ms");
            sw.Reset();
            sw.Start();
            //create 1000 units using flyweight
            for (var i = 0; i < 2000; i++)
            {
                orks.Add(new Ork(flyweight));
                gnomes.Add(new Gnome(flyweight));
            }
            sw.Stop();
            var third = GC.GetTotalMemory(true);
            Console.WriteLine($"Used memory: {third} bytes, 2nd 1000: {third - second} bytes in: {sw.ElapsedMilliseconds} ms");
        }
    }
}
