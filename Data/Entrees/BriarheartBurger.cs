/*
 * Author: Rana Chevuru 
 * Class name: BriarheartBurger.cs
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
    public class BriarheartBurger
    {
        /// <summary>
        /// Private varible that will called for Ketchup 
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Private varible that will called for Bun 
        /// </summary>
        private bool bun     = true;

        /// <summary>
        /// Private varible that will called for Mustard 
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Private varible that will called for Pickle 
        /// </summary>
        private bool pickle  = true;
        private bool cheese  = true; 
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price    =>  6.32;

        /// <summary>
        /// Gets the calories of the burger 
        /// </summary>
        public uint Calories   =>  743;

        /// <summary>
        /// Gets and sets bun
        /// </summary>
        public bool Bun
        {
            get => bun;
            set => bun = value;
        }

        /// <summary>
        /// Gets and sets ketchup
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set => ketchup = value; 
        }

        /// <summary>
        /// Gets and sets mustard
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set => mustard = value; 
        }

        /// <summary>
        /// Gets and sets pickle
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set => pickle = value; 
        }

        /// <summary>
        /// Gets and sets cheese
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set => cheese = value; 
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string>  instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle)  instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions; 
            }
        }

        /// <summary>
        /// Prints the name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Briarheart Burger"; 
        }
    }
}
