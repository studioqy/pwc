using System;

namespace _06_mastermind
{
    /// <summary>
    /// Directs the main flow of the game with GetInputs(), DoUpdates(), and DoOutputs()
    /// <\summary>
    class Director
    {
        bool _keepPlaying = true;
        Board _board = new Board();
        Roster _roster = new Roster();
        SecretNumber _secretNumber = new SecretNumber();
        UserInterface _userInterface = new UserInterface();
        String _keyNumber;
        String _gamemode;


        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                DoOutputs();
                DoUpdates();
            }
        }

        /// <summary>
        /// Gets the user's names and sets the secret number
        /// <\summary>
        private void PrepareGame()
        {
            _gamemode = _userInterface.GetStringInput("Easy or hard mode? ");
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userInterface.GetStringInput(prompt);

                Player player = new Player(name, _gamemode.ToLower());
                _roster.AddPlayer(player);
            }
            _keyNumber = _secretNumber.GetNumber(_gamemode.ToLower());
        }

        /// <summary>
        /// Gets the players's guess
        /// <\summary>
        private string GetInputs()
        {
            return _userInterface.GetStringInput("What is your guess: ");
        }

        /// <summary>
        /// Does the updates for the game and runs checks
        /// </summary>
        private void DoUpdates()
        {
            Player currentPlayer = _roster.GetCurrentPlayer();
            currentPlayer.CalculateHint(GetInputs(), _keyNumber);
            bool didWin = currentPlayer.DidWin(_keyNumber);
            if (didWin)
            {
                _keepPlaying = false;
                Console.WriteLine($"\n{currentPlayer.GetName()} won!");
            }
            else
                _roster.AdvanceNextPlayer();
        }

        /// <summary>
        /// Does the outputs for the game
        /// </summary>
        private void DoOutputs()
        {
            _board.display(_roster.GetPlayers()[0], _roster.GetPlayers()[1]);
            Console.WriteLine($"{_roster.GetCurrentPlayer().GetName()}'s turn:");
        }
    }
}