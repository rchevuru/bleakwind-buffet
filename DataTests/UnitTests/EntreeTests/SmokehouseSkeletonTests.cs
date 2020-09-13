/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Test the SmokehouseSkeleton.cs class
    /// </summary>
    public class SmokehouseSkeletonTests
    {
        /// <summary>
        /// Checks if interface works 
        /// </summary>
        [Fact]
        public void CheckInterfaceForEntree()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(shs); 
        }

        /// <summary>
        /// Checks if base works 
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(shs); 
        }

        /// <summary>
        /// Cheaks to see if burger has SausageLink by default 
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.SausageLink); 
        }

        /// <summary>
        /// Cheaks to see if burger has Egg by default 
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.Egg);
        }

        /// <summary>
        /// Cheaks to see if burger has HashBrown by default 
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.HashBrowns); 
        }

        /// <summary>
        /// Cheaks to see if burger has Pancake by default 
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.Pancake); 
        }

        /// <summary>
        /// Cheacks to see we can remove the SausageLink 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.SausageLink = false;
            Assert.False(shs.SausageLink);
            shs.SausageLink = true;
            Assert.True(shs.SausageLink); 
        }

        /// <summary>
        /// Cheacks to see we can remove the Egg 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.Egg = false;
            Assert.False(shs.Egg);
            shs.Egg = true;
            Assert.True(shs.Egg);
        }

        /// <summary>
        /// Cheacks to see we can remove the HashBrowns 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.HashBrowns = false;
            Assert.False(shs.HashBrowns);
            shs.HashBrowns = true;
            Assert.True(shs.HashBrowns);
        }

        /// <summary>
        /// Cheacks to see we can remove the Pancake 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.Pancake = false;
            Assert.False(shs.Pancake);
            shs.Pancake = true;
            Assert.True(shs.Pancake);
        }

        /// <summary>
        /// Cheacks to see if price is correct 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal(5.62, shs.Price); 
        }

        /// <summary>
        /// Cheacks to see if calories is correct 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal((decimal) 602, (decimal) shs.Calories); 
        }

        /// <summary>
        /// Cheacks to see if there is any special instructions for the chef 
        /// </summary>
        /// <param name="includeSausage">Should the sausage be removed or not</param>
        /// <param name="includeEgg">Should the egg be removed or not</param>
        /// <param name="includeHashbrowns">Should the hash browns be removed or not</param>
        /// <param name="includePancake">Should the pancake be removed or not</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.SausageLink = includeSausage;
            shs.Egg = includeEgg;
            shs.HashBrowns = includeHashbrowns;
            shs.Pancake = includePancake;
            if (!includeSausage) Assert.Contains("Hold sausage", shs.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", shs.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", shs.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", shs.SpecialInstructions);
            else Assert.Empty(shs.SpecialInstructions); 
        }

        /// <summary>
        /// Cheacks if it order in the recepit matches  
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", shs.ToString()); 
        }
    }
}