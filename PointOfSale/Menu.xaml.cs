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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void SwitchtoMenuOptiontoEntree(object sender, RoutedEventArgs e)
        {
            //var entree = new EntreeChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(new EntreeChoices()); 
        }
        
        public void SwitchtoMenuOptionToDrink(object sender, RoutedEventArgs e)
        {
            var drink = new DrinkChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(drink);
        }

        public void SwitchtoMenuOptionToSide(object sender, RoutedEventArgs e)
        {
            var side = new SidesChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(side);
        }
    }

}
