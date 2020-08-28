using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;
        /// <summary>
        /// Gets the price of the sandwich
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public uint Calories => 784;

        public bool Sirloin
        {
            get => sirloin;
            set => sirloin = value;
        }

        public bool Onion
        {
            get => onion;
            set => onion = value;
        }

        public bool Roll
        {
            get => roll;
            set => roll = value;
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirlion");
                if (!Onion) instructions.Add("Hold onion");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
