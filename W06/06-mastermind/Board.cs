using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    /// <summary>
    ///  A class to easily display the board.
    /// </summary>
    class Board
    {
        /// <summary>
        /// Displays the board for the game.
        /// </summary>
        /// <param name="player1">The first player</param>
        /// <param name="player2">The second player</param>
        public void display(Player player1, Player player2)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Player {player1.GetName()}: {player1.GetLastGuess()}, {player1.GetStringHint()}");
            Console.WriteLine($"Player {player2.GetName()}: {player2.GetLastGuess()}, {player2.GetStringHint()}");
            Console.WriteLine("--------------------");
        }
    }
}