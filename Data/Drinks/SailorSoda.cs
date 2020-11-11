/*
 * Author: Nolan Meyer
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the drink Sailor Soda 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink
    {
        private bool ice = true;
        private SodaFlavor flavor = SodaFlavor.Cherry;


        private Size size = Size.Small;
        /// <summary>
        /// gets the size of the drink
        /// </summary>
        public virtual Size Size
        {
            get => size;
            set
            {
                size = value;
                OnPropertyChanged("Size");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("SpecialInstructions");
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// gets and sets if Ice is added
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                OnPropertyChanged("Ice");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets and sets the flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                OnPropertyChanged("Flavor");
                OnPropertyChanged("SpecialInstructions");
                OnPropertyChanged("Name");
            }
        }


        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public override double Price
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
        public override uint Calories
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
        public override List<string> SpecialInstructions
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

        /// <summary>
        /// returns the description of the Item.
        /// </summary>
        public override string Description { get => "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice."; }
    }
}
