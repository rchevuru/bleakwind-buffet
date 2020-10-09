/*
 * Author: Rana Chevuru 
 * Class name: BriarheartBurger.cs
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
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged; 
       
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
        public override double Price    =>  6.32;

        /// <summary>
        /// Gets the calories of the burger 
        /// </summary>
        public override uint Calories   =>  743;

        /// <summary>
        /// Gets and sets bun
        /// </summary>
        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun")); 
            }
        }

        /// <summary>
        /// Gets and sets ketchup
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }

        /// <summary>
        /// Gets and sets mustard
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }

        /// <summary>
        /// Gets and sets pickle
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set 
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }

        /// <summary>
        /// Gets and sets cheese
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
            }
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <return>instructions for chef</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string>  instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle)  instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions; 
            }
        }

        

        /// <summary>
        /// Prints the name
        /// </summary>
        /// <returns>string for reseit</returns>
        public override string ToString()
        {
            return "Briarheart Burger"; 
        }
    }
}
