/*
 * Author: Rana Chevuru
 * Class:SizesSailorSoda.xaml.cs  
 * Purpose: Displays the sizes for SailorSoda
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
    /// Interaction logic for SizesSailorSoda.xaml
    /// Displays the sizes for SailorSoda
    /// </summary>
    public partial class SizesSailorSoda : UserControl
    {

        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public SizesSailorSoda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switchs to the SailorSoda  custombinations 
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToCustomSailorSodaChoice(object sender, RoutedEventArgs e)
        {
            var css= new CustomSailorSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(css);
        }

        /// <summary>
        /// Goes back to the other flavor options 
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToFlavorChoices(object sender, RoutedEventArgs e)
        {
            var flavor = new FlavorSailorSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(flavor);
        }

    }
}
