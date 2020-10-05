/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 * Date Modified: 10/5/2020
 * Modifier: Rana Chevuru
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel; 

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Class tests the DragonbornWaffleFries.cs class
    /// </summary>
    public class DragonbornWaffleFriesTests
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
            var dwf = new DragonbornWaffleFries();

            Assert.PropertyChanged(dwf, "Size", () =>
            {
                dwf.Size = size;
            });
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged interface works 
        /// </summary>
        [Fact]
        public void CheckINotifyPropertyChanged()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dwf);
        }
        /// <summary>
        /// Checks if interface works 
        /// </summary>
        [Fact]
        public void CheckInterfaceForSide()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dwf);
        }

        /// <summary>
        /// Checks if base works 
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dwf); 
        }
        /// <summary>
        /// Cheacks to see the defult size of the container is zero. 
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dwf.Size); 
        }

        /// <summary>
        /// Cheacks to see if we can change the size of container 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = Size.Large;
            Assert.Equal(Size.Large, dwf.Size);
            dwf.Size = Size.Medium;
            Assert.Equal(Size.Medium, dwf.Size);
            dwf.Size = Size.Small;
            Assert.Equal(Size.Small, dwf.Size); 
        }

        /// <summary>
        /// Cheacks to see if there is any special instructions for the chef 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.Empty(dwf.SpecialInstructions);
        }

        /// <summary>
        /// Cheacks to see the correct  <paramref name="price"/> with the correct <paramref name="size"/> 
        /// </summary>
        /// <param name="size">size of the container</param>
        /// <param name="price">price of the container</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = size;
            Assert.Equal(price, dwf.Price); 
        }

        /// <summary>
        /// Cheacks to see the correct <paramref name="calories"/> with the correct <paramref name="size"/>
        /// </summary>
        /// <param name="size">size of the container</param>
        /// <param name="calories">calories for the fries</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = size;
            Assert.Equal(calories, dwf.Calories);
        }

        /// <summary>
        /// Cheacks if it order in the recepit matches  
        /// </summary>
        /// <param name="size">size of container</param>
        /// <param name="name">name of item the consumer wants to buy</param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = size;
            Assert.Equal(name, dwf.ToString()); 
        }
    }
}