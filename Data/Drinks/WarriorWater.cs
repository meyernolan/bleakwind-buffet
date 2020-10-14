/*
 * Author: Nolan Meyer
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the drink Warrior Water 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink
    {
        private bool ice = true;
        private bool lemon = false;


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
        /// gets or sets whether to add lemon or not
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
                OnPropertyChanged("Lemon");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public override double Price
        {
            get => 0.00;
        }

        /// <summary>
        /// gets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get => 0;
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
                if (Lemon) instructions.Add("Add lemon");
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
            sb.Append("Warrior Water");
            return sb.ToString();
        }
    }
}
