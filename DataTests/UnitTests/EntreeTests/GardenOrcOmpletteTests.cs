﻿/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 * Date Modified: 10/5/2020
 * Modifier: Rana Chevuru
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel; 

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    ///Test the GardenOrcOmelette.cs class
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// Checks if the Broccoli property is changed 
        /// </summary>
        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var dd = new GardenOrcOmelette();

            Assert.PropertyChanged(dd, "Broccoli", () =>
            {
                dd.Broccoli = true;
            });

            Assert.PropertyChanged(dd, "Broccoli", () =>
            {
                dd.Broccoli = false;
            });
        }

        /// <summary>
        /// Checks if the Mushrooms property is changed 
        /// </summary>
        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var dd = new GardenOrcOmelette();

            Assert.PropertyChanged(dd, "Mushrooms", () =>
            {
                dd.Mushrooms = true;
            });

            Assert.PropertyChanged(dd, "Mushrooms", () =>
            {
                dd.Mushrooms = false;
            });
        }

        /// <summary>
        /// Checks if the Tomato property is changed 
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var dd = new GardenOrcOmelette();

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = true;
            });

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });
        }


        /// <summary>
        /// Checks if the Cheddar property is changed 
        /// </summary>
        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var dd = new GardenOrcOmelette();

            Assert.PropertyChanged(dd, "Cheddar", () =>
            {
                dd.Cheddar = true;
            });

            Assert.PropertyChanged(dd, "Cheddar", () =>
            {
                dd.Cheddar = false;
            });
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged interface works 
        /// </summary>
        [Fact]
        public void CheckINotifyPropertyChanged()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(goo);
        }
        /// <summary>
        /// Checks if interface works 
        /// </summary>
        [Fact]
        public void CheckInterfaceForEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo); 
        }

        /// <summary>
        /// Checks if base works 
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        /// <summary>
        /// Cheaks to see if burger has Broccoli by default 
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        /// <summary>
        /// Cheaks to see if burger has Mushrooms by default 
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }


        /// <summary>
        /// Cheaks to see if burger has Tomato by default 
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato); 
        }

        /// <summary>
        /// Cheaks to see if burger has Chedder by default 
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        /// <summary>
        /// Cheacks to see we can remove the broccoli 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli); 
        }

        /// <summary>
        /// Cheacks to see we can remove the mushrooms 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        /// <summary>
        /// Cheacks to see we can remove the tomato 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        /// <summary>
        /// Cheacks to see we can remove the chedder 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        /// <summary>
        /// Cheacks to see if price is correct 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price); 
        }

        /// <summary>
        /// Cheacks to see if calories is correct 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal((double)404, (double)goo.Calories); 
        }

        /// <summary>
        ///  Cheacks to see if there is any special instructions for the chef 
        /// </summary>
        /// <param name="includeBroccoli">Should the broccoli be removed or not</param>
        /// <param name="includeMushrooms">Should the mushroom be removed or not</param>
        /// <param name="includeTomato">Should the tomato be removed or not</param>
        /// <param name="includeCheddar">Should the cheddar be removed or not</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar; 
            if (!includeBroccoli) Assert.Contains("Hold broccoli", goo.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", goo.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions); 
        }

        /// <summary>
        /// Cheacks if it order in the recepit matches  
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }
    }
}