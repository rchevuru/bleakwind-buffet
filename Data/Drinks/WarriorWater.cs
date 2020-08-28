using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Drinks
{
    class WarriorWater
    {
        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }

        public bool Lemon
        {
            get => lemon;
            set => lemon = value;
        }

        public Size Size
        {
            get => size;
            set => size = value;
        }

        public double Price
        {
            get => 0.00;
        }

        public uint Calories
        {
            get => 0;
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        public override string ToString()
        {
            return size.ToString() + " Warrior Water";
        }
    }
}
