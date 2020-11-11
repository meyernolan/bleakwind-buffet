/*
 * Author: Nolan Meyer
 * Class name: Combo.cs
 * Purpose: represents a Combo
 */
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event handler to be used to call the PropertyChanged Event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Combo constructor. creates a combo out of an Entree, Side, and Drink.
        /// </summary>
        /// <param name="entree">The Entree being added to the Combo.</param>
        /// <param name="side">The Side being added to the Combo.</param>
        /// <param name="drink">The Drink being added to the Combo.</param>
        public Combo(Entree entree, Side side, Drink drink)
        {
            Entree = entree;
            Side = side;
            Drink = drink;
        }

        /// <summary>
        /// returns the string of Combo.
        /// </summary>
        /// <returns>Combo</returns>
        public override string ToString()
        {
            return "Combo";
        }


        /// <summary>
        /// Property for the name of a Combo which is just "Combo"
        /// </summary>
        public string Name
        {
            get => "Combo";
        }

        private Entree entree;
        /// <summary>
        /// Property for the Entrree in the Combo.
        /// </summary>
        public Entree Entree
        {
            get => entree;
            set
            {
                if (entree != null)
                {
                    entree.PropertyChanged -= ItemChangedListener;
                }
                entree = value;
                entree.PropertyChanged += ItemChangedListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private Side side;
        /// <summary>
        /// Property for the Side in the Combo.
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                if (side != null)
                {
                    side.PropertyChanged -= ItemChangedListener;
                }
                side = value;
                side.PropertyChanged += ItemChangedListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private Drink drink;
        /// <summary>
        /// Property for the Drink in the Combo.
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                if(drink != null)
                {
                    drink.PropertyChanged -= ItemChangedListener;
                }
                drink = value;
                drink.PropertyChanged += ItemChangedListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Listener for when an item in the collection is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
            else if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            else if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private double price;
        /// <summary>
        /// Property for the Price of the Combo.
        /// </summary>
        public double Price
        {
            get => Entree.Price + Drink.Price + Side.Price - 1.00;
        }


        private uint calories;
        /// <summary>
        /// Property for the Calories of the Combo
        /// </summary>
        public uint Calories
        {
            get => calories = Entree.Calories + Drink.Calories + Side.Calories;
        }

        /// <summary>
        /// Property for the Special Instructions of the Combo.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(Entree.ToString());
                instructions.AddRange(this.Entree.SpecialInstructions);
                instructions.Add(Side.ToString());
                instructions.AddRange(this.Side.SpecialInstructions);
                instructions.Add(Drink.ToString());
                instructions.AddRange(this.Drink.SpecialInstructions);
                return instructions;
            }
        }

        /// <summary>
        /// Returns the description of the Combo
        /// </summary>
        public string Description { get => ""; }
    }
}
