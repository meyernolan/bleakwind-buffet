/*
 * Author: Nolan Meyer
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Entree Briarheart Burger 
 */

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price
        {
            get { return 6.32; }
        }

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 743;


        private bool ketchup = true;
        /// <summary>
        /// gets and sets the Ketchup property
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }

        /// <summary>
        /// gets and sets if Bun is held or not
        /// </summary>
        private bool bun = true;
        public bool Bun 
        { 
            get => bun;
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
            }
        }

        /// <summary>
        /// gets and sets if Mustard is held or not
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }

        /// <summary>
        /// gets and sets if Pickle is held or not
        /// </summary>
        bool pickle = true;
        public bool Pickle 
        { 
            get => pickle;
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }

        /// <summary>
        /// gets and sets if Cheese is held or not
        /// </summary>
        bool cheese = true;
        public bool Cheese 
        { 
            get => cheese;
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
                if (!Bun) instructions.Add("Hold bun");
                if (!ketchup) instructions.Add("Hold ketchup");
                if (!mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            } 
        }

        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns> the name of the burger </returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
