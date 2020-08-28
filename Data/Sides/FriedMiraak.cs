using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    class FriedMiraak
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
                    return 1.78;
                if (size == Size.Medium)
                    return 2.01;
                if (size == Size.Large)
                    return 2.88;

                return 0;
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 151;
                if (size == Size.Medium)
                    return 236;
                if (size == Size.Large)
                    return 306;

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
            return size.ToString() + " Fried Miraak";
        }
    }
}
