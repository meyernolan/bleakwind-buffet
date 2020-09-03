/*
 * Author: Nolan Meyer
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the drink Sailor Soda 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// gets and sets if Ice is added
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }


        /// <summary>
        /// gets and sets the size
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
        }

        /// <summary>
        /// gets and sets the flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set => flavor = value;
        }


        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.42;
                else if (Size == Size.Medium)
                    return 1.74;
                else
                    return 2.07;
            }
        }

        /// <summary>
        /// gets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 117;
                else if (Size == Size.Medium)
                    return 153;
                else
                    return 205;
            }
        }

        /// <summary>
        /// puts together the list of special instructions based
        /// on the items being held
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns> the name of the drink </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size.ToString());
            sb.Append(" ");
            sb.Append(Flavor.ToString());
            sb.Append(" Sailor Soda");
            return sb.ToString();
        }
    }
}
