using System;

namespace _05_jumper
{
    /// <summary>
    /// Handles all of the direct interaction with the user,
    /// meaning any input and output.
    /// <\summary>
    class UserService
    {
        /// <summary>
        /// Handles taking the user's guess and returning
        /// is as a lowercase string.
        /// <\summary>
        public Char PromptGuess()
        {
            Console.Write("Guess a letter [a-z]: ");
            string guessedString = Console.ReadLine().ToLower();
            char guessedLetter;
            while (!char.TryParse(guessedString, out guessedLetter))
            {
                Console.Write("Please enter just one character: ");
                guessedString = Console.ReadLine().ToLower();
            }
            guessedLetter = char.Parse(guessedString);
            return guessedLetter;
        }
    }
}