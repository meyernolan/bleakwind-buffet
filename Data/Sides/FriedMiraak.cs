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
    class FriedMiraak
    {
        private Size size = Size.Small;

        /// <summary>
        /// gets and sets the size
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
        }

        /// <summary>
        /// gets the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.22;
                else if (Size == Size.Medium)
                    return 1.58;
                else
                    return 1.93;
            }
        }

        /// <summary>
        /// gets the calories of the side
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 105;
                else if (Size == Size.Medium)
                    return 142;
                else
                    return 179;
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
            sb.Append(" Mad Otar Grits");
            return sb.ToString();
        }
    }
}
