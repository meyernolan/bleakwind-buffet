﻿/*
 * Author: Nolan Meyer
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Side Mad Otar Grits 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
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
        /// List of special instructions, there are none for this side
        /// so an empty string is returned.
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
