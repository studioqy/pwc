using System;
using System.Collections.Generic;

namespace _05_hide_and_seek
{
    /// <summary>
    /// The Hider is responsible to watch the seeker and give hints.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    public class Hider
    {
        // TODO: Add any member variables here
        public int _hiderLocation;
        public List<int> _hiderDistances;

        /// <summary>
        /// Initializes the location of the hider to a random location 1-1000.
        /// Also initializes the list of distances to be a new, empty list.
        /// </summary>
        public Hider()
        {
            Random randomHider = new Random();
            _hiderLocation = randomHider.Next(1, 1001);

            _hiderDistances = new List<int>();
        }

        /// <summary>
        /// Computes the distance from the hider's location to the provided location of the seeker
        /// and stores it in a list of distances to use later.
        /// </summary>
        /// <param name="seekerLocation">The current location of the seeker.</param>
        public void Watch(int seekerLocation)
        {
            int distanceMoved = Math.Abs(_hiderLocation - seekerLocation);
            _hiderDistances.Add(distanceMoved);
        }

        /// <summary>
        /// Gets a hint.
        /// 
        /// If there is not enough information yet (fewer than 2 distances), a generic hint is given.
        /// If the seeker has found the hider, the hint notes they have been found.
        /// If the seeker is moving closer, the hint notes they are getting warmer.
        /// If the seeker is moving futher away, the hing notes they are getting colder.
        /// </summary>
        /// <returns>The hint message</returns>
        public string GetHint()
        {
            string hintMessage = "";
            if (IsFound())
            {
                hintMessage = "(;.;) You found me!\n";
            }
            else if (_hiderDistances.Count < 2)
            {
                hintMessage = "Good luck!\n";
            }
            else if (_hiderDistances[_hiderDistances.Count - 2] < _hiderDistances[_hiderDistances.Count - 1])
            {
                hintMessage = "(^.^) Getting colder!\n";
            }
            else if (_hiderDistances[_hiderDistances.Count - 2] > _hiderDistances[_hiderDistances.Count - 1])
            {
                hintMessage = "(>.<) Getting warmer!\n";
            }
            return hintMessage;
        }

        /// <summary>
        /// Returns whether the hider has been found. (Hint: the last distance is 0 in that case.)
        /// </summary>
        /// <returns>True if the hider has been found.</returns>
        public bool IsFound()
        {
            if (_hiderDistances[_hiderDistances.Count - 1] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
