/*
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
        public uint Calories
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
