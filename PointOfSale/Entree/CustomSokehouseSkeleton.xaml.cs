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
    /// Interaction logic for CustomSokehouseSkeleton.xaml
    /// </summary>
    public partial class CustomSokehouseSkeleton : UserControl
    {
        public CustomSokehouseSkeleton()
        {
            InitializeComponent();
        }

        void switchToEntreeChoices(object sender, RoutedEventArgs e)
        {
            var choices = new EntreeChoices();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(choices);
        }
    }
}
