/*
 * Author: Rana Chevuru 
 * Class name: FriedMiraak.cs
 * Purpose: Class used to show price and calories with sizes for sides using a base and interface
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to show price and calories with sizes for sides using a base and interface
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
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
        /// Gets the price of the pancake 
        /// </summary>
        /// <exception>returns 0 if the other values did not return </exception>
        /// <return>the price</return>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                    return 1.78;
                if (size == Size.Medium)
                    return 2.01;
                if (size == Size.Large)
                    return 2.88;

                return 0;
            }
        }

        /// <summary>
        /// Gets the calories of the pancake 
        /// </summary>
        /// <exception>returns 0 if the other values did not return </exception>
        /// <return>the calories</return>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 151;
                if (size == Size.Medium)
                    return 236;
                if (size == Size.Large)
                    return 306;

                return 0;
            }
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <returns>The instructions for chef</returns>
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
        /// <returns>string of the reciet</returns>
        public override string ToString()
        {
            return size.ToString() + " Fried Miraak";
        }
    }
}
