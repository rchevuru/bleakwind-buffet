/*
 * Author: Rana Chevuru
 * Class:CustomWarriorWater.xaml.cs  
 * Purpose: Displays the custombinations for WarriorWater
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
    /// Interaction logic for CustomWarriorWater.xaml
    /// Displays the custombinations for WarriorWater
    /// </summary>
    public partial class CustomWarriorWater : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public CustomWarriorWater()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Goes back to the other sizes for WarriorWater
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizes(object sender, RoutedEventArgs e)
        {
            var sizes = new SizesMarkarthMilk();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(sizes);
        }
    }
}
