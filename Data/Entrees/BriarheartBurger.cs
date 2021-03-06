﻿/*
 * Author: Nolan Meyer
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Entree Briarheart Burger 
 */

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree
    {

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
                OnPropertyChanged("Ketchup");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Bun");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Mustard");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Pickle");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Cheese");
                OnPropertyChanged("SpecialInstructions");
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

        /// <summary>
        /// returns the description of the Briarheart Burger.
        /// </summary>
        public override string Description { get => "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese."; }
    }
}
