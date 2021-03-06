﻿/*
 * Author: Rana Chevuru 
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to show price and calories with sizes for sides using a base and interface
 * Date Modified: 10/5/2020
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to show price and calories with sizes for sides using a base and interface
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// varible to get size from enum
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// gets and sets size
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// Gets the price of the cheese grit
        /// </summary>
        /// <exception>returns 0 if the other values did not return </exception>
        /// <return>the price</return>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                    return 1.22;
                if (size == Size.Medium)
                    return 1.58;
                if (size == Size.Large)
                    return 1.93;

                return 0;
            }
        }

        /// <summary>
        /// Gets the calories of the cheese grit
        /// </summary>
        /// <exception>returns 0 if the other values did not return </exception>
        /// <return>the calories</return>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 105;
                if (size == Size.Medium)
                    return 142;
                if (size == Size.Large)
                    return 179;

                return 0;
            }
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <returns>THe instructios for chef</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        public string Name
        {
            get => ToString();
        }

        /// <summary>
        /// Prints the size and name
        /// </summary>
        /// <returns>string of output</returns>
        public override string ToString()
        {
            return size.ToString() + " Mad Otar Grits";
        }
    }
}
