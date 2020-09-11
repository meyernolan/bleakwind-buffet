using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// property for getting the price of an item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// property for getting the calories of an item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// gets the special instructions of an item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
