/*
 * Author: Nolan Meyer
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Entree Philly Poacher 
 */
using System.ComponentModel;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
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
    }
}
