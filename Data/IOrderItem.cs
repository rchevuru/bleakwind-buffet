/*
 * Author: Rana Chevuru 
 * Class name: IOrderItem .cs
 * Purpose:  An interface class representing the common properties for the items/menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface class representing the common properties for the items/menu   
    /// </summary>
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
