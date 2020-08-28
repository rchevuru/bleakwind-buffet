using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// varible to get size from enum
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// gets and sets size
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
        }

        /// <summary>
        /// Gets the price of the chhese grit
        /// </summary>
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

        /// <summary>
        /// Gets the calories of the chhese grit
        /// </summary>
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

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Prints the size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return size.ToString() + "Mad Otar Grits";
        }
    }
}
