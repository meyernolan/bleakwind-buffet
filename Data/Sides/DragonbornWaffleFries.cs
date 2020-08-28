/*
 * Author: Nolan Meyer
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Side Dragonborn Waffle Fries 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    class DragonbornWaffleFries
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
                    return .42;
                else if (Size == Size.Medium)
                    return .76;
                else
                    return .96;
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
                    return 77;
                else if (Size == Size.Medium)
                    return 89;
                else
                    return 100;
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
            sb.Append(" Dragonborn Waffle Fries");
            return sb.ToString();
        }
    }
}
