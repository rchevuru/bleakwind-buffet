﻿/*
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
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// Displays the menu and order
    /// </summary>
    public partial class Order : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public Order()
        {
            InitializeComponent();
            DataContext = new OrderBackend(); 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NewOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderBackend newOrder = new OrderBackend(); 
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            OrderBackend cancelOrder = new OrderBackend();
        }

        private void OrderItemView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void SpecialInstructionsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
