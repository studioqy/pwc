using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameWon;
            List<string> values = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            displayChart(values);

            string player = "x";
            int turnCount = 0;

            do
            {
                Console.WriteLine($"It is {player}'s turn!");
                int intChosen = chooseSquare(player);

                intChosen = checkIfTaken(values, intChosen, player);

                values[intChosen - 1] = player;
                turnCount++;

                displayChart(values);

                gameWon = checkIfFull(values);
                gameWon = checkIfEnd(values, turnCount, player, gameWon);

                player = changePlayer(player);

            } while (gameWon == false);
            //Check if square is already taken
            //Check is winner
            //Switch players
        }

        static void displayChart(List<string> values)
        {
            Console.WriteLine();
            Console.WriteLine($"{values[0]}|{values[1]}|{values[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{values[3]}|{values[4]}|{values[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{values[6]}|{values[7]}|{values[8]}");
            Console.WriteLine();
        }
        static string changePlayer(string player)
        {
            if (player == "x")
            {
                player = "o";
            }
            else if (player == "o")
            {
                player = "x";
            }
            return player;
        }
        static int checkIfTaken(List<string> values, int intChosen, string player)
        {
            while (values[intChosen - 1] == "x" | values[intChosen - 1] == "o")
            {
                Console.WriteLine("That square is already taken! Choose another one.");
                intChosen = chooseSquare(player);
            }
            return intChosen;
        }
        static int chooseSquare(string player)
        {
            Console.Write($"In which square would you like to place your {player}? ");
            string chosenSquare = Console.ReadLine();
            int intChosen = int.Parse(chosenSquare);
            return intChosen;
        }
        static bool checkIfEnd(List<string> values, int turnCount, string player, bool gameWon)
        {
            if ((values[0] == values[1] & values[1] == values[2]) |
                (values[3] == values[4] & values[4] == values[5]) |
                (values[6] == values[7] & values[7] == values[8]) |
                (values[0] == values[3] & values[3] == values[6]) |
                (values[1] == values[4] & values[4] == values[7]) |
                (values[2] == values[5] & values[5] == values[8]) |
                (values[0] == values[4] & values[4] == values[8]) |
                (values[2] == values[4] & values[4] == values[6])
            )
            {
                Console.WriteLine($"{player} won!");
                Console.WriteLine($"The game ended in {turnCount} turns.");
                return true;
            }
            else
            {
                return gameWon;
            }
        }
        static bool checkIfFull(List<string> values)
        {
            int fullCounter = 0;
            foreach (string value in values)
            {
                if (value == "x" | value == "o")
                {
                    fullCounter++;
                }
            }
            if (fullCounter == 9)
            {
                Console.WriteLine("The board is full! Neither player won.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}