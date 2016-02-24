using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Command
{
    public class UsingCommand
    {
        public static void Run()
        {
            // Receiver            
            var coffeeMachine = new CoffeeMachine();            
            
            // Create concrete command
            // Add Receiver to the command                                    
            ICommand cappucchinoMaker = new CappuccinoMaker(coffeeMachine);
            ICommand americanoMaker = new AmericanoMaker(coffeeMachine, 20);

            // Invoker
            var barista = new Barista();
            barista.AddCommand(cappucchinoMaker);
            barista.AddCommand(americanoMaker);
            barista.AddCommand(cappucchinoMaker);

            // Execute all commands
            barista.MakeCoffee();
            Console.WriteLine();

            barista.GetDrinks().ForEach(item =>
            {
                // Get our drinks            
                Console.WriteLine("Our drink contains of:");
                item.ForEach(Console.WriteLine);
            });            
                        

        }
    }
}
