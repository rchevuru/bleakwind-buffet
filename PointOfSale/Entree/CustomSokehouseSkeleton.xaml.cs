/*
 * Author: Rana Chevuru
 * Class:CustomSokehouseSkeleton.xaml.cs
 * Purpose: Displays the SokehouseSkeleton custominations 
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
    /// Interaction logic for CustomSokehouseSkeleton.xaml
    /// Displays the SokehouseSkeleton custominations 
    /// </summary>
    public partial class CustomSokehouseSkeleton : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public CustomSokehouseSkeleton()
        {
            InitializeComponent();
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
        }
    }
}
