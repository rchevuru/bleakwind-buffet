﻿/*
 * Author: Rana Chevuru 
 * Class name: SmokehouseSkeleton .cs
 * Purpose: Class used to show price and calories for entrees using a base and interface
 * Date Modified: 10/5/2020
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to show price and calories for entrees using a base and interface
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Private varible that will called for SausageLink 
        /// </summary>
        private bool sausageLink = true;

        /// <summary>
        /// Private varible that will called for Egg 
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Private varible that will called for HashBrowns 
        /// </summary>
        private bool hashBrowns = true;

        /// <summary>
        /// Private varible that will called for Pancake 
        /// </summary>
        private bool pancake = true;

        /// <summary>
        /// Gets the price of the breakfast combo
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the breakfast combo
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets and sets sausageLink; 
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
            }
        }

        /// <summary>
        /// Gets and sets egg
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
            }
        }

        /// <summary>
        /// Gets and sets hashBrowns
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
            }

        }

        /// <summary>
        /// Gets and sets pancake
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
            }
        }

        /// <summary>
        /// Prints any special instructions
        /// </summary>
        /// <return>instruction for guest</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold egg");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions;
            }
        }
        public string Name
        {
            get => ToString();
        }


        /// <summary>
        /// Prints the name
        /// </summary>
        /// <returns>output for reciet</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
