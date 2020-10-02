/*
 * Author: Nolan Meyer
 * Class name: Side.cs
 * Purpose: Base class for sides
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// gets the size of the side
        /// </summary>
        public virtual Size Size 
        { 
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets the special instructions for the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
