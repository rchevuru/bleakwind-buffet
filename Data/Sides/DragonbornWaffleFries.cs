/*
 * Author: Rana Chevuru 
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to show price and calories with sizes for sides  
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to show price and calories with sizes for sides 
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// varible to get size from enum
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// gets and sets size
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
        }

        /// <summary>
        /// Gets the price of the fries
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                    return 0.42;
                if (size == Size.Medium)
                    return 0.76;
                if (size == Size.Large)
                    return .096;

                return 0;
            }
        }

        /// <summary>
        /// Gets the calories of the fries
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 77;
                if (size == Size.Medium)
                    return 89;
                if (size == Size.Large)
                    return 100;

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
                return instructions;
            }
        }

        /// <summary>
        /// Prints the size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
