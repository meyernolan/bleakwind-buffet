/*
 * Author: Nolan Meyer
 * Class name: Drink.cs
 * Purpose: Base class for drinks
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for a property changed event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged(string str)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets the special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Gets the name as a property
        /// </summary>
        public string Name
        {
            get => this.ToString();
        }
    }
}
