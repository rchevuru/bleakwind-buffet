/*
 * Author: Rana Chevuru 
 * Class name: MadOtarGrits.cs
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
    public class MadOtarGrits
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
        /// Gets the price of the cheese grit
        /// </summary>
        /// <exception>returns 0 if the other values did not return </exception>
        /// <return>the price</return>
        public double Price
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
        public uint Calories
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
        /// <returns>string of output</returns>
        public override string ToString()
        {
            return size.ToString() + " Mad Otar Grits";
        }
    }
}
