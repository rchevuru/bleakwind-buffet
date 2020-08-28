using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace Data.Drinks
{
    public class CandlehearthCoffee
    {
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
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

        public bool Decaf
        {
            get => decaf;
            set => decaf = value;
        }

        public bool RoomForCream
        {
            get => roomForCream;
            set => roomForCream = value;
        }

        public double Price
        {
            get
            {
                if (size == Size.Small)
                    return 0.75;
                if (size == Size.Medium)
                    return 1.25;
                if (size == Size.Large)
                    return 1.75;

                return 0;
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 7;
                if (size == Size.Medium)
                    return 10;
                if (size == Size.Large)
                    return 20;

                return 0;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add Decaf");
                return instructions;
            }
        }

        public override string ToString()
        {
            if (!Decaf)
                return size.ToString() + " Candlehearth Coffee";
            else
                return size.ToString() + " Decaf Candlehearth Coffee"; 
        }
    }
}
