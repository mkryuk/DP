using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Command
{
    /// <summary>
    /// Invoker executes all commands    
    /// </summary>
    class Barista
    {
        private List<List<string>> Drinks { get; }
        private List<ICommand> Commands { get; }

        public Barista()
        {
            Drinks = new List<List<string>>();
            Commands = new List<ICommand>();
        }

        public void MakeCoffee()
        {
            // Execute all commands and take the result
            Commands.ForEach(command =>
            {
                command.Execute();
                Drinks.Add(command.GetResult());
            });            
        }

        public void AddCommand(ICommand command)
        {
            Commands.Add(command);
        }

        public List<List<string>> GetDrinks()
        {
            var temp = Drinks.ToList();
            Drinks.Clear();
            return temp;
        }
    }
}
