/*
 * Author: Nolan Meyer
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Side Fried Miraak 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, IOrderItem
    {
        /// <summary>
        /// gets the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.78;
                else if (Size == Size.Medium)
                    return 2.01;
                else
                    return 2.88;
            }
        }

        /// <summary>
        /// gets the calories of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 151;
                else if (Size == Size.Medium)
                    return 236;
                else
                    return 306;
            }
        }

        /// <summary>
        /// List of special instructions, there are none for this side
        /// so an empty string is returned.
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
        /// <returns> the name of the side </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size.ToString());
            sb.Append(" Fried Miraak");
            return sb.ToString();
        }
    }
}
