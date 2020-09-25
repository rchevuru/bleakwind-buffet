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
    /// Interaction logic for EntreeChoices.xaml
    /// </summary>
    public partial class EntreeChoices : UserControl
    {
        public EntreeChoices()
        {
            InitializeComponent();
        }

        void switchToBriarheartBurgerChoices(object sender, RoutedEventArgs e)
        {

        }

        void goBackToMenu(object sender, RoutedEventArgs e)
        {
            var menu = new Menu();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(menu);
        }
    }
}
