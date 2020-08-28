﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        private bool ketchup = true;
        private bool bun     = true;
        private bool mustard = true;
        private bool pickle  = true;
        private bool cheese  = true;
        private bool tomato  = true;
        private bool lettuce = true;
        private bool mayo    = true; 
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger 
        /// </summary>
        public uint Calories => 843;

        public bool Bun
        {
            get => bun;
            set => bun = value;
        }

        public bool Ketchup
        {
            get => ketchup;
            set => ketchup = value;
        }

        public bool Mustard
        {
            get => mustard;
            set => mustard = value;
        }

        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }

        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
        }
        
        public bool Tomato
        {
            get => tomato;
            set => tomato = value; 
        }

        public bool Lettuce
        {
            get => lettuce;
            set => lettuce = value; 
        }

        public bool Mayo
        {
            get => mayo;
            set => mayo = value; 
        }

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
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
