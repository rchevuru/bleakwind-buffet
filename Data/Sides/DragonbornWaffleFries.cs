using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
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
                    return 0.42;
                if (size == Size.Medium)
                    return 0.76;
                if (size == Size.Large)
                    return .096;

                return 0;
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 77;
                if (size == Size.Medium)
                    return 89;
                if (size == Size.Large)
                    return 100;

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
            return size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
