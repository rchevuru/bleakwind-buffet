/*
 * Author: Rana Chevuru
 * Class:SidesChoices.xaml.cs  
 * Purpose: Displays the side options
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
    /// Interaction logic for SidesChoices.xaml
    /// Displays the side options
    /// </summary>
    public partial class SidesChoices : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public SidesChoices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the sizes for DragonbornWaffleFries
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizesforSizesForDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            var size = new SizesForDragonbornWaffleFries();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        /// <summary>
        /// Displays the sizes for FriedMiraak
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizesforSizesForFriedMiraak(object sender, RoutedEventArgs e)
        {
            var size = new SizesForFriedMiraak();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        /// <summary>
        /// Displays the sizes for MadOtarGrits
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizesforSizesForMadOtarGrits(object sender, RoutedEventArgs e)
        {
            var size = new SizesForMadOtarGrits();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        /// <summary>
        /// Displays the sizes for VokunSalad
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToSizesforSizesForVokunSalad(object sender, RoutedEventArgs e)
        {
            var size = new SizesForVokunSalad();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        /// <summary>
        /// Displays the menu choices
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void goBackToMenu(object sender, RoutedEventArgs e)
        {
            var menu = new Menu();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(menu);
        }
    }
}
