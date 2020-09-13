/*
 * Author: Rana Chevuru 
 * Class name: Side.cs
 * Purpose:  A base class representing the common properties of Sides 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums; 

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of Sides 
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the sides 
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the sides
        /// </summary>
        /// <value>In US Dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the sides 
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
