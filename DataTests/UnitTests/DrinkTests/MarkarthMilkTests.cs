﻿/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 * Date Modified: 10/5/2020
 * Modifier: Rana Chevuru
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Test the MarkarthMilk.cs class
    /// </summary>
    public class MarkarthMilkTests
    {
        /// <summary>
        /// Checks if the Ice property is changed 
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = true;
            });

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = false;
            });
        }

        /// <summary>
        /// Checks if the Size property is changed 
        /// </summary>
        /// <param name="size">Size of cotainer</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]

        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            var mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = size;
            });
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged interface works 
        /// </summary>
        [Fact]
        public void CheckINotifyPropertyChanged()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mm);
        }
        /// <summary>
        /// Checks if interface works 
        /// </summary>
        [Fact]
        public void CheckInterfaceForDrink()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }

        /// <summary>
        /// Checks if base works 
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm); 
        }
        /// <summary>
        /// Checks to see if ice is not added
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        /// <summary>
        /// Checks if the size is small 
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        /// <summary>
        /// Ice can be added or not 
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
            mm.Ice = false;
            Assert.False(mm.Ice);
        }

        /// <summary>
        /// Sees if we can change the size 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk(); 
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
        }

        /// <summary>
        /// Cheacks to see the correct  <paramref name="price"/> with the correct <paramref name="size"/> 
        /// </summary>
        /// <param name="size">size of the container</param>
        /// <param name="price">price of the container</param>
        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(price, mm.Price); 
        }

        /// <summary>
        /// Cheacks to see the correct <paramref name="cal"/> with the correct <paramref name="size"/>
        /// </summary>
        /// <param name="size">Size of container</param>
        /// <param name="cal">Calories of the milk</param>
        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(cal, mm.Calories); 
        }

        /// <summary>
        /// Cheacks to see if there is any special instructions for the chef
        /// </summary>
        /// <param name="includeIce">Checks if ice should be added or not</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", mm.SpecialInstructions);
            else Assert.Empty(mm.SpecialInstructions);
        }

        /// <summary>
        /// Cheacks if it order in the recepit matches  
        /// </summary>
        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(name, mm.ToString()); 
        }
    }
}