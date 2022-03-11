using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Word
    {

        string _word;
        List<char> _correctGuesses;
        List<char> _userProgress;

        /// <summary>
        /// This is the constructor and it declares some
        /// of our member variables, it also creates a list
        /// of characters called userProgress that is inititially
        /// just filled with underscores.
        /// </summary/>
        /// <params>The initial word</params>
        public Word(string word)
        {
            _word = word;
            _correctGuesses = new List<char>();
            _userProgress = new List<char>();
            for (int i = 0; i < _word.Length; i++)
            {
                _userProgress.Add('_');
            }
        }

        /// <summary>
        /// This displays what the word was.
        /// </summary>
        public void DisplayWord()
        {
            Console.WriteLine($"The word was: {_word}");
        }

        /// <summary>
        /// This function displays the user's progress, with underscores
        /// where they have not guessed the letter yet.
        /// </summary>
        public void Display()
        {
            string userProgress = new string(_userProgress.ToArray());
            Console.WriteLine(userProgress);
        }
        
        /// <summary>
        /// Checks to see if the user's guess matches any of the letters in the chosen word.
        /// </summary>
        /// </param> char userGuess </param>
        /// <return> Returns the bool correct </return>
        public bool IsCorrectGuess(char userGuess)
        {
            bool correct = false;
            for (int i = 0; i < _word.Length; i++)
            {
                if (_word[i] == userGuess)
                {
                    _correctGuesses.Add(userGuess);
                    _userProgress[i] = _word[i];
                    correct = true;
                }
            }
            return correct;
        }
        
        /// <summary>
        /// Checks for the word being completely guessed by the user.
        /// </summary>
        /// <returns>Returns a bool</returns>
        public bool IsFinished()
        {
            if(_word == new string(_userProgress.ToArray()))
            {
                return true;
            }

            return false;
        }
    }
}