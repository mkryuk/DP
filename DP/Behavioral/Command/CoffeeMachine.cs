using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Command
{
    /// <summary>
    /// Receiver
    /// </summary>
    public class CoffeeMachine
    {
        private List<string> Drink { get; set; } = new List<string>();       

        public void MakeEspresso()
        {
            Drink.Add("espresso");
            Console.WriteLine("Espresso done");
        }

        public void AddMilkFoam()
        {
            Drink.Add("foamed milk");
            Console.WriteLine("Foamed milk added");
        }

        public void AddSteamedMilk()
        {
            Drink.Add("steamed milk");
            Console.WriteLine("Steamed milk added");
        }

        public void AddIceCream()
        {
            Drink.Add("ice cream");
            Console.WriteLine("Ice cream added");
        }

        public void AddIce()
        {
            Drink.Add("ice");
            Console.WriteLine("Ice added");
        }

        public void AddSugar(uint gramms)
        {
            Drink.Add($"{gramms} gramms of sugar");
            Console.WriteLine($"{gramms} gramms of sugar added");
        }

        public void AddWater()
        {
            Drink.Add("water");
            Console.WriteLine("Water added");
        }        

        public List<string> GetResult()
        {
            var drink = Drink?.ToList();
            // Clean the coffee machine
            Drink = new List<string>();
            return drink;
        }
    }
}
