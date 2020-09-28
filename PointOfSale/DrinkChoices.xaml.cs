/*
 * Author: Rana Chevuru
 * DrinkChoices.xaml.cs
 * Purpose: Displays all drink choices  
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkChoices.xaml
    /// Displays all drink choices  
    /// </summary>
    public partial class DrinkChoices : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public DrinkChoices()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Displays the sizes for AretinoAppleJuice
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizesforSizesForAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            var size = new SizesForAppleJuice();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        /// <summary>
        /// Displays the sizes for CandlehearthCoffee
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizesforSizesForCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            var size = new SizesForCandlehearthCoffee();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        // <summary>
        /// Displays the sizes for MarkarthMilk
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizesforSizesForMarkarthMilk(object sender, RoutedEventArgs e)
        {
            var size = new SizesMarkarthMilk();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        // <summary>
        /// Displays the dirrent flavors for SailorSoda
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizesforFlavorsForSailorSodak(object sender, RoutedEventArgs e)
        {
            var flavor = new FlavorSailorSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(flavor);
        }

        // <summary>
        /// Displays the sizes for WarriorWater
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizesforSizesForWarriorWater(object sender, RoutedEventArgs e)
        {
            var size = new SizesWarriorWater();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        // <summary>
        /// Goes back to the main menu 
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void goBackToMenu(object sender, RoutedEventArgs e)
        {
            var menu = new Menu();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(menu);
        }
    }
}
