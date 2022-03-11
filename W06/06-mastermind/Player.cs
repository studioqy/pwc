using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    /// <summary>
    /// This class keeps track of the player and their guesses and 
    /// calculates their hints, and sees if they won.
    /// </summary>
    class Player
    {

        private string _name;
        private List<char> _hint;
        private string _lastGuess;

        public Player(string name, string mode)
        {
            _name = name;

            if (mode == "easy")
            {
                _hint = new List<char>() { '*', '*', '*', '*' };

                _lastGuess = "----";
            }

            else
            {
                _hint = new List<char>() { '*', '*', '*', '*', '*', '*', '*', '*' };
                _lastGuess = "--------";
            }
        }

        /// <summary>
        /// This function returns the value of the name variable.
        /// </summary>
        public string GetName() { return _name; }

        /// <summary>
        /// This function returns the value of the lastGuess variable.
        /// </summary>
        public string GetLastGuess() { return _lastGuess; }

        /// <summary>
        /// This function turns the list of characters for hint into a 
        /// string and returns it.
        /// </summary>
        public String GetStringHint()
        {
            string hint = "";
            foreach (char letter in _hint)
            {
                hint = hint += letter;
            }
            return hint;
        }
        /// <summary>
        /// Calculates what hint to display based on the player's guess.
        /// </summary>
        /// <param name= "guess"> The current player's guess. </param>
        /// <param name= "number"> The secret number the players are trying to guess. </param>
        public void CalculateHint(string guess, string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (guess[i] != number[i])
                {
                    if (number.Contains(guess[i]))
                    {
                        _hint[i] = 'o';
                    }

                    else
                    {
                        _hint[i] = '*';
                    }
                }

                else
                {
                    _hint[i] = 'x';
                }
            }
            _lastGuess = guess;
        }
        /// <summary>
        /// Checks whether or not the user's guess matches the secret code.
        /// </summary>
        /// <param name= "number"> Number, the secret code that the players are attempting to guess. </param>
        public bool DidWin(string number)
        {
            if (_lastGuess == number)
                return true;
            else
                return false;
        }
    }
}