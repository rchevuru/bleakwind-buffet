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
    /// </summary>
    public partial class CustomSailorSoda : UserControl
    {
        public CustomSailorSoda()
        {
            InitializeComponent();
        }

        void switchToSizes(object sender, RoutedEventArgs e)
        {
            var sizes = new SizesSailorSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(sizes);
        }
    }
}
