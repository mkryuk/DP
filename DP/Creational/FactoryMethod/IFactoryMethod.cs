using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Creational.FactoryMethod
{
    public enum ToyType
    {
        Car,
        Soldier
    }
    public interface IFactoryMethod
    {
        IProduct GetToy(ToyType type);
    }
}
