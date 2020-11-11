/*
 * Author: Nolan Meyer
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Entree Thugs TBone
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree
    { 
        /// <summary>
        /// gets the price of the steak
        /// </summary>
        public override double Price
        {
            get => 6.44;
        }

        /// <summary>
        /// gets the calories of the steak
        /// </summary>
        public override uint Calories
        {
            get => 982;
        }

        /// <summary>
        /// puts together the list of special instructions based
        /// on the items being held
        /// </summary>
        public override List<string> SpecialInstructions
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

        /// <summary>
        /// returns the description of the Item.
        /// </summary>
        public override string Description { get => "Juicy T-Bone, not much else to say."; }
    }
}
