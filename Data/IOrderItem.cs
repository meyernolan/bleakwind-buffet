﻿/*
 * Author: Nolan Meyer
 * Class name: IOrderItem.cs
 * Purpose: Interface for orderable items
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for an interface or items that can be ordered
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// property for getting the price of an item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// property for getting the calories of an item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// gets the special instructions of an item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// Returns the name of the IOrderItem
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Returns the description of the IOrderItem
        /// </summary>
        string Description { get; }
    }
}
