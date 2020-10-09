/*
 * Author: Rana Chevuru
 * Class:OrderControl.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// Displays the menu and order 
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Order(); 
        }

        /// <summary>
        /// Switches screens for menu 
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        public void SwitchMenuOrderScreen(UIElement element)
        {
            menuChoice.Child = element; 

        }
    }
}
