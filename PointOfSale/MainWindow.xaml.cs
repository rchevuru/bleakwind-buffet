/*
 * Author: Rana Chevuru
 * Class:MainWindow.xaml.cs
 * Purpose: Calls to OrderControl for display 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// Calls to OrderControl for display
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
