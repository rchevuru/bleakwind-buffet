﻿/*
 * Author: Rana Chevuru
 * Class:CustomBriarheartBurger.xaml.cs
 * Purpose: Displays the BriarheartBurger custominations 
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomBriarheartBurger.xaml
    /// Displays the BriarheartBurger custominations 
    /// </summary>
    public partial class CustomBriarheartBurger : UserControl
    {
        private OrderBackend ob;
        BriarheartBurger bhb; 
        //CustomBriarheartBurger bhb = new CustomBriarheartBurger();
        /// <summary>
        ///  Initialize Component to make the buttons work
        /// </summary>
        public CustomBriarheartBurger(OrderBackend backend, BriarheartBurger briarheartBurger)
        {
            InitializeComponent();
            ob = backend;
            bhb = briarheartBurger;
            DataContext = briarheartBurger; 
           //DataContext = new BriarheartBurger(); 
        }

        /// <summary>
        /// Goes back to the other entree options 
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToEntreeChoices(object sender, RoutedEventArgs e)
        {
            var choices = new EntreeChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(choices);
            ob.Add(((BriarheartBurger) DataContext)); 
        }
    }
}
