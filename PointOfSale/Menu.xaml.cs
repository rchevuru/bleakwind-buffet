/*
 * Author: Rana Chevuru
 * Class:Menu.xaml.cs
 * Purpose: Displays the menu and order 
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
using BleakwindBuffet.Data; 

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// Displays the menu and order
    /// </summary>
    public partial class Menu : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches screens for all the entree choices  
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        public void SwitchtoMenuOptiontoEntree(object sender, RoutedEventArgs e)
        {
            //var entree = new EntreeChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(new EntreeChoices()); 
        }

        /// <summary>
        /// Switches screens for all the drink choices  
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        public void SwitchtoMenuOptionToDrink(object sender, RoutedEventArgs e)
        {
            var drink = new DrinkChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(drink);
        }

        /// <summary>
        /// Switches screens for all the side choices  
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        public void SwitchtoMenuOptionToSide(object sender, RoutedEventArgs e)
        {
            var side = new SidesChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(side);
        }
    }

}
