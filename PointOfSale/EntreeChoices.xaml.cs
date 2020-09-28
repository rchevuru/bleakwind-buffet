/*
 * Author: Rana Chevuru
 * Class:EntreeChoices.xaml.cs
 * Purpose: Displays all entree choices  
 */
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
    /// Displays all entree choices  
    /// </summary>
    public partial class EntreeChoices : UserControl
    {
        /// <summary>
        ///  Initialize Component to make the buttons work 
        /// </summary>
        public EntreeChoices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the sizes for DragonbornWaffleFries
        /// </summary>
        /// <param name="sender">the object we trying to implement the function</param>
        /// <param name="e">the code that runs the function upon press</param>
        void switchToBriarheartBurgerChoices(object sender, RoutedEventArgs e)
        {
            var customize = new CustomBriarheartBurger();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }

        void switchToDoubleDraugrChoices(object sender, RoutedEventArgs e)
        {
            var customize = new CustomDoubleDraugr();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }

        void switchToGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            var customize = new GardenOrcOmelette();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }

        void switchToPhillyPoacher(object sender, RoutedEventArgs e)
        {
            var customize = new CustomPhillyPoacher();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }

        void switchToSokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            var customize = new CustomSokehouseSkeleton();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }

        void switchToThalmorTriple(object sender, RoutedEventArgs e)
        {
            var customize = new CustomThalmorTriple();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(customize);
        }

        void goBackToMenu(object sender, RoutedEventArgs e)
        {
            var menu = new Menu();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwitchMenuOrderScreen(menu);
        }
    }
}
