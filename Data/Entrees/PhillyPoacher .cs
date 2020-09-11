/*
 * Author: Rana Chevuru 
 * Class name: PhillyPoacher .cs
 * Purpose: Class used to show price and calories for entrees
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to show price and calories for entrees
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem
    {
        /// <summary>
        /// Private varible that will called for Sirloin 
        /// </summary>
        private bool sirloin = true;

        /// <summary>
        /// Private varible that will called for Onion 
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Private varible that will called for Roll 
        /// </summary>
        private bool roll = true;

        /// <summary>
        /// Gets the price of the sandwich
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Gets and sets sirloin
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set => sirloin = value;
        }

        /// <summary>
        /// Gets and sets onion
        /// </summary>
        public bool Onion
        {
            get => onion;
            set => onion = value;
        }

        /// <summary>
        /// Gets and sets roll
        /// </summary>
        public bool Roll
        {
            get => roll;
            set => roll = value;
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <return>The instruction for chef</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onion");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Prints the name
        /// </summary>
        /// <returns>string for reciet</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
