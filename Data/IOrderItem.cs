using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// Will get the price 
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Will get the calories
        /// </summary>
        uint  Calories { get; }

        /// <summary>
        /// Will get the special instructions
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
