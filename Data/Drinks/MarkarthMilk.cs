using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        private bool ice = false;
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
                    return 1.05;
                if (size == Size.Medium)
                    return 1.11;
                if (size == Size.Large)
                    return 1.22;

                return 0;
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 56;
                if (size == Size.Medium)
                    return 72;
                if (size == Size.Large)
                    return 93;

                return 0;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        public override string ToString()
        {
            return size.ToString() + " Markarth Milk" ;
        }
    }
}
