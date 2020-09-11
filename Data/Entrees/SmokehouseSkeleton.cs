/*
 * Author: Rana Chevuru 
 * Class name: SmokehouseSkeleton .cs
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
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// Private varible that will called for SausageLink 
        /// </summary>
        private bool sausageLink = true;

        /// <summary>
        /// Private varible that will called for Egg 
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Private varible that will called for HashBrowns 
        /// </summary>
        private bool hashBrowns = true;

        /// <summary>
        /// Private varible that will called for Pancake 
        /// </summary>
        private bool pancake = true;

        /// <summary>
        /// Gets the price of the breakfast combo
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the breakfast combo
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets and sets sausageLink; 
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set => sausageLink = value;
        }

        /// <summary>
        /// Gets and sets egg
        /// </summary>
        public bool Egg
        {
            get => egg;
            set => egg = value;
        }

        /// <summary>
        /// Gets and sets hashBrowns
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set => hashBrowns = value;
        }

        /// <summary>
        /// Gets and sets pancake
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set => pancake = value;
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <return>instruction for guest</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold egg");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Prints the name
        /// </summary>
        /// <returns>output for reciet</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
