/*
 * Author: Nolan Meyer
 * Class name: Entree.cs
 * Purpose: Base class for entrees
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing common properties of entrees
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets the special instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
