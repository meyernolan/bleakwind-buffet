/*
 * Author: Nolan Meyer
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Side Vokun Salad 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// gets the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return .93;
                else if (Size == Size.Medium)
                    return 1.28;
                else
                    return 1.82;
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
                    return 41;
                else if (Size == Size.Medium)
                    return 52;
                else
                    return 73;
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
            sb.Append(" Vokun Salad");
            return sb.ToString();
        }


        /// <summary>
        /// returns the description of the Item.
        /// </summary>
        public override string Description { get => "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges."; }
    }
}
