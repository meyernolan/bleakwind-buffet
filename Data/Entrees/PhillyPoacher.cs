/*
 * Author: Nolan Meyer
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Entree Philly Poacher 
 */
using System.ComponentModel;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree
    { 

        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// gets and sets if sirloin is held or not
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                sirloin = value;
                OnPropertyChanged("Sirloin");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets and sets if onion is held or not
        /// </summary>
        public bool Onion
        {
            get => onion;
            set
            {
                onion = value;
                OnPropertyChanged("Onion");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets and sets if roll is held or not
        /// </summary>
        public bool Roll
        {
            get => roll;
            set
            {
                roll = value;
                OnPropertyChanged("Roll");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets the price of the sandwich
        /// </summary>
        public override double Price
        {
            get => 7.23;
        }

        /// <summary>
        /// gets the calories of the sandwich
        /// </summary>
        public override uint Calories
        {
            get => 784;
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
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns> the name of the sandwich </returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

        /// <summary>
        /// returns the description of the Item.
        /// </summary>
        public override string Description { get => "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll."; }
    }
}
