using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class WordBank
    {
        string _word;
        List<string> _words;

        /// <summary>
        /// Default constructor. Reads a file and assigns it to _words
        /// </summary>
        public WordBank()
        {
            string[] file = System.IO.File.ReadAllLines(@"wordlist.10000.txt");
            _words = new List<string>(file);
            return;
        }

        /// <summary>
        /// Pulls a random word from the word bank and assings it to _word
        /// </summary>
        /// <returns>Returns _word</returns>
        public string PickWord()
        {
            Random random = new Random();
            _word = _words[random.Next(0, _words.Count)];
            return _word.ToLower();
        }
    }
}
