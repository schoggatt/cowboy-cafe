using CowboyCafe.Data;
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
using Size = CowboyCafe.Data.Size;

namespace PointOfSale.Customizations
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        /// <summary>
        /// Constructor for this class
        /// </summary>
        public JerkedSodaCustomization()
        {
            InitializeComponent();

            Sarsparilla.Checked += FlavorSarsparilla_Checked;
            RootBeer.Checked += FlavorRootBeer_Checked;
            OrangeSoda.Checked += FlavorOrangeSoda_Checked;
            BirchBeer.Checked += FlavorBirchBeer_Checked;
            CreamSoda.Checked += FlavorCreamSoda_Checked;

            Small.Checked += SizeSmall_Checked;
            Medium.Checked += SizeMedium_Checked;
            Large.Checked += SizeLarge_Checked;
        }

        /// <summary>
        /// Sarsparilla checked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void FlavorSarsparilla_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            }
        }

        /// <summary>
        /// Root beer checked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void FlavorRootBeer_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.RootBeer;
            }
        }

        /// <summary>
        /// Cream soda checked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void FlavorCreamSoda_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            }
        }

        /// <summary>
        /// Orange soda event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void FlavorOrangeSoda_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.OrangeSoda;
            }
        }

        /// <summary>
        /// Birch beer event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void FlavorBirchBeer_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.BirchBeer;
            }
        }

        /// <summary>
        /// Small size event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SizeSmall_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = Size.Small;
            }
        }

        /// <summary>
        /// Medium size event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SizeMedium_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = Size.Medium;
            }
        }

        /// <summary>
        /// Large size event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SizeLarge_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = Size.Large;
            }
        }
    }
}
