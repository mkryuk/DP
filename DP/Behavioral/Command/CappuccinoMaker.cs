using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Command
{
    /// <summary>
    /// Concrete command
    /// </summary>
    public class CappuccinoMaker : ICommand
    {
        private readonly CoffeeMachine _coffeeMachine;
        private readonly uint _sugar;

        public CappuccinoMaker(CoffeeMachine coffeeMachine, uint sugar = 0)
        {
            _coffeeMachine = coffeeMachine;
            _sugar = sugar;
        }
        public void Execute()
        {
            Console.WriteLine("We are going to execute cappuccino program");
            _coffeeMachine.MakeEspresso();
            _coffeeMachine.AddSteamedMilk();
            _coffeeMachine.AddMilkFoam();
            if (_sugar > 0)
            {
                _coffeeMachine.AddSugar(_sugar);
            }
        }

        public List<string> GetResult()
        {
            return _coffeeMachine.GetResult();
        }
    }
}
