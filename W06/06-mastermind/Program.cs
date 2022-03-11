using System;

namespace _06_mastermind
{
    class Program
    {
        /// <summary>
        /// Our main function. Everything starts here
        /// </summary>
        static void Main(string[] args)
        {
            Director thedirector = new Director();
            thedirector.StartGame();
        }
    }
}
