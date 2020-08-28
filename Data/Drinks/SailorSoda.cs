/*
 * Author: Rana Chevuru 
 * Class name: SailorSoda.cs
 * Purpose: Class used to show price and calories with sizes for drinks 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using BleakwindBuffet.Data.Enums; 

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to show price and calories with sizes for drinks 
    /// </summary>
    public class SailorSoda
    {
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
            set => flavor = value; 
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
        /// Gets and sets ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value; 
        }

        /// <summary>
        /// Gets the price of water
        /// </summary>
        public double Price
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
        public uint Calories
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions; 
            }
        }

        /// <summary>
        /// Prints the size and name
        /// </summary>
        public override string ToString()
        {
            return size.ToString() + " " + flavor.ToString() + " Sailor Soda";
        }
    }
}
