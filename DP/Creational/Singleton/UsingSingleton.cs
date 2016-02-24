using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Singleton
{
    class UsingSingleton
    {
        public static void Run()
        {
            var singleton = Singleton.GetInstance();
            singleton.Data = "test data";
            var secondInstance = Singleton.GetInstance();
            Console.WriteLine($"{secondInstance.Data}");
            secondInstance.Data = "changed data";
            Console.WriteLine($"{singleton.Data}");
        }
    }
}
