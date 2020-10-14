/*
 * Author: Rana Chevuru 
 * Class name: WarriorWater.cs
 * Purpose: Class used to show price and calories with sizes for drinks using using a base and interface
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
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Private varible that will called for Ice 
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// Private varible that will called for Lemon 
        /// </summary>
        private bool lemon = false;

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
        /// Gets and sets lemon
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
            }
        }

        /// <summary>
        /// Gets and sets size
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
        /// <exception>Returns 1 if non of other prices not return correctly</exception>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                    return 0.00;
                if (size == Size.Medium)
                    return 0.00;
                if (size == Size.Large)
                    return 0.00;

                return 1;
            }
        }


        /// <summary>
        /// Gets the calories of water
        /// </summary>
        ///  /// <exception>Returns 1 if non of other calories not return correctly</exception>
        public override uint Calories 
        {
            get
            {
                if (size == Size.Small)
                    return 0;
                if (size == Size.Medium)
                    return 0;
                if (size == Size.Large)
                    return 0;

                return 1;
            }
        }
           


    /// <summary>
    /// Prints any special instructions
    /// </summary>
    /// <return>the Spcial instruction for chef</return>
    public override List<string> SpecialInstructions
    {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
        /// <returns>the order</returns>
        public override string ToString()
        {
            return size.ToString() + " Warrior Water";
        }
    }
}
