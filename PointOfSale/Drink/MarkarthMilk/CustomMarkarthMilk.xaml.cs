/*
 * Author: Rana Chevuru
 * Class:CustomMarkarthMilk.xaml.cs  
 * Purpose: Displays the custombinations for MarkarthMilk
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
    /// Interaction logic for CustomMarkarthMilk.xaml
    /// Displays the custombinations for MarkarthMilk
    /// </summary>
    public partial class CustomMarkarthMilk : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public CustomMarkarthMilk()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Goes back to the other sizes for MarkarthMilk
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
