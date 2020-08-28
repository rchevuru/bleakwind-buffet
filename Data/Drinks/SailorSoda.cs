using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using BleakwindBuffet.Data.Enums; 

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        private bool ice = true;
        private Size size = Size.Small; 
        private SodaFlavor flavor = SodaFlavor.Cherry; 

        public SodaFlavor Flavor
        {
            get => flavor;
            set => flavor = value; 
        }

        public Size Size
        {
            get => size;
            set => size = value; 
        }

        public bool Ice
        {
            get => ice;
            set => ice = value; 
        }

        public double Price
        {
            get
            {
                if (size == Size.Small)
                    return 1.42;
                if (size == Size.Medium)
                    return 1.74;
                if (size == Size.Large)
                    return 2.07;

                return 0; 
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 117;
                if (size == Size.Medium)
                    return 153;
                if (size == Size.Large)
                    return 205;

                return 0; 
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions; 
            }
        }

        public override string ToString()
        {
            return size.ToString() + " " + flavor.ToString() + " Sailor Soda";
        }
    }
}
