using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.Builder
{
    public class Director
    {
        private Builder _builder;
        public void BuildHouse(Builder builder)
        {
            _builder = builder;
            _builder.CreateBasement();
            _builder.CreateWalls();
            _builder.CreateRoof();
            _builder.InstallWindows();
        }

        public House GetResult()
        {
            return _builder?.GetResult();
        }
    }
}
