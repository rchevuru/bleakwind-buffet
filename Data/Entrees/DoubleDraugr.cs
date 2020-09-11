/*
 * Author: Rana Chevuru 
 * Class name: DoubleDraugr.cs
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
    public class DoubleDraugr : Entree
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

        /// <summary>
        /// Private varible that will called for Cheese 
        /// </summary>
        private bool cheese  = true;

        /// <summary>
        /// Private varible that will called for Tomato 
        /// </summary>
        private bool tomato  = true;

        /// <summary>
        /// Private varible that will called for Lettuce 
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Private varible that will called for Mayo 
        /// </summary>
        private bool mayo    = true; 

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger 
        /// </summary>
        public override uint Calories => 843;


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
        /// Gets and sets tomato
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set => tomato = value; 
        }

        /// <summary>
        /// Gets and sets lettuce
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set => lettuce = value; 
        }

        /// <summary>
        /// Gets and sets mayo
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set => mayo = value; 
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <return>the instructions for chef</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun)     instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle)  instructions.Add("Hold pickle");
                if (!Cheese)  instructions.Add("Hold cheese");
                if (!Tomato)  instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo)    instructions.Add("Hold mayo"); 
                return instructions;
            }
        }

        /// <summary>
        /// Prints the name
        /// </summary>
        /// <returns>string for reciet</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
