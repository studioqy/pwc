using System;
using System.Collections.Generic;

namespace _05_jumper
{
    /// <summary>
    /// This class handles all interactions with the jumper himself.
    /// It will also cover whether or not the user can continue.
    /// <\summary>
    class Jumper
    {
        List<string> _jumpers = new List<string>(){"  ___"," /___\\"," \\   /","  \\ /","   0","  /|\\","  / \\" };

        int _lives = 4;

        /// <summary>
        /// Checks for if the user has any lives left.
        /// <\summary>
        /// <returns> Returns true or false </returns>
        public bool IsAlive()
        {
            if (_lives != 0)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }

        /// <summary>
        /// Will remove a life, and a line of the Jumper.
        /// <\summary>
        public void CutRope()
        {
            _jumpers.RemoveAt(0);
            _lives--;
            if(_lives == 0)
            {
                // _jumpers.RemoveAt(0);
                _jumpers[0] = "   x";
            }
        }

        /// <summary>
        /// Displays the jumper.
        /// <\summary>
        public void DrawJumper()
        {
            for(int i =0;i<_jumpers.Count;i++)
            {
                Console.WriteLine(_jumpers[i]);
            }
            Console.WriteLine("^^^^^^^");
        }

    }
    
}
