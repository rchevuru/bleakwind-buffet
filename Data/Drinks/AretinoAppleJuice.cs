/*
 * Author: Rana Chevuru 
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to show price and calories with sizes for drinks using a base and interface
 * Date Modified: 10/5/2020
 */
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to show price and calories with sizes for drinks using a base and interface
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

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
        /// Gets the price of water
        /// </summary>
        /// <exception>returns 0 if the other values did not return </exception>
        /// <return>the price</return>
        public override double Price
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
        /// <exception>returns 0 if the other values did not return </exception>
        /// <return>the calories</return>
        public override uint Calories
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
        /// <return>the instructions for chef</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions;
                
            }
        }

        /// <summary>
        /// Prints the size and name
        /// </summary>
        /// <returns>output for reciet</returns>
        public override string ToString()
        {
            return size.ToString() + " Aretino Apple Juice";
        }
    }
}
