using System;
using System.Collections.Generic;

namespace cse210_student_csharp_dice
{
    /// <summary>
    /// Represents the thrower in the game. Tracks the dice, the points,
    /// and the decisions around throwing again.
    /// </summary>
    class Thrower
    {
        const int NUM_DICE = 5;

        List<int> _dice_rolls = new List<int>();
        int turn = 0;

        // TODO: Declare your member variables here


        /// <summary>
        /// Determines if this is the first roll.
        /// 
        /// The condition is: if the number of throws is 0.
        /// </summary>
        public bool IsFirstThrow()
        {
            if (turn == 0) {
                return true;
            }
            else {
                return false;
            }
        }

        /// <summary>
        /// Determines if the set of dice contains any that are scoring.
        /// 
        /// The condition is: if there is a 1 or a 5 in the list.
        /// </summary>
        public bool ContainsScoringDie()
        {
            int counter = 0;
            foreach (int num in _dice_rolls) {
                if (num == 1 || num == 5) {
                    counter++;
                }
            }
            if (counter != 0) {
                return true;
            }
            else {
                return false;
            }
        }
        
        /// <summary>
        /// Determines if the player can throw again.
        /// 
        /// The condition is: if it is the first throw or if the current roll
        /// contains a scoring die. (Hint, there are methods for those...)
        /// </summary>
        public bool CanThrow(int _score)
        {
            if (ContainsScoringDie() || IsFirstThrow()) {
                return true;
            }
            else {
                return false;
            }
        }

        /// <summary>
        /// Clears the previous roll and throws a new set of dice.
        /// This also increments the number of throws counter.
        /// 
        /// The new roll will contain NUM_DICE random numbers from 1-6.
        /// </summary>
        public void ThrowDice()
        {
            _dice_rolls.Clear();
            for (int i = 0; i < NUM_DICE; i++) {
                Random rnd = new Random();
                int roll  = rnd.Next(1, 7);
                _dice_rolls.Add(roll);
            }
            turn += 1;
        }

        /// <summary>
        /// Gets the number of points associated with a single die.
        /// 
        /// The rules are:
        ///     Die value 1: 100 Points
        ///     Die value 5: 50 Points
        ///     Other values: 0 Points
        /// </summary>
        /// <param name="die">The provided die value.</param>
        /// <returns>The points associated with the provided die value.</returns>
        public int GetPointsForDie(int num)
        {
            int scoredDie = 0;
            if (num == 1) {
                scoredDie = 100;
            }
            else if (num == 5) {
                scoredDie = 50;
            }
            return scoredDie;    
        }

        /// <summary>
        /// Gets the number of points associated with the current roll.
        /// 
        /// (Hint: There is a method to determine the points for a single die
        /// that can be called once for each die value in the current list.)
        /// </summary>
        /// <returns>The number of points.</returns>
        public int GetPoints()
        {
            int tempscore = 0;
            foreach (int num in _dice_rolls) {
                tempscore += GetPointsForDie(num);
            }
            return tempscore;
        }
        /// <summary>
        /// Gets a list of the current dice in the format:
        ///     [3, 2, 6, 3, 1]
        /// </summary>
        /// <returns></returns>
        public string GetDiceString()
        {
            string dicestring = "[";
            foreach (int die in _dice_rolls) {
                dicestring += $"{die}, ";
            }
            dicestring += $"\b\b]";
            return dicestring;
        }
    }
}
