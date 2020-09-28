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
    /// </summary>
    public partial class SidesChoices : UserControl
    {
        public SidesChoices()
        {
            InitializeComponent();
        }

        void switchToSizesforSizesForDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            var size = new SizesForDragonbornWaffleFries();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        void switchToSizesforSizesForFriedMiraak(object sender, RoutedEventArgs e)
        {
            var size = new SizesForFriedMiraak();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        void switchToSizesforSizesForMadOtarGrits(object sender, RoutedEventArgs e)
        {
            var size = new SizesForMadOtarGrits();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        void switchToSizesforSizesForVokunSalad(object sender, RoutedEventArgs e)
        {
            var size = new SizesForVokunSalad();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        void goBackToMenu(object sender, RoutedEventArgs e)
        {
            var menu = new Menu();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(menu);
        }
    }
}
