/*
 * Author: Rana Chevuru
 * Class:SizesForAppleJuice.xaml.cs  
 * Purpose: Displays the sizes for AppleJuice
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
    /// Interaction logic for CustomAretinoAppleJuice.xaml
    /// Displays the sizes for AppleJuice
    /// </summary>
    public partial class SizesForAppleJuice : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public SizesForAppleJuice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switchs to the AretinoAppleJuice  custombinations 
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToCustomAretinoAppleJuiceChoice(object sender, RoutedEventArgs e)
        {
            var caj = new CustomAretinoAppleJuice();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(caj);
        }

        /// <summary>
        /// Goes back to the other drink options 
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToDrinkChoices(object sender, RoutedEventArgs e)
        {
            var choices = new DrinkChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(choices);
        }
    }
}
