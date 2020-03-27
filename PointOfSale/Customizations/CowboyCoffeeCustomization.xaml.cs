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
    /// Interaction logic for CowboyCoffeeCustomization.xaml
    /// </summary>
    public partial class CowboyCoffeeCustomization : UserControl
    {
        /// <summary>
        /// Constructor for this class
        /// </summary>
        public CowboyCoffeeCustomization()
        {
            InitializeComponent();
            Small.Checked += SizeSmall_Checked;
            Medium.Checked += SizeMedium_Checked;
            Large.Checked += SizeLarge_Checked;

            Small.Loaded += Init_Checked;
            Medium.Loaded += Init_Checked;
            Large.Loaded += Init_Checked;
        }

        /// <summary>
        /// Small size event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SizeSmall_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                coffee.Size = Size.Small;
            }
        }

        /// <summary>
        /// Medium size event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SizeMedium_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                coffee.Size = Size.Medium;
            }
        }

        /// <summary>
        /// Large size event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SizeLarge_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                coffee.Size = Size.Large;
            }
        }

        /// <summary>
        /// Checks the right button when loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void Init_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                switch (coffee.Size)
                {
                    case Size.Small:
                        Small.IsChecked = true;
                        break;
                    case Size.Medium:
                        Medium.IsChecked = true;
                        break;
                    case Size.Large:
                        Large.IsChecked = true;
                        break;
                }
            }
        }
    }
}
