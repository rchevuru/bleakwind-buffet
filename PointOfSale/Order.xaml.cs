/*
 * Author: Rana Chevuru
 * Class:Order.xaml.cs
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
    /// Interaction logic for Order.xaml
    /// Displays the menu and order
    /// </summary>
    public partial class Order : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public Order()
        {
            InitializeComponent();
        }

        public void AddToOrder(object sender, RoutedEventArgs e)
        {

        }
    }
}
