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
            var size = new SizesForAppleJuice();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        void switchToSizesforSizesForCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            var size = new SizesForCandlehearthCoffee();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        void switchToSizesforSizesForMarkarthMilk(object sender, RoutedEventArgs e)
        {
            var size = new SizesMarkarthMilk();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }

        void switchToSizesforFlavorsForSailorSodak(object sender, RoutedEventArgs e)
        {
            var flavor = new FlavorSailorSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(flavor);
        }

        void switchToSizesforSizesForWarriorWater(object sender, RoutedEventArgs e)
        {
            var size = new SizesWarriorWater();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(size);
        }
    }
}
