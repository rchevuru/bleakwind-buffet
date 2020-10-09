/*
 * Author: Rana Chevuru 
 * Class name: SailorSoda.cs
 * Purpose: Class used to show price and calories with sizes for drinks using a base and interface 
 * Date Modified: 10/5/2020
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to show price and calories with sizes for drinks using a base and interface
    /// </summary>
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Private varible that will called for Ice 
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// varible to get size from enum
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// varible to get flavor from enum
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry; 
        
        /// <summary>
        /// Gets and sets the flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
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
        /// Gets the price of water
        /// </summary>
        /// <exception>returns 0 if the other values did not return</exception>
        /// <return>The price</return>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                    return 1.42;
                if (size == Size.Medium)
                    return 1.74;
                if (size == Size.Large)
                    return 2.07;

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
                    return 117;
                if (size == Size.Medium)
                    return 153;
                if (size == Size.Large)
                    return 205;

                return 0; 
            }
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <return>Instruction for chef</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions; 
            }
        }

        /// <summary>
        /// Prints the size and name
        /// </summary>
        /// <returns> the output of reciet</returns>
        public override string ToString()
        {
            return size.ToString() + " " + flavor.ToString() + " Sailor Soda";
        }
    }
}
