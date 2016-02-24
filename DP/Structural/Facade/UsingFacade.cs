using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Facade
{
    public class UsingFacade
    {
        public static void Run()
        {
            var lifeFacade = new Facade();
            lifeFacade.HaveANiceLife("Nick", "large", "cherry");
        }
    }
}
