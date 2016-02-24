using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Builder
{
    public class ModernHouseBuilder : Builder
    {
        public override void CreateRoof()
        {
            Console.WriteLine("add glass roof");
            Result.AddPart("glass roof");
        }

        public override void CreateWalls()
        {
            Console.WriteLine("build concrete walls");
            Result.AddPart("concrete walls");
        }

        public override void InstallWindows()
        {
            Console.WriteLine("install plastic windows");
            Result.AddPart("plastic windows");
        }

        public override void CreateBasement()
        {
            Console.WriteLine("build concrete foundation");
            Result.AddPart("concrete foundation");
        }       
    }
}
