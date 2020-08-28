/*
 * Author: Nolan Meyer
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Entree Thugs TBone
 */
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    class ThugsTBone
    {
        /// <summary>
        /// gets the price of the steak
        /// </summary>
        public double Price
        {
            get => 6.44;
        }

        /// <summary>
        /// gets the calories of the steak
        /// </summary>
        public uint Calories
        {
            get => 982;
        }

        /// <summary>
        /// puts together the list of special instructions based
        /// on the items being held
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns> the name of the steak </returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
