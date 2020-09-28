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
    /// </summary>
    public partial class SizesForVokunSalad : UserControl
    {
        public SizesForVokunSalad()
        {
            InitializeComponent();
        }

        void switchToDrinkChoices(object sender, RoutedEventArgs e)
        {
            var choices = new SidesChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(choices);
        }
    }
}
