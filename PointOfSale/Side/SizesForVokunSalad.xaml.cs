/*
 * Author: Rana Chevuru
 * Class:SizesForVokunSalad.xaml.cs  
 * Purpose: Displays the sizes for VokunSalad
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
    /// Interaction logic for SizesForVokunSalad.xaml
    /// Displays the sizes for VokunSalad
    /// </summary>
    public partial class SizesForVokunSalad : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public SizesForVokunSalad()
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
            var choices = new SidesChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(choices);
        }
    }
}
