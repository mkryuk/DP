using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Singleton
{
    public class Singleton
    {
        public string Data { get; set; }
        private static Singleton _object;
        private static readonly object locker = new object();
        private Singleton(){}

        public static Singleton GetInstance()
        {
            // thread safe singleton
            lock (locker)
            {
                return _object ?? (_object = new Singleton());
            }
        }
    }
}
