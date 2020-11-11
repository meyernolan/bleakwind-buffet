/*
 * Author: Nolan Meyer
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the drink Candlehearth Coffee
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink
    {
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;


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
        /// gets and sets if the drink is decaf or not
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                OnPropertyChanged("Decaf");
                OnPropertyChanged("SpecialInstructions");
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// gets and sets if room is to be left for cream
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                OnPropertyChanged("RoomForCream");
                OnPropertyChanged("SpecialInstructions");
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
                    return .75;
                else if (Size == Size.Medium)
                    return 1.25;
                else
                    return 1.75;
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
                    return 7;
                else if (Size == Size.Medium)
                    return 10;
                else
                    return 20;
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
                if (Ice) instructions.Add("Add ice");
                if (roomForCream) instructions.Add("Add cream");
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
            if (Decaf)
                sb.Append("Decaf ");
            sb.Append("Candlehearth Coffee");
            return sb.ToString();
        }


        /// <summary>
        /// returns the description of the Item.
        /// </summary>
        public override string Description { get => "Fair trade, fresh ground dark roast coffee."; }
    }
}
