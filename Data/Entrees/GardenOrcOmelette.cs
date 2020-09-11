
/*
 * Author: Rana Chevuru 
 * Class name: GardenOrcOmelette.cs
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
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// Private varible that will called for Broccoli 
        /// </summary>
        private bool broccoli = true;

        /// <summary>
        /// Private varible that will called for Mushrooms 
        /// </summary>
        private bool mushrooms = true;

        /// <summary>
        /// Private varible that will called for Tomato 
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Private varible that will called for Chedder 
        /// </summary>
        private bool cheddar = true;

        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Gets and sets broccoli
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set => broccoli = value;
        }

        /// <summary>
        /// Gets and sets mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set => mushrooms = value;
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
        /// Gets and sets chedder
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set => cheddar = value;
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <return>The instructions of chef</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Prints the name
        /// </summary>
        /// <returns>string for reciet</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
