using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree
    {
        /// <summary>
        /// gets the price of the entree
        /// </summary>
        double Price { get; }

        /// <summary>
        /// gets the calories of the entree
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// gets the special instructions of the entree
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
