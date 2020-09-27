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
    /// Interaction logic for Ice.xaml
    /// </summary>
    public partial class CustomAretinoAppleJuice : UserControl
    {
        public CustomAretinoAppleJuice()
        {
            InitializeComponent();
        }

        void switchToSizes(object sender, RoutedEventArgs e)
        {
            var sizes = new SizesForAppleJuice();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(sizes);
        }
    }
}
