/*
 * Author: Rana Chevuru
 * Class:  SizesForFriedMiraak.xaml.cs  
 * Purpose:Displays the sizes for FriedMiraak
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
    /// Interaction logic for SizesForFriedMiraak.xaml
    /// Displays the sizes for FriedMiraak
    /// </summary>
    public partial class SizesForFriedMiraak : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public SizesForFriedMiraak()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Goes back to the other side options 
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
