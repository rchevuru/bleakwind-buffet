using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {
        private Size size = Size.Small; 
        
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
                    return 0.93;
                if (size == Size.Medium)
                    return 1.28;
                if (size == Size.Large)
                    return 1.82;

                return 0; 
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 41;
                if (size == Size.Medium)
                    return 52;
                if (size == Size.Large)
                    return 73;

                return 0;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        public override string ToString()
        {
            return size.ToString() + " Vokun Salad";
        }
    }
}
