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
    /// </summary>
    public partial class SizesSailorSoda : UserControl
    {
        public SizesSailorSoda()
        {
            InitializeComponent();
        }

        void switchToCustomSailorSodaChoice(object sender, RoutedEventArgs e)
        {
            var css= new CustomSailorSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(css);
        }

        void switchToFlavorChoices(object sender, RoutedEventArgs e)
        {
            var flavor = new FlavorSailorSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(flavor);
        }

    }
}
