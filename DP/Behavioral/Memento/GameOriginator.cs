using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Memento
{
    /// <summary>
    /// The Game itself
    /// It has the current State
    /// and uses the memento to save and restore it
    /// </summary>
    class GameOriginator : Originator
    {
        private GameState State { get; set; }

        public GameOriginator()
        {
            // Set initial state
            State = new GameState {Health = 100, Level = 1};
            Console.WriteLine($"Origin state is: Health: {State?.Health} Level: {State?.Level}");

        }

        /// <summary>
        /// Emulates some changes in the game state
        /// </summary>
        public void FightWithEnemy()
        {
            State.Health -= (new Random()).Next(10);
            State.Level += (new Random()).Next(2);
            Console.WriteLine("State changed");
            Console.WriteLine($"New state is: Health: {State?.Health} Level: {State?.Level}");
        }


        /// <summary>
        /// Uses memento to restore state
        /// </summary>
        /// <param name="memento"></param>
        public override void RestoreState(Memento memento )
        {
            State = memento.GetState() as GameState;
            Console.WriteLine("State restored");
            Console.WriteLine($"New state is: Health: {State?.Health} Level: {State?.Level}");
        }

        /// <summary>
        /// Returns memento 
        /// that contains current state
        /// </summary>
        /// <returns>Memento</returns>
        public override Memento SaveState()
        {
            Console.WriteLine($"State saved!");
            return new GameMemento(State);
        }
    }
}
