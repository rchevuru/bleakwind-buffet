using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool chedder = true;

        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public uint Calories => 404;


        public bool Broccoli
        {
            get => broccoli;
            set => broccoli = value;
        }
        public bool Mushrooms
        {
            get => mushrooms;
            set => mushrooms = value;
        }
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }
        public bool Chedder
        {
            get => chedder;
            set => chedder = value;
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Chedder) instructions.Add("Hold chedder");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
