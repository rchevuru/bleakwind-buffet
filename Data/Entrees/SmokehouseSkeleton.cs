using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        private bool sausagelink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// Gets the price of the breakfast combo
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the calories of the breakfast combo
        /// </summary>
        public uint Calories => 602;

        public bool SausageLink
        {
            get => sausagelink;
            set => sausagelink = value;
        }

        public bool Egg
        {
            get => egg;
            set => egg = value;
        }

        public bool HashBrowns
        {
            get => hashBrowns;
            set => hashBrowns = value;
        }

        public bool Pancake
        {
            get => pancake;
            set => pancake = value;
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold egg");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
