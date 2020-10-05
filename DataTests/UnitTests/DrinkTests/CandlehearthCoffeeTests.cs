/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
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
    /// Test the CandlehearthCoffee.cs class
    /// </summary>
    public class CandlehearthCoffeeTests {

        /// <summary>
        /// Checks if the Ice property is changed 
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "Ice", () =>
            {
                chc.Ice = true;
            });

            Assert.PropertyChanged(chc, "Ice", () =>
            {
                chc.Ice = false;
            });
        }

        /// <summary>
        /// Checks if the Decaf property is changed 
        /// </summary>
        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "Decaf", () =>
            {
                chc.Decaf = true;
            });

            Assert.PropertyChanged(chc, "Decaf", () =>
            {
                chc.Decaf = false;
            });
        }

        /// <summary>
        /// Checks if the RoomForCream property is changed 
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamNotifiesRoomForCreamProperty()
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "RoomForCream", () =>
            {
                chc.RoomForCream = true;
            });

            Assert.PropertyChanged(chc, "RoomForCream", () =>
            {
                chc.RoomForCream = false;
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
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "Size", () =>
            {
                chc.Size = size;
            });
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged interface works 
        /// </summary>
        [Fact]
        public void CheckINotifyPropertyChanged()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chc);
        }
        
        /// <summary>
        /// Checks if interface works 
        /// </summary>
        [Fact]
        public void CheckInterfaceForDrink()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(chc); 
        }

        /// <summary>
        /// Checks if base works 
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(chc); 
        }
        /// <summary>
        /// Check is ice is not included in the beginning 
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Ice); 
        }
        /// <summary>
        /// Sees if the defult value of decaf is false
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Decaf); 
        }

        /// <summary>
        /// Sees if the starting room for cream is false
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.RoomForCream); 
        }

        /// <summary>
        /// Sees if the starting size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, chc.Size); 
        }

        /// <summary>
        /// Sees if we can change the the addtion of ice or not 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = true;
            Assert.True(chc.Ice);
            chc.Ice = false;
            Assert.False(chc.Ice); 
        }

        /// <summary>
        /// Sees if we can change the the addtion of decaf or not 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Decaf = true;
            Assert.True(chc.Decaf);
            chc.Decaf = false;
            Assert.False(chc.Decaf); 
        }
        /// <summary>
        /// Sees if we can change the the addtion of cream or not 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.RoomForCream = true;
            Assert.True(chc.RoomForCream);
            chc.RoomForCream = false;
            Assert.False(chc.RoomForCream);
        }
        /// <summary>
        /// Sees if we can change the size 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = Size.Large;
            Assert.Equal(Size.Large, chc.Size);
            chc.Size = Size.Medium;
            Assert.Equal(Size.Medium, chc.Size);
            chc.Size = Size.Small;
            Assert.Equal(Size.Small, chc.Size);
        }
        /// <summary>
        /// Cheacks to see the correct  <paramref name="price"/> with the correct <paramref name="size"/> 
        /// </summary>
        /// <param name="size">size of container</param>
        /// <param name="price">price of container</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(price, chc.Price); 
        }

        /// <summary>
        /// Cheacks to see the correct <paramref name="cal"/> with the correct <paramref name="size"/>        /// </summary>
        /// <param name="size">Size of container</param>
        /// <param name="cal">Calories of the coffee</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(cal, chc.Calories); 
        }

        /// <summary>
        /// Cheacks to see if there is any special instructions for the chef
        /// </summary>
        /// <param name="includeIce">Checks if ice should be added or not</param>
        /// <param name="includeCream">Checks if cream should be added or not</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = includeIce;
            chc.RoomForCream = includeCream; 
            if (includeIce) Assert.Contains("Add ice", chc.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", chc.SpecialInstructions);
            if(!includeIce && !includeCream)Assert.Empty(chc.SpecialInstructions); 
        }

        /// <summary>
        /// Cheacks if it order in the recepit matches  
        /// </summary>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            chc.Decaf = decaf;
            if (decaf) Assert.Equal(name, chc.ToString());
            else Assert.Equal(name, chc.ToString()); 
        }
    }
}
