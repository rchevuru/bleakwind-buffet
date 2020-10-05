
/*
 * Author: Rana Chevuru 
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to show price and calories for entrees using a base and interface
 * Date Modified: 10/5/2020
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to show price and calories for entrees using a base and interface
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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
            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli")); 
            }
        }

        /// <summary>
        /// Gets and sets mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
            }
        }

        /// <summary>
        /// Gets and sets tomato
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <summary>
        /// Gets and sets chedder
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
            }
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
