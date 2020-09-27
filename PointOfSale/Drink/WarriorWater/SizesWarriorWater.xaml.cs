﻿using System;
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
    /// Interaction logic for SizesWarriorWater.xaml
    /// </summary>
    public partial class SizesWarriorWater : UserControl
    {
        public SizesWarriorWater()
        {
            InitializeComponent();
        }

        void switchToCustomWarriorWater(object sender, RoutedEventArgs e)
        {
            var cww = new CustomWarriorWater();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(cww);
        }

        void switchToDrinkChoices(object sender, RoutedEventArgs e)
        {
            var choices = new DrinkChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(choices);
        }
    }
}
