using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Builder
{
    public abstract class Builder
    {
        protected House Result { get; }

        protected Builder()
        {
            Result = new House();
        }
        public abstract void CreateRoof();
        public abstract void CreateWalls();
        public abstract void InstallWindows();
        public abstract void CreateBasement();

        public House GetResult()
        {
            Console.WriteLine("we've created house with");
            Result.Print();
            return Result;
        }
    }
}
