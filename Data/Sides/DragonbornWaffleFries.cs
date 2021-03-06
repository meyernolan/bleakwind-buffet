﻿/*
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
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// gets the price of the side
        /// </summary>
        public override double Price
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
        public override uint Calories
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
            sb.Append(" Dragonborn Waffle Fries");
            return sb.ToString();
        }

        /// <summary>
        /// returns the description of the Item.
        /// </summary>
        public override string Description { get => "Crispy fried potato waffle fries."; }
    }
}
