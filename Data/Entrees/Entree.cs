/*
 * Author: Nolan Meyer
 * Class name: Entree.cs
 * Purpose: Base class for entrees
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem
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
        /// gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets the special instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Gets the name as a property
        /// </summary>
        public string Name
        {
            get => this.ToString();
        }

        /// <summary>
        /// Returns the description of the Entree
        /// </summary>
        public abstract string Description { get; }
    }
}
