/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
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
    /// Test the ThalmorTriple.cs class
    /// </summary>
    public class ThalmorTripleTests
    {
        /// <summary>
        /// Checks if the Bun property is changed 
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = true;
            });

            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = false;
            });
        }

        /// <summary>
        /// Checks if the Ketchup property is changed 
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = true;
            });

            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = false;
            });
        }

        /// <summary>
        /// Checks if the Mustard property is changed 
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = true;
            });

            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = false;
            });
        }

        /// <summary>
        /// Checks if the Pickle property is changed 
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = true;
            });

            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = false;
            });
        }

        /// <summary>
        /// Checks if the Cheese property is changed 
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = true;
            });

            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = false;
            });
        }

        /// <summary>
        /// Checks if the Tomato property is changed 
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = true;
            });

            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = false;
            });
        }

        /// <summary>
        /// Checks if the Lettuce property is changed 
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = true;
            });

            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = false;
            });
        }

        /// <summary>
        /// Checks if the Mayo property is changed 
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = true;
            });

            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = false;
            });
        }

        /// <summary>
        /// Checks if the Bacon property is changed 
        /// </summary>
        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = true;
            });

            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = false;
            });
        }

        /// <summary>
        /// Checks if the Egg property is changed 
        /// </summary>
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = true;
            });

            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = false;
            });
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged interface works 
        /// </summary>
        [Fact]
        public void CheckINotifyPropertyChanged()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }
        /// <summary>
        /// Checks if interface works 
        /// </summary>
        [Fact]
        public void CheckInterfaceForEntree()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt); 
        }

        /// <summary>
        /// Checks if base works 
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt); 
        }

        /// <summary>
        /// Cheaks to see if burger has Bun by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun); 
        }

        /// <summary>
        /// Cheaks to see if burger has Ketchup by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup); 
        }

        /// <summary>
        /// Cheaks to see if burger has Mustard by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Cheaks to see if burger has pickle by default 
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        /// <summary>
        /// Cheaks to see if burger has cheese by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Cheaks to see if burger has tamato by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Cheaks to see if burger has lettuce by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Cheaks to see if burger has mayo by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Cheaks to see if burger has bacon by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Cheaks to see if egg has mayo by default 
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// Cheacks to see we can remove the bun 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun); 
        }

        /// <summary>
        /// Cheacks to see we can remove the ketchup 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Cheacks to see we can remove the mustard 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Cheacks to see we can remove the pickle 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }
        /// <summary>
        /// Cheacks to see we can remove the cheese 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Cheacks to see we can remove the tomato 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Cheacks to see we can remove the lettuce 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Cheacks to see we can remove the mayo 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Cheacks to see we can remove the bacon 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Cheacks to see we can remove the egg 
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }


        /// <summary>
        /// Cheacks to see if price is correct 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price); 
        }


        /// <summary>
        /// Cheacks to see if calories is correct 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal((double)943, (double)tt.Calories); 
        }

        /// <summary>
        /// Cheacks to see if there is any special instructions for the chef 
        /// </summary>
        /// <param name="includeBun">Should the bun be removed or not</param>
        /// <param name="includeKetchup">Should the ketchup be removed or not</param>
        /// <param name="includeMustard">Should the mustard be removed or not</param>
        /// <param name="includePickle">Should the pickle be removed or not</param>
        /// <param name="includeCheese">Should the cheese be removed or not</param>
        /// <param name="includeTomato">Should the tamato be removed or not</param>
        /// <param name="includeLettuce">Should the lettuce be removed or not</param>
        /// <param name="includeMayo">Should the mayo be removed or not</param>
        /// <param name="includeBacon">Should the macon be removed or not</param>
        /// <param name="includeEgg">Should the egg be removed or not</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple(); 
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg; 
            if (!includeBun) Assert.Contains("Hold bun", tt.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", tt.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", tt.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", tt.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", tt.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", tt.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", tt.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions); 
        }

        /// <summary>
        /// Cheacks if it order in the recepit matches  
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString()); 
        }
    }
}