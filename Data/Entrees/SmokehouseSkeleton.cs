/*
 * Author: Nolan Meyer
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Entree Smokehouse Skeleton 
 */
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree
    { 

        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;
        
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
        /// gets and sets if sausage is held or not
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                OnPropertyChanged("SausageLink");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets and sets if hash browns is held or not
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                OnPropertyChanged("HashBrowns");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets and sets if pancake is held or not
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                OnPropertyChanged("Pancake");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets the price of the meal
        /// </summary>
        public override double Price
        {
            get => 5.62;
        }

        /// <summary>
        /// gets the calories of the meal
        /// </summary>
        public override uint Calories
        {
            get => 602;
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
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                if (!Egg) instructions.Add("Hold eggs");
                return instructions;
            }
        }

        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns> the name of the meal </returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

        /// <summary>
        /// returns the description of the Item.
        /// </summary>
        public override string Description { get => "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice."; }
    }
}
