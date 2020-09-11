using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums; 

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> enumerable = new List<IOrderItem>();
            enumerable.Add(new BriarheartBurger());
            enumerable.Add(new DoubleDraugr());
            enumerable.Add(new GardenOrcOmelette());
            enumerable.Add(new PhillyPoacher());
            enumerable.Add(new SmokehouseSkeleton());
            enumerable.Add(new ThalmorTriple());
            enumerable.Add(new ThugsTBone());
            return enumerable; 
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> enumerable = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                enumerable.Add(new DragonbornWaffleFries(){Size = size});
                enumerable.Add(new FriedMiraak(){Size = size });
                enumerable.Add(new MadOtarGrits() { Size = size });
                enumerable.Add(new VokunSalad() { Size = size }); 
            }
            return enumerable; 
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> enumerable = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                enumerable.Add(new AretinoAppleJuice() { Size = size });
                enumerable.Add(new CandlehearthCoffee(){ Size = size });
                enumerable.Add(new MarkarthMilk()      { Size = size });
                enumerable.Add(new WarriorWater()      { Size = size }); 
                foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    enumerable.Add(new SailorSoda() { Size = size, Flavor = flavor });
                }
            }
            return enumerable; 
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> enumerable = new List<IOrderItem>();
            enumerable.AddRange(Entrees());
            enumerable.AddRange(Sides());
            enumerable.AddRange(Drinks());
            return enumerable;
        }
    }
}
