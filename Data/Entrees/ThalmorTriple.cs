/*
 * Author: Rana Chevuru 
 * Class name: ThalmorTriple .cs
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
    public class ThalmorTriple
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
        /// Private varible that will called for Bacon 
        /// </summary>
        private bool bacon   = true;

        /// <summary>
        /// Private varible that will called for Egg 
        /// </summary>
        private bool egg     = true; 

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger 
        /// </summary>
        public uint Calories => 943;

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
        /// Gets and sets bacon
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set => bacon = value; 
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
        /// Prints any special instructions
        /// </summary>
        public List<string> SpecialInstructions
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
                if (!Bacon)   instructions.Add("Hold bacon");
                if (!Egg)     instructions.Add("Hold egg"); 
                return instructions;
            }
        }

        /// <summary>
        /// Prints the name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
