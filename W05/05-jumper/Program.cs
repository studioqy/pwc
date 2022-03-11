using System;

namespace _05_jumper
{
    /// <summary>
    /// Calls director to start the game
    /// <\summary>
    class Program
    {
        static void Main(string[] args)
        {
            Director game = new Director();
            game.StartGame();
        }
    }
}
