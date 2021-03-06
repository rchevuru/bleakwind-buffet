﻿/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 * Date Modified: 10/5/2020
 * Modifier: Rana Chevuru
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel; 

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {

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
            var fm = new FriedMiraak();

            Assert.PropertyChanged(fm, "Size", () =>
            {
                fm.Size = size;
            });
        }
        /// <summary>
        /// Checks if INotifyPropertyChanged interface works 
        /// </summary>
        [Fact]
        public void CheckINotifyPropertyChanged()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fm);
        }
        /// <summary>
        /// Checks if interface works 
        /// </summary>
        [Fact]
        public void CheckInterfaceForSide()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm); 
        }

        /// <summary>
        /// Checks if base works 
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm); 
        }
        /// <summary>
        /// Cheacks to see the defult size of the container is zero. 
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// Cheacks to see if we can change the size of container 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// Cheacks to see if there is any special instructions for the chef 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions); 
        }

        /// <summary>
        /// Cheacks to see the correct  <paramref name="price"/> with the correct <paramref name="size"/> 
        /// </summary>
        /// <param name="size">size of the container</param>
        /// <param name="price">price of the container</param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }

        /// <summary>
        /// Cheacks to see the correct <paramref name="calories"/> with the correct <paramref name="size"/>
        /// </summary>
        /// <param name="size">size of the container</param>
        /// <param name="calories">calories for the mirrak</param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }

        /// <summary>
        /// Cheacks if it order in the receipt matches  
        /// </summary>
        /// <param name="size">size of container</param>
        /// <param name="name">name of item the consumer wants to buy</param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString()); 
        }
    }
}