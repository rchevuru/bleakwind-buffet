/*
 * Author: Rana Chevuru
 * Class:CustomSailorSoda.xamlcs  
 * Purpose: Displays the custombinations for SailorSoda
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
    /// Interaction logic for CustomSailorSoda.xaml
    /// Displays the custombinations for SailorSoda
    /// </summary>
    public partial class CustomSailorSoda : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public CustomSailorSoda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches to the SailorSoda sizes
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizes(object sender, RoutedEventArgs e)
        {
            var sizes = new SizesSailorSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(sizes);
        }
    }
}
