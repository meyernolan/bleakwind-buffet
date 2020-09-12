using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side
    {
        /// <summary>
        /// gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets the special instructions for the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
