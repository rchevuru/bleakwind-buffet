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
    /// Interaction logic for DrinkChoices.xaml
    /// </summary>
    public partial class DrinkChoices : UserControl
    {
        public DrinkChoices()
        {
            InitializeComponent();
        }

        void goBackToMenu(object sender, RoutedEventArgs e)
        {
            var menu = new Menu();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(menu);
        }
        
        void switchToSizesforSizesForAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            var customize = new SizesForAppleJuice();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }

        void switchToSizesforSizesForCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            var customize = new SizesForCandlehearthCoffee();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }

        void switchToSizesforSizesForMarkarthMilk(object sender, RoutedEventArgs e)
        {
            var customize = new SizesMarkarthMilk();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }

        void switchToSizesforFlavorsForSailorSodak(object sender, RoutedEventArgs e)
        {
            var customize = new FlavorSailorSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }
    }
}
