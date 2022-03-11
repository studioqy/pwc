using System;

namespace _05_jumper
{

    /// <summary>
    /// Directs the gameplay by organizing inputs, updates, and outputs
    /// Loops through the game until it ends
    /// <\summary>
    class Director
    {
        // Member variables
        bool _keepPlaying;
        char _userGuess; 
        Jumper _jumper;
        WordBank _wordBank;
        Word _word;
        UserService _userService;

        /// <summary>
        /// Constructors for all of the other classes
        /// <\summary>
        public Director()
        {
            _keepPlaying = true;
            _wordBank = new WordBank();
            _jumper = new Jumper();
            _userService = new UserService();
            _word = new Word(_wordBank.PickWord());
        }
        
        /// <summary>
        /// The main game loop
        /// Calls the outputs, inputs, and updates while true
        /// <\summary>
        public void StartGame()
        {
            while (_keepPlaying)
            {
                DoOutputs();
                GetInputs();
                DoUpdates();
            }
            DoOutputs();
            _word.DisplayWord();
        }

        /// <summary>
        /// Updates the data for the game
        /// If the guess was incorrect, deletes a line from the jumper's parachute
        /// If it was correct, continues to outputs
        /// Ends the game loop if the jumper died or if the word was guessed
        /// <\summary>
        public void DoUpdates()
        {
            if(!_word.IsCorrectGuess(_userGuess))
            {
                _jumper.CutRope();
            }
            if (!_jumper.IsAlive() || _word.IsFinished())
            {
                _keepPlaying = false;
            }
        }

        /// <summary>
        /// Gets the user's input and assigns it to _userGuess
        /// </summary>
        public void GetInputs()
        {
            _userGuess = _userService.PromptGuess();
        }

        /// <summary>
        /// Does the outputs for the game 
        /// </summary>
        public void DoOutputs()
        {
            _word.Display();
            Console.WriteLine("");
            _jumper.DrawJumper();
        }
    }
}
