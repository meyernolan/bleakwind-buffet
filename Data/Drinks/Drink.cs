using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public abstract class Drink
    {
        /// <summary>
        /// gets the size of the drink
        /// </summary>
        Size Size { get; set; }

        /// <summary>
        /// gets the price of the drink
        /// </summary>
        double Price { get; }

        /// <summary>
        /// gets the calories of the drink
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// gets the special instructions for the drink
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
