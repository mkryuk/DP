using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Memento
{
    class UsingMemento
    {
        public static void Run()
        {
            // Create concrete Originator, the game itself.
            var game = new GameOriginator();
            // Create Caretaker that responsible for storing game states
            var careTaker = new Caretaker();

            // Make some changes in game state                    
            game.FightWithEnemy();
            // Save current state to the caretaker
            careTaker.SaveState(game.SaveState());

            // Make some changes in game state 
            game.FightWithEnemy();
            game.FightWithEnemy();
            game.FightWithEnemy();

            Console.WriteLine("We need to restore the state...");
            // Restore the last state from the caretaker
            game.RestoreState(careTaker.RestoreState());

        }
    }
}
