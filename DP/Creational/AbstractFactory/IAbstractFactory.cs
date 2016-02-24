using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.AbstractFactory
{
    interface IAbstractFactory
    {
        IProduct GetSoldier();
        IProduct GetCar();
    }
}
