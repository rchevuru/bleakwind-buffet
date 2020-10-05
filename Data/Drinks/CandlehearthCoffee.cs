/*
 * Author: Rana Chevuru 
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to show price and calories with sizes for drinks using a base and interface
 * Date Modified: 10/5/2020
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to show price and calories with sizes for drinks using using a base and interface
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Private varible that will called for Ice 
        /// </summary>
        private bool ice = false;

        /// <summary>
        ///  Private varible that will called for Decaf 
        /// </summary>
        private bool decaf = false;

        /// <summary>
        ///  Private varible that will called for RoomForCream 
        /// </summary>
        private bool roomForCream = false;

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
        /// Gets and sets decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
            }
            
        }

        /// <summary>
        /// gets ans sets decaf
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
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
                    return 0.75;
                if (size == Size.Medium)
                    return 1.25;
                if (size == Size.Large)
                    return 1.75;

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
                    return 7;
                if (size == Size.Medium)
                    return 10;
                if (size == Size.Large)
                    return 20;

                return 0;
            }
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <returns>Instructions for chef</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice"); 
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Prints the size,name, and if it's decafed
        /// </summary>
        /// <returns>output for reciet</returns>
        public override string ToString()
        {
            if (!Decaf)
                return size.ToString() + " Candlehearth Coffee";
            else
                return size.ToString() + " Decaf Candlehearth Coffee"; 
        }
    }
}
