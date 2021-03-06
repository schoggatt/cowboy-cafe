﻿using CowboyCafe.Data;
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
    /// Interaction logic for BakedBeansCustomization.xaml
    /// </summary>
    public partial class BakedBeansCustomization : UserControl
    {
        /// <summary>
        /// Constructor for class
        /// </summary>
        public BakedBeansCustomization()
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
        /// Small size button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SizeSmall_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is BakedBeans beans)
            {
                beans.Size = Size.Small;
            }
        }

        /// <summary>
        /// Medium size button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SizeMedium_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is BakedBeans beans)
            {
                beans.Size = Size.Medium;
            }
        }

        /// <summary>
        /// Large size button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SizeLarge_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is BakedBeans beans)
            {
                beans.Size = Size.Large;
            }
        }

        /// <summary>
        /// Checks the right button when loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void Init_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is BakedBeans beans)
            {
                switch(beans.Size)
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
