/*
 * Author: Nolan Meyer
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Entree Double Draugr 
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool mayo = true;

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
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
            }
        }
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <summary>
        /// gets and sets if Lettuce is held or not
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }

        /// <summary>
        /// gets and sets if Mayo is held or not
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }

        /// <summary>
        /// gets the price of the burger
        /// </summary>
        public override double Price
        {
            get => 7.32;
        }

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public override uint Calories
        {
            get => 843;
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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns> the name of the burger </returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
