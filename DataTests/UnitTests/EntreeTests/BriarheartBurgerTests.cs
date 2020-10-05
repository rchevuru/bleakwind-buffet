/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel; 

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests the BriarheartBurger.cs class
    /// </summary>
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// Checks if the Bun property is changed 
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var bhb = new BriarheartBurger();

            Assert.PropertyChanged(bhb, "Bun", () =>
            {
                bhb.Bun = true;
            });

            Assert.PropertyChanged(bhb, "Bun", () =>
            {
                bhb.Bun = false;
            });
        }

        /// <summary>
        /// Checks if the Ketchup property is changed 
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var bhb = new BriarheartBurger();

            Assert.PropertyChanged(bhb, "Ketchup", () =>
            {
                bhb.Ketchup = true;
            });

            Assert.PropertyChanged(bhb, "Ketchup", () =>
            {
                bhb.Ketchup = false;
            });
        }

        /// <summary>
        /// Checks if the Mustard property is changed 
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var bhb = new BriarheartBurger();

            Assert.PropertyChanged(bhb, "Mustard", () =>
            {
                bhb.Mustard = true;
            });

            Assert.PropertyChanged(bhb, "Mustard", () =>
            {
                bhb.Mustard = false;
            });
        }

        /// <summary>
        /// Checks if the Pickle property is changed 
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var bhb = new BriarheartBurger();

            Assert.PropertyChanged(bhb, "Pickle", () =>
            {
                bhb.Pickle = true;
            });

            Assert.PropertyChanged(bhb, "Pickle", () =>
            {
                bhb.Pickle = false;
            });
        }

        /// <summary>
        /// Checks if the Cheese property is changed 
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var bhb = new BriarheartBurger();

            Assert.PropertyChanged(bhb, "Cheese", () =>
            {
                bhb.Cheese = true;
            });

            Assert.PropertyChanged(bhb, "Cheese", () =>
            {
                bhb.Cheese = false;
            });
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged interface works 
        /// </summary>
        [Fact]
        public void CheckINotifyPropertyChanged()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bhb);
        }

        /// <summary>
        /// Checks if interface works 
        /// </summary>
        [Fact]
        public void CheckInterfaceForEntree()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bhb); 
        }

        /// <summary>
        /// Checks if base works 
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bhb); 
        }
        /// <summary>
        /// Cheaks to see if burger has bun by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Bun); 

        }

        /// <summary>
        /// Cheaks to see if burger has ketchup by default 
        /// </summary
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Ketchup); 

        }

        /// <summary>
        /// Cheaks to see if mustard has bun by default 
        /// </summary
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Mustard); 
        }

        /// <summary>
        /// /// <summary>
        /// Cheaks to see if burger has pickle by default 
        /// </summary
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Pickle); 
        }

        /// <summary>
        /// Cheaks to see if burger has cheese by default 
        /// </summary
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Cheese); 
        }

        /// <summary>
        /// Cheacks to see we can remove the bun 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Bun = false;
            Assert.False(bhb.Bun);
            bhb.Bun = true;
            Assert.True(bhb.Bun);

        }

        /// <summary>
        /// Cheacks to see we can remove the ketchup 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Ketchup = false;
            Assert.False(bhb.Ketchup);
            bhb.Ketchup = true;
            Assert.True(bhb.Ketchup); 
        }

        /// <summary>
        /// Cheacks to see we can remove the mustard 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Mustard = false;
            Assert.False(bhb.Mustard);
            bhb.Mustard = true;
            Assert.True(bhb.Mustard);
        }

        /// <summary>
        /// Cheacks to see we can remove the pickle 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Pickle = false;
            Assert.False(bhb.Pickle);
            bhb.Pickle = true;
            Assert.True(bhb.Pickle);
        }

        /// <summary>
        /// Cheacks to see we can remove the cheese 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Cheese = false;
            Assert.False(bhb.Cheese);
            bhb.Cheese = true;
            Assert.True(bhb.Cheese); 
        }

        /// <summary>
        /// Ches to see if the price is right
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.Equal(6.32, bhb.Price); 
        }

        /// <summary>
        /// Cheacks to see if calories are correct 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.Equal((decimal)743, (decimal)bhb.Calories); 
        }

        /// <summary>
        /// Cheacks to see if there is any special instructions for the chef 
        /// </summary>
        /// <param name="includeBun">Should the bun be removed or not </param>
        /// <param name="includeKetchup">Should the ketchup be removed or not</param>
        /// <param name="includeMustard">Should the mustard be removed or not</param>
        /// <param name="includePickle">Should the pickle be removed or not</param>
        /// <param name="includeCheese">Should the cheese be removed or not</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Bun = includeBun;
            bhb.Ketchup = includeKetchup;
            bhb.Mustard = includeMustard;
            bhb.Pickle = includePickle;
            bhb.Cheese = includeCheese;
            if (!includeBun) Assert.Contains("Hold bun", bhb.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup",bhb.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", bhb.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", bhb.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", bhb.SpecialInstructions);
            else Assert.Empty(bhb.SpecialInstructions);

        }

        /// <summary>
        /// Cheacks if it order in the recepit matches  
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bhb.ToString()); 
        }
    }
}