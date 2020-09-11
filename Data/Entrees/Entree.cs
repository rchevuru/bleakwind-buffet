﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>In US Dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree 
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
