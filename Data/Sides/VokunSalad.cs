/*
 * Author: Rana Chevuru 
 * Class name: VokunSalad.cs
 * Purpose: Class used to show price and calories with sizes for sides 
 */
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to show price and calories with sizes for sides 
    /// </summary>
    public class VokunSalad : Side
    {

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
            set => size = value; 
        }

        /// <summary>
        /// Gets the price of the salad
        /// </summary>
        /// <exception>returns 0 if the other values did not return </exception>
        /// <return>the price</return>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                    return 0.93;
                if (size == Size.Medium)
                    return 1.28;
                if (size == Size.Large)
                    return 1.82;

                return 0; 
            }
        }

        /// <summary>
        /// Gets the calories of the salad
        /// </summary>
        /// <exception>returns 0 if the other values did not return </exception>
        /// <return>the calories</return>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 41;
                if (size == Size.Medium)
                    return 52;
                if (size == Size.Large)
                    return 73;

                return 0;
            }
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <return>The instructions for chef</return>
        public override List<string> SpecialInstructions
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
        /// <returns>string of the output</returns>
        public override string ToString()
        {
            return size.ToString() + " Vokun Salad";
        }
    }
}
