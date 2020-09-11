﻿/*
 * Author: Rana Chevuru 
 * Class name: ThugsTBone .cs
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
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// Gets the price of the T-Bone
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <return>instruction for chef</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Prints the name
        /// </summary>
        /// <returns>output for reciet</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
