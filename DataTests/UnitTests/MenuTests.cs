﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums; 

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void CheckMenuClassForDrinks()
        {
            List<IOrderItem> list = (List<IOrderItem>)Menu.Drinks();
            
            Assert.Collection(list,
            item => {
                Assert.IsType<AretinoAppleJuice>(item);
                Assert.Equal(Size.Small, ((AretinoAppleJuice)item).Size);
            },
             item => {
                 Assert.IsType<CandlehearthCoffee>(item);
                 Assert.Equal(Size.Small, ((CandlehearthCoffee)item).Size);
             },
             item => {
                 Assert.IsType<MarkarthMilk>(item);
                 Assert.Equal(Size.Small, ((MarkarthMilk)item).Size);
             },
             item => {
                  Assert.IsType<WarriorWater>(item);
                  Assert.Equal(Size.Small, ((WarriorWater)item).Size);
              },
             item => {
                  Assert.IsType<SailorSoda>(item);
                  Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                  Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
              },

             item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
             item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
               },
             item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
               },
             item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
               },
             item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Small, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
               },


             item => {
                Assert.IsType<AretinoAppleJuice>(item);
                Assert.Equal(Size.Medium, ((AretinoAppleJuice)item).Size);
              },
             item => {
                 Assert.IsType<CandlehearthCoffee>(item);
                 Assert.Equal(Size.Medium, ((CandlehearthCoffee)item).Size);
             },
             item => {
                 Assert.IsType<MarkarthMilk>(item);
                 Assert.Equal(Size.Medium, ((MarkarthMilk)item).Size);
             },
             item => {
                  Assert.IsType<WarriorWater>(item);
                  Assert.Equal(Size.Medium, ((WarriorWater)item).Size);
              },
             item => {
                  Assert.IsType<SailorSoda>(item);
                  Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                  Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
              },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Medium, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
               },


              item => {
                Assert.IsType<AretinoAppleJuice>(item);
                Assert.Equal(Size.Large, ((AretinoAppleJuice)item).Size);
              },

              item => {
                 Assert.IsType<CandlehearthCoffee>(item);
                 Assert.Equal(Size.Large, ((CandlehearthCoffee)item).Size);
               },
           
              item => {
                 Assert.IsType<MarkarthMilk>(item);
                 Assert.Equal(Size.Large, ((MarkarthMilk)item).Size);
                },

              item =>
                {
                Assert.IsType<WarriorWater>(item);
                Assert.Equal(Size.Large, ((WarriorWater)item).Size);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
               },
              item => {
                   Assert.IsType<SailorSoda>(item);
                   Assert.Equal(Size.Large, ((SailorSoda)item).Size);
                   Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
               }
            ) ; 
        }

        
    }
}
