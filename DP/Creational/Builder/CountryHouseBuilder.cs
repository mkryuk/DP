using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Builder
{
    public class CountryHouseBuilder : Builder
    {
        public override void CreateRoof()
        {
            Console.WriteLine("add tile roof");
            Result.AddPart("tile roof");
        }

        public override void CreateWalls()
        {
            Console.WriteLine("build wooden walls");
            Result.AddPart("wooden walls");
        }

        public override void InstallWindows()
        {
            Console.WriteLine("install wide windows");
            Result.AddPart("wide windows with shutters");
        }

        public override void CreateBasement()
        {
            Console.WriteLine("build deep basement");
            Result.AddPart("deep basement");
        }
    }
}
