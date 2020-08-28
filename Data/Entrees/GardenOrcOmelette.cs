﻿/*
 * Author: Nolan Meyer
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Entree Garden Orc Omelette 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class GardenOrcOmelette
    {
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns> the name of the entree </returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

        /// <summary>
        /// gets and sets if Broccoli is held or not
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }

        /// <summary>
        /// gets and sets if Tomato is held or not
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// gets and sets if Cheddar is held or not
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /// <summary>
        /// gets and sets if Mushrooms is held or not
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }

        /// <summary>
        /// gets the price of the entree
        /// </summary>
        public double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// gets the calories of the entree
        /// </summary>
        public uint Calories
        {
            get { return 404;  }
        }

        /// <summary>
        /// puts together the list of special instructions based
        /// on the items being held
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!broccoli) instructions.Add("Hold broccoli");
                if (!tomato) instructions.Add("Hold Tomato");
                if (!cheddar) instructions.Add("Hold cheddar");
                if (!mushrooms) instructions.Add("Hold muchrooms");
                return instructions;
            }
        }

    }
}