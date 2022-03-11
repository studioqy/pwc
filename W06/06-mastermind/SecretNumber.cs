using System;

namespace _06_mastermind
{
    /// <summary>
    /// This class handles creating and storing the random number
    /// that the player must guess.
    /// <\summary>
    class SecretNumber
    {
        // Holds the random number after GetNumber is called 
        private String _number;
        private int _maxLength;
        private String _stringLength;

        /// <summary>
        /// Generates a random 4-digit number and converts it to a string.
        /// This does include numbers with leading zeroes
        /// <\summary>
        public String GetNumber(String mode)
        {
            if (mode == "easy")
            {
                _maxLength = 10000;
                _stringLength = "D4";
            }
            else
            {
                _maxLength = 100000000;
                _stringLength = "D8";
            }
            Random rand = new Random();
            int numberInt = rand.Next(0, _maxLength);
            _number = numberInt.ToString(_stringLength);
            return _number;
        }
    }
}