using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        private bool ice = true;
        private Size size = Size.Small; 

        public bool Ice
        {
            get => ice;
            set => ice = value; 
        }

        public Size Size
        {
            get => size;
            set => size = value; 
        }

        public double Price
        {
            get
            {
                if (size == Size.Small)
                    return 0.62;
                if (size == Size.Medium)
                    return 0.87;
                if (size == Size.Large)
                    return 1.01;

                return 0; 
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 44;
                if (size == Size.Medium)
                    return 88;
                if (size == Size.Large)
                    return 132;

                return 0; 
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        public override string ToString()
        {
            return size.ToString() + " Aretino Apple Juice";
        }
    }
}
