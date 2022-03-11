using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uses Random Class
            Random randomGenerator = new Random();
            //Generates random number as key
            int number = randomGenerator.Next(1, 101);
            //Console.WriteLine($"Random Number: {number}");

            int userGuess;

            //While the guess is not the key number, it asks the user to guess
            //again
            do
            {
                Console.Write("Guess a number: ");
                string strGuess = Console.ReadLine();
                userGuess = int.Parse(strGuess);
                
                /************
                If the guess is higher than the key, it says to go lower.
                If the guess is lower than the key, it says to go lower
                If the guss is the same, it congratulates the user and ends
                the program.
                ************/
                if (userGuess < number)
                {
                    Console.WriteLine("Go higher!");
                }
                else if (userGuess > number)
                {
                    Console.WriteLine("Go lower!");
                }
                else
                {
                    Console.WriteLine("Congrats! You got it!");
                }
           // Console.WriteLine();

            } while (userGuess != number);
        }
    }
}
