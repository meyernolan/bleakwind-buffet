﻿/*
 * Author: Nolan Meyer
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Entree Thalmor Triple 
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree
    { 

        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

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
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                OnPropertyChanged("Tomato");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Lettuce");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Mayo");
                OnPropertyChanged("SpecialInstructions");
            }
        }
        
        /// <summary>
        /// gets and sets if Bacon is held or not 
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set
            {
                bacon = value;
                OnPropertyChanged("Bacon");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets and sets if Egg is held or not
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                OnPropertyChanged("Egg");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets the price of the burger
        /// </summary>
        public override double Price
        {
            get => 8.32;
        }

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public override uint Calories
        {
            get => 943;
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns> the name of the burger </returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

        /// <summary>
        /// returns the description of the Item.
        /// </summary>
        public override string Description { get => "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg."; }
    }
}
