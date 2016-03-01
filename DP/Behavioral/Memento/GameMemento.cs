namespace DP.Behavioral.Memento
{

    /// <summary>
    /// Concrete memento
    /// </summary>
    internal class GameMemento : Memento
    {
        public GameMemento(GameState state)
        {
            State = new GameState {Health = state.Health, Level = state.Level};
        }

    }
}