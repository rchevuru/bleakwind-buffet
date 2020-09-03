﻿/*
 * Author: Rana Chevuru 
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to show price and calories with sizes for drinks 
 */
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to show price and calories with sizes for drinks 
    /// </summary>
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Private varible that will called for Ice 
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// varible to get size from enum
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value; 
        }

        /// <summary>
        /// gets and sets size
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value; 
        }

        /// <summary>
        /// Gets the price of water
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                    return 0.62;
                if (size == Size.Medium)
                    return 0.87;
                if (size == Size.Large)
                    return 1.01;

                return 0; 
            }
        }

        /// <summary>
        /// Gets the calories of water
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 44;
                if (size == Size.Medium)
                    return 88;
                if (size == Size.Large)
                    return 132;

                return 0; 
            }
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Prints the size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return size.ToString() + " Aretino Apple Juice";
        }
    }
}
